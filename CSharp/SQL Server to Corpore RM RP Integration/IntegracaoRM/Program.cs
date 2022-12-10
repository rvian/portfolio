using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace IntegracaoRM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Respository repository = new Respository();

                string usuario = "";
                string senha = "";

                // webservice 
                string url = "{SERVER}";

                // rodar a cada 5m (300000 ms)
                int tempoMs = 300000;
                while (true)
                {
                    Console.Clear();
                    // Consulta funcionários que estão com o cadastro de preadmissao concluído
                    var funcionarios = repository.ConsultaFuncionarioImportacao();
                    var qtdFuncionarios = funcionarios.Tables["PFunc"].Rows.Count;


                    if (qtdFuncionarios > 0) {

                        Console.WriteLine("*****************************************");

                        Console.WriteLine($" Rodada iniciada.\n {qtdFuncionarios} para serem integrados.\n");

                        Console.WriteLine("*****************************************");



                        var contSucesso = 0;
                        var contErro = 0;

                        foreach (DataRow func in funcionarios.Tables["PFunc"].Rows)
                        {

                            var chapa = func["Chapa"].ToString();
                            var nome = func["Nome"].ToString();
                            var cpf = func["cpf"].ToString();
                            var codColigada = func["codcoligada"].ToString();
                            var idPreAdmissao = func["IdPreAdmissao"].ToString();
                            var codCentroCusto = func["CODSECAO"].ToString();

                            Console.WriteLine($"* Iniciando integração chapa '{chapa}' *");

                            string contexto = $"CODSISTEMA=G;CODCOLIGADA={codColigada};CODUSUARIO={usuario}";
                            DataClient dataClient = new DataClient(url, contexto, usuario, senha);


                            var codPessoaCadastrado = GetCodigoPessoaCpf(cpf, dataClient);
                            if (codPessoaCadastrado != null)
                            {
                                if (!func.Table.Columns.Contains("CODPESSOA"))
                                {
                                    func.Table.Columns.Add("CODPESSOA");
                                    func.Table.Columns.Add("CODIGOPESSOA");
                                    func.Table.Columns.Add("CODIGO");
                                }
                                var intcodPessoaCadastrado = Int32.Parse(codPessoaCadastrado);
                                func["CODPESSOA"] = intcodPessoaCadastrado;
                                func["CODIGOPESSOA"] = intcodPessoaCadastrado;
                                func["CODIGO"] = intcodPessoaCadastrado;
                            }


                            DataTable dtStructure = funcionarios.Tables["PFunc"].Clone();
                            DataSet ds = ConverteRowParaDatasetPFunc(dtStructure, func);

                            Boolean centroCustoExiste = VerificarCentroCustoExiste(codColigada, codCentroCusto, dataClient);
                            if (!centroCustoExiste)
                            {
                                Console.Write($"Centro custo '{codCentroCusto}' não encontrado.\nVerifique se o CC foi cadastrado no RM ou se a coligada '{codColigada}' está correta.\n");
                                repository.AtualizaStatusIntegracao(idPreAdmissao, "Cadastrado", $"Centro custo '{codCentroCusto}' não encontrado.\nVerifique se o CC foi cadastrado ou se a coligada '{codColigada}' está correta.", false);
                                repository.AtualizaStatusAdmissao(idPreAdmissao, "Cadastrado");
                                repository.AtualizaPodeImportar(idPreAdmissao, false);
                                continue;
                            }


                            string[] respFunc = null;
                            Boolean funcionarioExiste = VerificarFuncionarioExiste(codColigada, chapa, dataClient);
                            if (funcionarioExiste)
                            {
                                // remove datas de histórico
                                ds.Tables[0].Columns.Remove("DTMUDANCASALARIO");
                                ds.Tables[0].Columns.Remove("DTMUDANCAFUNCAO");
                                ds.Tables[0].Columns.Remove("HSTSIT_DATAMUDANCA");
                                ds.Tables[0].Columns.Remove("DTMUDANCASECAO");
                                ds.Tables[0].Columns.Remove("HSTSEFIP_DTMUDANCA");
                                ds.Tables[0].Columns.Remove("HSTBANCO_DTMUDANCA");
                                ds.Tables[0].Columns.Remove("DTMUDANCAHORARIO");
                                ds.Tables[0].Columns.Remove("DTMUDACATIPOREGIMEJORNADA");

                                Console.WriteLine("Funcionário já existente.\nAtualizando informações...");
                            }


                            respFunc = InserirFuncionario(ds, dataClient).Result;


                            string observacao = "";
                            if (respFunc == null || (respFunc[0] == codColigada && respFunc[1] == chapa)) // Integração PFUNC OK.
                            {
                                repository.InserirRateioRM(codColigada, chapa, func["CODIGOTOMADOR"].ToString());
                                var respDepend = InserirDependente(idPreAdmissao, dataClient).Result;
                                if (respDepend[0] == codColigada && respDepend[1] == chapa)
                                {
                                    //sucesso só quando inserir dependente OK tbm!.
                                    observacao = "Integrado com sucesso";
                                    repository.AtualizaStatusIntegracao(idPreAdmissao, "Integrado", observacao, true);
                                    repository.AtualizaStatusAdmissao(idPreAdmissao, "Integrado");
                                    repository.AtualizaPodeImportar(idPreAdmissao, false);

                                    Console.WriteLine($"'{nome}' integrado com sucesso.\n\n");
                                    contSucesso += 1;
                                }
                                else //Falha dependente
                                {
                                    string[] retornos = respDepend[0].Split("=======================================");

                                    observacao = "Falha ao integrar dependentes: \n" + retornos[0];
                                    repository.AtualizaStatusIntegracao(idPreAdmissao, "Falha Integração", observacao, false);
                                    repository.AtualizaStatusAdmissao(idPreAdmissao, "Cadastrado");
                                    repository.AtualizaPodeImportar(idPreAdmissao, false);
                                    if (retornos.Length < 2)
                                        repository.AtualizaLogErro(idPreAdmissao, retornos[0] + "|\n" + retornos[1] + "|\n");
                                    else
                                        repository.AtualizaLogErro(idPreAdmissao, retornos[0] + "|\n" + retornos[1] + "|\n" + retornos[4]);

                                    Console.WriteLine($"'{nome}' falha na integração.");
                                    Console.WriteLine($"'{retornos[0]}'\n-----------------\n{retornos[1]} \n");
                                    contErro += 1;
                                }
                            }
                            else // Falha integracao PFUNC
                            {
                                var res = respFunc.GetValue(0).ToString();

                                string[] retornos = res.Split("=======================================");
                                observacao = retornos[0];

                                repository.AtualizaStatusIntegracao(idPreAdmissao, "Falha Integração", observacao, false);
                                repository.AtualizaStatusAdmissao(idPreAdmissao, "Cadastrado");
                                repository.AtualizaPodeImportar(idPreAdmissao, false);
                                if (retornos.Length < 2)
                                    repository.AtualizaLogErro(idPreAdmissao, retornos[0] + "|\n" + retornos[1] + "|\n");
                                else
                                    repository.AtualizaLogErro(idPreAdmissao, retornos[0] + "|\n" + retornos[1] + "|\n" + retornos[2] + "|\n" + retornos[4]);

                                Console.WriteLine($"'{nome}' falha na integração.");
                                Console.WriteLine($"'{retornos[0]}'\n{retornos[1]} \n\n");
                                Console.WriteLine($"Log salvo na tabela Zellar2.PreAdmissaoIntegracao \n\n");
                                contErro += 1;
                            }
                        }
                        Console.WriteLine("*****************************************");
                        Console.WriteLine($"\n Rodada finalizada." +
                            $"\n {contSucesso} integrado(s) com sucesso." +
                            $"\n {contErro} não integrado(s) por erro." +
                            $"\n\n Próxima verificação às {DateTime.Now.AddMilliseconds(tempoMs).ToLongTimeString()}\n");
                        Console.WriteLine("*****************************************");

                    } else 
                    {
                        Console.WriteLine("*****************************************");
                        Console.WriteLine($"\n Sem funcionários para integrar...\n\n Próxima verificação às {DateTime.Now.AddMilliseconds(tempoMs).ToLongTimeString()}\n");
                        Console.WriteLine("*****************************************");
                    }
                    Thread.Sleep(tempoMs);
                }
            }
            catch (Exception e)
            {
                LogError(e);
                Console.Write("ERRO APLICAÇÃO.\nVERIFIQUE OS LOGS (~/ErrorLog)");
            }
        }

        public static Boolean VerificarCentroCustoExiste(string codColigada, string codCentroCusto, DataClient dataClient)
        {
            Console.WriteLine("Verificando se CC existe...");
            string filtro = codColigada + ";" + codCentroCusto;
            var getCC = dataClient.ReadRecord("FopCCustoData", filtro).Result.Item1;
            Boolean ccExiste = false;

            if (getCC.Tables.Count == 0)
                ccExiste = true;
            
            return ccExiste;
        }


        public static Boolean VerificarFuncionarioExiste(string codColigada, string chapa, DataClient dataClient)
        {
            string filtro = codColigada + ";" + chapa;
            var getFunc = dataClient.ReadRecord("FopFuncData", filtro).Result.Item1;

            Boolean funcionarioExiste = false;
            if (getFunc.Tables.Count > 1)
            {
                funcionarioExiste = true;
                Console.WriteLine("Funcionario já existente!\n Pulando para o próximo...");
            }

            return funcionarioExiste;
        }


        public static DataSet ConverteRowParaDatasetPFunc(DataTable dtStructure, DataRow funcionario)
        {
            dtStructure.LoadDataRow(funcionario.ItemArray, true);

            DataSet dataSet = new DataSet("PFunc");
            dataSet.Tables.Add(dtStructure);
            dataSet.Namespace = "FopFuncData";

            return dataSet;
        }

        public static async Task<string[]> InserirFuncionario(DataSet ds, DataClient dataClient)
        {
            // Adiciona colunas de rateio
            ds.Tables[0].Columns.Add("");
            Console.WriteLine("Inserindo funcionário...");

            string[] res = await dataClient.SaveRecord("FopFuncData", ds, false, false);
            //string[] res = null;
            return res;
        }

        public static async Task<string[]> InserirFuncionario(string xml, DataClient dataClient)
        {
            string[] res = await dataClient.SaveRecord("FopFuncData", xml);
            //string[] res = null;
            return res;
        }

        public static async Task<string[]> InserirDependente(string idPreAdmissao, DataClient dataClient)
        {
            Respository repository = new Respository();
            Console.WriteLine("Inserindo dependentes...");
            var depends = repository.ConsultaDependenteFuncionarioImportacao(idPreAdmissao);

            string[] res = await dataClient.SaveRecord("FopDependData", depends, false, false);
           // string[] res = null;

            return res;
        }

        public static string GetCodigoPessoaCpf(string cpf, DataClient dataClient)
        {
            string filtro = "CPF='" + cpf + "'";
            Console.WriteLine("Verificando se pessoa existe...");
            var ds = dataClient.ReadView("RhuPessoaData", filtro).Result.Item1.Tables;

            string codigoPessoa = null;
            if (ds.Count > 0)
            {
                codigoPessoa = ds[0].Rows[0]["Codigo"].ToString();
                Console.WriteLine($"Pessoa já existe ({codigoPessoa})");
            }

            return codigoPessoa;
        }

        private static async void LogError(Exception ex)
        {
            string message = string.Format("Time: {0}", DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"));


            message += Environment.NewLine;
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;
            message += string.Format("Message: {0}", ex.Message);
            message += Environment.NewLine;
            message += string.Format("StackTrace: {0}", ex.StackTrace);
            message += Environment.NewLine;
            message += string.Format("Source: {0}", ex.Source);
            message += Environment.NewLine;
            message += string.Format("TargetSite: {0}", ex.TargetSite.ToString());
            message += Environment.NewLine;
            if (ex.InnerException != null)
                message += string.Format("InnerException: {0}", ex.InnerException.ToString());
            message += "-----------------------------------------------------------";
            message += Environment.NewLine;

            string path = AppDomain.CurrentDomain.BaseDirectory + $"ErrorLog";
            string filename = $"\\ErrorLog-{DateTime.Now.ToString("dd-MM-yy")}.txt";

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path += filename;

            using StreamWriter file = new(path, append: true);
            {
                await file.WriteLineAsync(message);
            }
        }
        }
    }
