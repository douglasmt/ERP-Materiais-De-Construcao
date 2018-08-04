using System;

//Namespaces de classes de dados
using System.Data;
using FirebirdSql.Data.FirebirdClient;
//using //System.Data.SqlClient;// para usar a SqlConnection

namespace AcessoBancoDados
{
    public class AcessoDadosFireBird //AcessoDadosSqlServer
    {
        //Cria Conexão
        private FbConnection CriarConexao() //private SqlConnection CriarConexao()
        {
            //return new SqlConnection(Settings.Default.stringConexaoFB);
            //por enquanto !!! return new FbConnection(Settings.Default.stringConexaoFB);
            // 1 usa a string definida em properties/settings
            return new FbConnection("User = SYSDBA; Password = masterkey; Database = C:\\LASS\\Materiais Restore\\MATERIAIS 2018-02-01.FDB"); //só isso pro FB funcionar
        }

        //Parâmetros para banco - private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;
        private FbParameterCollection sqlParameterCollection = new FbCommand().Parameters;

        //comando vai até o banco com as informações e volta as informações pelo Parameters
        public void LimparParametros()
        {   //limpeza para inserção de parâmetros
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros( string nomeParametro, object valorParametro)
        {   //inserção de parâmetros -sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro)) ;
            sqlParameterCollection.Add(new FbParameter(nomeParametro, valorParametro)) ;
        }

        //Persistência - Insert, Alterar, Excluir
        public object ExecutarManipulação(CommandType commandType, string nomeStoredProcedureOuTextoSql)
        {
            try
            {
                //que tipo de comando passo? CommandType.StoredProcedure para as procedures FB
                //criar conexao
                FbConnection sqlConnection = CriarConexao();//1

                //abrir conexao
                sqlConnection.Open();//2

                //Criar comando - SqlCommand sqlCommand = sqlConnection.CreateCommand();
                FbCommand sqlCommand = sqlConnection.CreateCommand();                
                sqlCommand.CommandType = commandType;///avisar se será procedure ou texto
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;
                sqlCommand.CommandTimeout = 500;

                //Adicionar os parâmetros 
                foreach (FbParameter sqlParameter in sqlParameterCollection)
                { //modi (SqlParameter sqlParameter in sqlParameterCollection)
                    sqlCommand.Parameters.Add(new FbParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                //Executar o comando
                return sqlCommand.ExecuteScalar();//retorna o Objeto ExecutarManipulação
            }
            catch (Exception ex )
            {
                throw new Exception(ex.Message);
            }
        }

        //Consultar várias linhas e colunas
        public DataTable ExecutarConsulta(CommandType commandType, string nomeStoredProcedureOuTextoSql/*, string desc*/)
        {      //tabela de dados(como gera no Select * ou um arquivo Excel)
            try
            {
                //que tipo de como passo? CommandType.StoredProcedure para as procedures FB
                //criar conexao
                FbConnection sqlConnection = CriarConexao();//rodovia para o acesso
                sqlConnection.Open(); //abrir conexao

                //Criar comando - SqlCommand sqlCommand = sqlConnection.CreateCommand();
                FbCommand sqlCommand = sqlConnection.CreateCommand();//como uma caixa para os comandos                
                sqlCommand.CommandType = commandType;//tipo///avisar se será procedure ou texto
                sqlCommand.CommandText = nomeStoredProcedureOuTextoSql;//nome, se é procedure ou comando DML
                sqlCommand.CommandTimeout = 500;

                //Adicionar os parâmetros 
                foreach (FbParameter sqlParameter in sqlParameterCollection)
                { //modi (SqlParameter sqlParameter in sqlParameterCollection)
                    sqlCommand.Parameters.Add(new FbParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }

                FbDataReader reader = sqlCommand.ExecuteReader();
                
                // criação do dataTable para receber o resultado do reader                 
                DataTable dataTable = new DataTable();//DataTable = que recebe o sqlDataAdapter
                
                dataTable = ObterTabela(reader); //sem uo de Fill de DataTable
                sqlConnection.Close();

                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ObterTabela(FbDataReader reader)
        {
            DataTable tbEsquema = reader.GetSchemaTable();
            DataTable tbRetorno = new DataTable();

            foreach (DataRow r in tbEsquema.Rows)
            {
                if (!tbRetorno.Columns.Contains(r["ColumnName"].ToString()))
                {
                    DataColumn col = new DataColumn()
                    {
                        ColumnName = r["ColumnName"].ToString(),
                        Unique = Convert.ToBoolean(r["IsUnique"]),
                        AllowDBNull = Convert.ToBoolean(r["AllowDBNull"]),
                        ReadOnly = Convert.ToBoolean(r["IsReadOnly"])
                    };
                    tbRetorno.Columns.Add(col);
                }
            }

            while (reader.Read())
            {
                DataRow novaLinha = tbRetorno.NewRow();
                for (int i = 0; i < tbRetorno.Columns.Count; i++)
                {
                    novaLinha[i] = reader.GetValue(i);
                }
                tbRetorno.Rows.Add(novaLinha);
            }

            return tbRetorno;
        }
    }
}
