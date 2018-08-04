using System;

using System.Data;//usando o CommandType.StoredProcedure e para o DataTable e DataRow

using AcessoBancoDados; //para usar a classe de acesso ao firebird
using ObjetoTransferencia; //usar as classes(Material)

namespace Negocios
{
    public class MaterialNegocios
    {
        AcessoDadosFireBird acessoDadosFireBird = new AcessoDadosFireBird();//instanciar objeto acesso

        //public string pois ele retornará essa string
        public string Inserir(Material material) //já vem todos os parâmetros de material, ou seja, seus campos e propriedades
        {
            try
            {
                acessoDadosFireBird.LimparParametros();                                         // sempre limpar, para então 
                acessoDadosFireBird.AdicionarParametros("MAT_DESCRICAO", material.CadDesc);     //adicionar e depois executar
                acessoDadosFireBird.AdicionarParametros("MAT_UNID", material.Unid);
                acessoDadosFireBird.AdicionarParametros("MAT_V_UNIT", material.Valor);
                acessoDadosFireBird.AdicionarParametros("MAT_QUANT", material.Quant);
                acessoDadosFireBird.AdicionarParametros("MAT_FORNECEDOR_COD", material.FornecedorCod); //adicionar campos na ordem
                /*Novas alterações para se pegar o código de fornecedor e o nome em 31/01/2018 */
                
                acessoDadosFireBird.AdicionarParametros("MAT_FASE", material.Fase);             // da procedure!

                //para receber o id da procedure depois da inserção
                string idMaterial = acessoDadosFireBird.ExecutarManipulação(CommandType.StoredProcedure, "MAT_INSERIR_MATERIAL").ToString();

                return idMaterial;
            }
            catch (Exception exception)
            {
                return exception.Message;//retornando a string de mensagem do public string Inserir
            }
        }

