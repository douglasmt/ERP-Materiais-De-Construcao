using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//usando o CommandType.StoredProcedure e para o DataTable e DataRow

using AcessoBancoDados; //para usar a classe de acesso ao firebird
using ObjetoTransferencia; //usar as classes(Material)

namespace Negocios
{
    public class FornecedorNegocios
    {
        AcessoDadosFireBird acessoDadosFireBird = new AcessoDadosFireBird();//instanciar objeto acesso

        public FornecedorColecao ConsultarPorDesc(string desc)
        {
            try
            {
                FornecedorColecao fornecedorColecao = new FornecedorColecao();

                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("CON_FORN_NOME", desc);

                //para receber o resultado que terá múltiplas linhas
                DataTable dataTableFornecedor = acessoDadosFireBird.ExecutarConsulta(CommandType.StoredProcedure, "FORN_CONSULTAR_FORN_POR_NOME");

                //trabalhar com linhas rows no FOREACH dentro de cada linha do dataTableMaterial depois da consulta
                foreach (DataRow linha in dataTableFornecedor.Rows)
                {
                    //Criar um cliente vazio
                    Fornecedor fornecedorPorDesc = new Fornecedor();
                    //Colocar dados
                    fornecedorPorDesc.Cod = Convert.ToInt32(linha["FORCOD"]);
                    fornecedorPorDesc.Status = Convert.ToString(linha["FORSTATUS"]);
                    fornecedorPorDesc.Situacao = Convert.ToString(linha["FORSITUACAO"]);
                    fornecedorPorDesc.Nome = Convert.ToString(linha["FORNOME"]);
                    fornecedorPorDesc.Pessoa = Convert.ToString(linha["FORPESSOA"]);
                    fornecedorPorDesc.Cnpj = Convert.ToString(linha["FORCNPJ"]);
                    fornecedorPorDesc.Insc = Convert.ToString(linha["FORINSC"]);
                    fornecedorPorDesc.End = Convert.ToString(linha["FOREND"]);
                    fornecedorPorDesc.Bai = Convert.ToString(linha["FORBAI"]);
                    fornecedorPorDesc.Cid = Convert.ToString(linha["FORCID"]);
                    fornecedorPorDesc.Est = Convert.ToString(linha["FOREST"]);

                    if (!(linha["FORCEP"] is DBNull) )
                        fornecedorPorDesc.Cep = Convert.ToDecimal(linha["FORCEP"]);

                    if (!(linha["FORDDD1"] is DBNull))
                        fornecedorPorDesc.DDD1 = Convert.ToDecimal(linha["FORDDD1"]);
                                        
                    fornecedorPorDesc.Fone1 = Convert.ToString(linha["FORFONE1"]);

                    if (!(linha["FORDDD2"] is DBNull))
                        fornecedorPorDesc.DDD2 = Convert.ToDecimal(linha["FORDDD2"]);

                    fornecedorPorDesc.Fone2 = Convert.ToString(linha["FORFONE2"]);

                    if (!(linha["FORDDDFax"] is DBNull))
                        fornecedorPorDesc.DDDFax = Convert.ToDecimal(linha["FORDDDDFax"]);
                    
                    fornecedorPorDesc.Fax = Convert.ToString(linha["FORFAX"]);
                    fornecedorPorDesc.Cont = Convert.ToString(linha["FORCONT"]);

                    if (!(linha["FORCONTDDD"] is DBNull))
                        fornecedorPorDesc.ContDDD = Convert.ToDecimal(linha["FORCONTDDD"]);

                    fornecedorPorDesc.ContFone = Convert.ToString(linha["FORCONTFONE"]);
                    fornecedorPorDesc.Cont2 = Convert.ToString(linha["FORCONT2"]);

                    if (!(linha["FORCONT2DDD"] is DBNull))
                        fornecedorPorDesc.Cont2DDD = Convert.ToDecimal(linha["FORCONT2DDD"]);

                    fornecedorPorDesc.Cont2Fone = Convert.ToString(linha["FORCONT2FONE"]);
                    fornecedorPorDesc.Cont3 = Convert.ToString(linha["FORCONT3"]);

                    if (!(linha["FORCONT3DDD"] is DBNull))
                        fornecedorPorDesc.Cont3DDD = Convert.ToDecimal(linha["FORCONT3DDD"]);

                    fornecedorPorDesc.Cont3Fone = Convert.ToString(linha["FORCONT3FONE"]);
                    fornecedorPorDesc.Email = Convert.ToString(linha["FOREMAIL"]);
                    fornecedorPorDesc.Fantasia = Convert.ToString(linha["FORFANTASIA"]);
                    fornecedorPorDesc.DataCad = Convert.ToString(linha["FORDATACAD"]);
                    fornecedorPorDesc.Ocorr = Convert.ToString(linha["FOROCORR"]);
                    fornecedorPorDesc.UltPed = Convert.ToString(linha["FORULTPED"]);
                    fornecedorPorDesc.Tipo = Convert.ToString(linha["FORTIPO"]);
                    fornecedorPorDesc.Cnae = Convert.ToString(linha["FORCNAE"]);

                    if (!(linha["FORCODMUNICIPIO"] is DBNull))
                        fornecedorPorDesc.CodMunicipio = Convert.ToInt32(linha["FORCODMUNICIPIO"]);

                     //E colocá-lo na Coleção
                    fornecedorColecao.Add(fornecedorPorDesc);
                }

                return fornecedorColecao;//retornar o objeto de tipo MaterialColeção
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o Fornecedor por descrição. Detalhes: " + exception);
            }
        }

