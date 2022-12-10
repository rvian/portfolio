using System;
using System.Data;
using System.Data.SqlClient;


namespace IntegracaoRM
{
    public class Respository
    {
        private const string BD_CONNECTION = ""; //target SQL SERVER connection string

        public void InserirRateioRM(string CodigoColigada, string Chapa, string CodigoTomador)
        {

            Console.WriteLine(" Inserindo rateio...");
            string sql = @$"INSERT INTO [dbo].[RATEIOTOMADOR]
                                       ([CODCOLIGADA]
                                       ,[CHAPA]
                                       ,[CODTOMADOR]
                                       ,[CODCOLTOMADOR]
                                       ,[VALOR]
                                       ,[TPTOMADOR]
                                       ,[ID]
                                       ,[CEI]
                                       ,[RECCREATEDBY]
                                       ,[RECCREATEDON]
                                       ,[RECMODIFIEDBY]
                                       ,[RECMODIFIEDON])
                                 VALUES
                                       (@CODCOLIGADA
                                       ,@CHAPA
                                       ,@CODTOMADOR
                                       ,''--CODCOLTOMADOR
                                       ,30.00--VALOR
                                       ,1--TPTOMADOR
                                       ,0--ID
                                       ,''--CEI
                                       ,'integracao.zellar'--RECCREATEDBY
                                       ,@DataIntegracao--RECCREATEDON
                                       ,'integracao.zellar'--RECMODIFIEDBY)
                                       ,@DataIntegracao--RECMODIFIEDON
                                       )";


            SqlConnection conn = new(""); //source SQL SERVER connection string

            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@CODCOLIGADA", CodigoColigada);
            cmd.Parameters.AddWithValue("@CHAPA", Chapa);
            cmd.Parameters.AddWithValue("@CODTOMADOR", CodigoTomador);
            cmd.Parameters.AddWithValue("@DataIntegracao", System.DateTime.UtcNow.AddHours(-3));

            cmd.ExecuteNonQuery();
            conn.Close();

        }
        public DataSet ConsultaFuncionarioImportacao()
        {
            SqlConnection conn = new SqlConnection(BD_CONNECTION);
            SqlCommand sql = new SqlCommand($@"SELECT * FROM View_Funcionario", conn);

            DataSet ds = new DataSet();

            conn.Open();

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sql;
            adapter.Fill(ds, "PFunc");

            conn.Close();


            return ds;
        }


        public DataSet ConsultaDependenteFuncionarioImportacao(string idPreAdmissao)
        {
            SqlConnection conn = new SqlConnection(BD_CONNECTION);
            SqlCommand sql = new SqlCommand($@"SELECT * FROM View_Dependente WHERE IdPreAdmissao = @IdPreAdmissao", conn);


            DataSet ds = new DataSet();

            conn.Open();
            sql.Parameters.AddWithValue("@IdPreAdmissao", idPreAdmissao);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = sql;
            adapter.Fill(ds, "PFDepend");

            conn.Close();


            return ds;
        }

        public void AtualizaStatusIntegracao(string idPreAdmissao, string status, string observacao, Boolean integrado)
        {
            //
            string sql = @"UPDATE dbo.PreAdmissao
                        SET ObservacaoIntegracao = @ObservacaoIntegracao,
                            StatusIntegracao = @StatusIntegracao,
                            INTEGRADO = @Integrado,
                            DataEventointegracao = @DataIntegracao
                        WHERE IdPreAdmissao = @IdPreAdmissao";


            SqlConnection conn = new SqlConnection("SQL SERVER {CONNECTION STRING}");
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@IdPreAdmissao", idPreAdmissao);
            cmd.Parameters.AddWithValue("@StatusIntegracao", status);
            cmd.Parameters.AddWithValue("@ObservacaoIntegracao", observacao);
            cmd.Parameters.AddWithValue("@Integrado", integrado);
            cmd.Parameters.AddWithValue("@DataIntegracao", System.DateTime.UtcNow.AddHours(-3));

            cmd.ExecuteNonQuery();
            conn.Close();
        }



        public void AtualizaStatusAdmissao(string idPreAdmissao, string status)
        {
            //
            string sql = @"UPDATE dbo.PreAdmissao
                        SET Status = @StatusIntegracao
                        WHERE IdPreAdmissao = @IdPreAdmissao";


            SqlConnection conn = new SqlConnection("SQL SERVER {CONNECTION STRING}");
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@IdPreAdmissao", idPreAdmissao);
            cmd.Parameters.AddWithValue("@StatusIntegracao", status);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void AtualizaPodeImportar(string idPreAdmissao, Boolean podeImportar)
        {
            string sql = @"UPDATE dbo.PreAdmissao
                        SET PodeIntegrar = @PodeIntegrar
                        WHERE IdPreAdmissao = @IdPreAdmissao";

            SqlConnection conn = new SqlConnection("SQL SERVER {CONNECTION STRING}");
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@IdPreAdmissao", idPreAdmissao);
            cmd.Parameters.AddWithValue("@PodeIntegrar", podeImportar);

            cmd.ExecuteNonQuery();

            conn.Close();

        }


        public void AtualizaLogErro(string idPreAdmissao, string observacaoCompleta)
        {
            string sql = "INSERT INTO [dbo].[PreAdmissaoIntegracao] ([IdPreAdmissao],[StatusIntegracao],[ObservacaoStatus],[Integrado],[DataIntegracao])VALUES";
            sql += "(@IdPreAdmissao,'Falha integração', @ObservacaoStatus, 0, @DataIntegracao)";

            SqlConnection conn = new SqlConnection("SQL SERVER {CONNECTION STRING}");
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();

            cmd.Parameters.AddWithValue("@IdPreAdmissao", idPreAdmissao);
            cmd.Parameters.AddWithValue("@ObservacaoStatus", observacaoCompleta);
            cmd.Parameters.AddWithValue("@DataIntegracao", System.DateTime.UtcNow.AddHours(-3));


            cmd.ExecuteNonQuery();

            conn.Close();

        }


    }
}