        public string Alterar(Material material)//parâmetro do método para receber os dados digitados pelo usuário
        {
            try
            {
                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_COD", material.CadCod.ToString());
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_DESC", material.CadDesc);
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_UNID", material.Unid);
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_V_UNIT", material.Valor);
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_QUANT", material.Quant);
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_FORNECEDOR_COD", material.FornecedorCod);
                acessoDadosFireBird.AdicionarParametros("MAT_ATU_FASE", material.Fase);
                //para receber o id da procedure depois da inserção
                string idMaterial = acessoDadosFireBird.ExecutarManipulação(CommandType.StoredProcedure, "MAT_ATUALIZAR").ToString();

                return idMaterial;

            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public string Excluir(Material material)
        {
            try
            {
                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("DEL_COD", material.CadCod.ToString());
                string idMaterial = acessoDadosFireBird.ExecutarManipulação(CommandType.StoredProcedure, "MAT_EXCLUIR_MATERIAL").ToString();
                // pode juntar esses dois: return acessoDadosFireBird.ExecutarManipulação(Comm....
                return idMaterial;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }

        public MaterialColecao ConsultarPorDesc(string desc)
        {
            try
            {
                MaterialColecao materialColecao = new MaterialColecao();

                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("CON_DESC", desc);

                //para receber o resultado que terá múltiplas linhas
                DataTable dataTableMaterial = acessoDadosFireBird.ExecutarConsulta(CommandType.StoredProcedure, "MAT_CONSULTAR_MATERIAL_POR_DESC");

                //trabalhar com linhas rows no FOREACH dentro de cada linha do dataTableMaterial depois da consulta
                foreach (DataRow linha in dataTableMaterial.Rows)
                {
                    //Criar um cliente vazio
                    Material materialPorDesc = new Material();
                    //Colocar dados
                    materialPorDesc.CadCod = Convert.ToInt32(linha["MAT_COD"]);
                    materialPorDesc.CadDesc = Convert.ToString(linha["MAT_DESCRICAO"]);
                    materialPorDesc.Unid = Convert.ToString(linha["MAT_UNID"]);
                    materialPorDesc.Valor = Convert.ToDecimal(linha["MAT_V_UNIT"]);
                    materialPorDesc.Quant = Convert.ToDecimal(linha["MAT_QUANT"]);
                    materialPorDesc.Total = Convert.ToDecimal(linha["MAT_V_TOTAL"]);
                    materialPorDesc.MatData = Convert.ToDateTime(linha["MAT_DATA"]);
                    /* ALTERAÇÕES 31-01-2018 - usar o C:\\LASS\\Bancos Materiais\\Materiais Restore\\MATERIAIS 17-11-2017.FDB e
                    fazer backup
                     */
                    materialPorDesc.FornecedorCod = Convert.ToInt32(linha["MAT_FORNECEDOR_COD"]);
                    materialPorDesc.FornecedorDesc = Convert.ToString(linha["MAT_FORNECEDOR_NOME"]);
                    materialPorDesc.Fase = Convert.ToInt32(linha["MAT_FASE"]);

                    //E colocá-lo na Coleção
                    materialColecao.Add(materialPorDesc);
                }

                return materialColecao;//retornar o objeto de tipo MaterialColeção
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o material por descrição. Detalhes: " + exception);
            }
        }

        public MaterialColecao ConsultarPorCod(int cod)
        {
            try
            {
                MaterialColecao materialColecao = new MaterialColecao();

                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("CON_COD", Convert.ToString(cod));

                //para receber o resultado que terá múltiplas linhas
                DataTable dataTableMaterial = acessoDadosFireBird.ExecutarConsulta(CommandType.StoredProcedure, "MAT_CONSULTAR_MATERIAL_POR_ID");
                //trabalhar com linhas rows no FOREACH dentro de cada linha do dataTableMaterial depois da consulta
                foreach (DataRow linha in dataTableMaterial.Rows)
                {
                    //Criar um cliente vazio
                    Material materialCod = new Material();
                    //Colocar dados
                    materialCod.CadCod = Convert.ToInt32(linha["MAT_COD"]);
                    materialCod.CadDesc = Convert.ToString(linha["MAT_DESCRICAO"]);
                    materialCod.Unid = Convert.ToString(linha["MAT_UNID"]);
                    materialCod.Valor = Convert.ToDecimal(linha["MAT_V_UNIT"]);
                    materialCod.Quant = Convert.ToDecimal(linha["MAT_QUANT"]);
                    materialCod.Total = Convert.ToDecimal(linha["MAT_V_TOTAL"]);
                    materialCod.MatData = Convert.ToDateTime(linha["MAT_DATA"]);
                    materialCod.FornecedorCod = Convert.ToInt32(linha["MAT_FORNECEDOR_COD"]);
                    materialCod.FornecedorDesc = Convert.ToString(linha["MAT_FORNECEDOR_NOME"]);
                    materialCod.Fase = Convert.ToInt32(linha["MAT_FASE"]);

                    //E colocá-lo na Coleção
                    materialColecao.Add(materialCod);
                }

                return materialColecao;//retornar o objeto de tipo MaterialColeção
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o material por Código. Detalhes: " + exception);
            }
        }

        public MaterialTotal TotaisPorForn(MaterialTotal material)
        {
            try
            {
                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("CON_DESC", material.Fornecedor);
                
                //try-catch: tentativa com sucesso caso seja digitado algo inexistente
                try
                {
                    var dtDados = acessoDadosFireBird.ExecutarConsulta(CommandType.StoredProcedure, "MAT_TOTAL_POR_DESC");

                    material.Total =
                     dtDados.Rows.Count > 0 ? 
                        Convert.ToDecimal(
                            dtDados.Rows[0][0] is DBNull ? 0 : dtDados.Rows[0][0]
                        ) : 0;
                }
                catch
                {
                    return material;//teste
                }



                return material;//retornar o objeto de tipo MaterialColeção
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar material total por fornecedor. Detalhes: " + exception);
            }
        }

        public MaterialTotal TotaisPorFase(MaterialTotal material)
        {
            try
            {
                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("CON_FASE", material.Fase);
                
                var dtDados = acessoDadosFireBird.ExecutarConsulta(CommandType.StoredProcedure, "MAT_TOTAL_POR_FASE");
                
                material.Total = dtDados.Rows.Count > 0 ? Convert.ToDecimal(
                    dtDados.Rows[0][0] is DBNull ? 0 : dtDados.Rows[0][0]
                    ) : 0;

                return material;//retornar o objeto de tipo MaterialColeção
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o material total por fase. Detalhes: " + exception);
            }
        }

        
    }
}
