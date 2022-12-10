using System;
using System.Collections.Generic;
using System;
using System.Data;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace IntegracaoRM
{
    internal class ReadView
    {
        public async void ReadViewTeste()
        {
            // ajuste o nome o servidor e porta. Em caso de dúvidas, consulte o link abaixo:  
            // http://tdn.totvs.com/pages/releaseview.action?pageId=89620766    
            //string url = "http://localhost:8051";

            //importante passar no contexto o mesmo código de usuário usado para logar no webservice  
            string contexto = "CODSISTEMA=G;CODCOLIGADA=1;CODUSUARIO={USERNAME}";

            //usuário e senha do aplicativo RM. O mesmo utilizado para logar no sistema e que tenha permissão de   
            //acesso ao cadastro que deseja utilizar  


            string usuario = "";
            string senha = "";

            // webservice 
            string url = "{SERVER}";
            //o filtro pode ser qualquer campo da visão, por exemplo CODCOLIGADA=1 AND CODFILIAL = 1  
            string filtro = "1=1";


            // Retorna as credenciais para acesso ao WS  
            DataClient dataclient = new DataClient(url, contexto, usuario, senha);
            // lê os dados da visão respeitando o filtro passado  
            //var ds = dataclient.ReadView("FopRateioTomadoresServicoData", filtro).Result;
            // Pode utilizar o ds tipado para DataSet ou a variável recordData que possui o XML da solicitação   



            DataTable dt = new DataTable("PFRATEIOTOMADOR");


            
            dt.Columns.Add("CHAPA");
            dt.Columns.Add("CODCOLIGADA");
            dt.Columns.Add("CODIGOTOMADORTEMP");
            dt.Columns.Add("CODCOLTOMADOR");
            dt.Columns.Add("VALOR");
            dt.Columns.Add("TPTOMADOR");
            dt.Columns.Add("ID");
            dt.Columns.Add("CEI");

            dt.Rows.Add("090677",
                        "1",
                        "",
                        "00826.S001",
                        "30.00",
                        "1",
                        "0",
                        ""
                        );

            DataSet ds = new DataSet("PfRateioTomador");
            ds.Namespace = "FopRateioTomadoresServicoData";
            ds.Tables.Add(dt);



            string[] res = dataclient.SaveRecord("FopRateioTomadoresServicoData", ds, false, false).Result;

            for (int i = 0; i < res.Length; i++)
            {
                Console.WriteLine(res[i]);

            }


            Console.WriteLine(res.ToString());


            //for (int i = 0; i < res.Length; i++)
            //{
            //    Console.WriteLine(res[i]);

            //}


        }

    }
}