        public FornecedorColecao ConsultarPorCod(int cod)
        {
            try
            {
                FornecedorColecao fornecedorColecao = new FornecedorColecao();

                acessoDadosFireBird.LimparParametros();
                acessoDadosFireBird.AdicionarParametros("CON_COD_FORN", Convert.ToString(cod));

                //para receber o resultado que terá múltiplas linhas
                DataTable dataTableFornecedor = acessoDadosFireBird.ExecutarConsulta(CommandType.StoredProcedure, "FORN_CONSULTAR_FORN_POR_ID");
                //trabalhar com linhas rows no FOREACH dentro de cada linha do dataTableMaterial depois da consulta
                foreach (DataRow linha in dataTableFornecedor.Rows)
                {
                    //Criar um cliente vazio
                    Fornecedor fornecedorPorDesc = new Fornecedor();
                    //Colocar dados
                    fornecedorPorDesc.Cod = Convert.ToInt32(linha["FORCOD"]);
                    fornecedorPorDesc.Status = Convert.ToString(linha["FORSTATUS"]);
                    fornecedorPorDesc.Situacao = Convert.ToString(linha["FORSITUACAO"]);
                    fornecedorPorDesc.Nome = Convert.ToString(linha["FORNOME"]);
                    fornecedorPorDesc.Pessoa = Convert.ToString(linha["FORPESSOA"]);
                    fornecedorPorDesc.Cnpj = Convert.ToString(linha["FORCNPJ"]);
                    fornecedorPorDesc.Insc = Convert.ToString(linha["FORINSC"]);
                    fornecedorPorDesc.End = Convert.ToString(linha["FOREND"]);
                    fornecedorPorDesc.Bai = Convert.ToString(linha["FORBAI"]);
                    fornecedorPorDesc.Cid = Convert.ToString(linha["FORCID"]);
                    fornecedorPorDesc.Est = Convert.ToString(linha["FOREST"]);
                    /* fornecedorPorDesc.Cep = Convert.ToInt32(linha["FORCEP"]);
                     fornecedorPorDesc.DDD1 = Convert.ToChar(linha["FORDDD1"]);
                     fornecedorPorDesc.Fone1 = Convert.ToString(linha["FORFONE1"]);
                     fornecedorPorDesc.DDD2 = Convert.ToInt32(linha["FORDDD2"]);
                     fornecedorPorDesc.Fone2 = Convert.ToString(linha["FORFONE2"]);
                     fornecedorPorDesc.DDDFax = Convert.ToInt32(linha["FORDDDFAX"]);
                     fornecedorPorDesc.Fax = Convert.ToString(linha["FORFAX"]);
                     fornecedorPorDesc.Cont = Convert.ToString(linha["FORCONT"]);
                     fornecedorPorDesc.ContDDD = Convert.ToInt32(linha["FORCONTDDD"]);
                     fornecedorPorDesc.ContFone = Convert.ToString(linha["FORCONTFONE"]);
                     fornecedorPorDesc.Cont2 = Convert.ToString(linha["FORCONT2"]);
                     fornecedorPorDesc.Cont2DDD = Convert.ToInt32(linha["FORCONT2DDD"]);
                     fornecedorPorDesc.Cont2Fone = Convert.ToString(linha["FORCONT2FONE"]);
                     fornecedorPorDesc.Cont3 = Convert.ToString(linha["FORCONT3"]);
                     fornecedorPorDesc.Cont3DDD = Convert.ToInt32(linha["FORCONT3DDD"]);
                     fornecedorPorDesc.Cont3Fone = Convert.ToString(linha["FORCONT3FONE"]);
                     fornecedorPorDesc.Email = Convert.ToString(linha["FOREMAIL"]);
                     fornecedorPorDesc.Fantasia = Convert.ToString(linha["FORFANTASIA"]);
                     fornecedorPorDesc.DataCad = Convert.ToString(linha["FORDATACAD"]);
                     fornecedorPorDesc.Ocorr = Convert.ToString(linha["FOROCORR"]);
                     fornecedorPorDesc.UltPed = Convert.ToString(linha["FORULTPED"]);
                     fornecedorPorDesc.Tipo = Convert.ToString(linha["FORTIPO"]);
                     fornecedorPorDesc.Cnae = Convert.ToString(linha["FORCNAE"]);
                     fornecedorPorDesc.CodMunicipio = Convert.ToInt32(linha["FORCODMUNICIPIO"]);*/

                    //E colocá-lo na Coleção
                    fornecedorColecao.Add(fornecedorPorDesc);
                }

                return fornecedorColecao;//retornar o objeto de tipo MaterialColeção
            }
            catch (Exception exception)
            {
                throw new Exception("Não foi possível consultar o Fornecedor por Código. Detalhes: " + exception);
            }
        }
    }
}
