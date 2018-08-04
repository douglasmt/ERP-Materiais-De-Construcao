using System;
using System.Linq;

using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmMaterialCadastrar : Form
    {
        AcaoNaTela acaoNatelaSelecionada;//para dentro dessa tela e receber o que veio pela acaoNaTela, global aqui

        public FrmMaterialCadastrar(AcaoNaTela acaoNaTela, Material material)//precisa passar acao no FrmMaterialSelecionar
        {
            InitializeComponent();//depois de montar a tela preciso saber a opção

            this.acaoNatelaSelecionada = acaoNaTela; //recebendo de fora

            dateTimePickerData.TabStop = false;
            dateTimePickerData.Enabled = false;

            if (acaoNaTela == AcaoNaTela.Inserir)//1 acaoNaTela.Equals(AcaoNaTela.Inserir) é possível//Excluir não precisa
            {
                textBoxFornecedor.ReadOnly = true;
                textBoxFornecedor.TabStop = false;

                this.Text = "Inserir material";

            }
            else if (acaoNaTela == AcaoNaTela.Alterar)//2
            {
                this.Text = "Alterar Material";//Título da tela
                textBoxCod.Text = material.CadCod.ToString(); // preenchendo campos
                textBoxDesc.Text = material.CadDesc;
                comboBoxUnid.Text = material.Unid;
                textBoxValor.Text = material.Valor.ToString();
                textBoxQuant.Text = material.Quant.ToString();
                dateTimePickerData.Text = material.MatData.ToShortDateString();
                textBoxFornecedorCod.Text = material.FornecedorCod.ToString();
                textBoxFornecedor.Text = material.FornecedorDesc;
                textBoxFornecedor.ReadOnly = true;
                textBoxFornecedor.TabStop = false;
                textBoxFase.Text = material.Fase.ToString();
            }
            else if (acaoNaTela == AcaoNaTela.Consultar)//3
            {
                this.Text = "Consultar material";

                //carregar campos desabilitados
                textBoxCod.Text = material.CadCod.ToString(); // preenchendo campos
                textBoxDesc.Text = material.CadDesc;
                comboBoxUnid.Text = material.Unid;
                textBoxValor.Text = material.Valor.ToString();
                textBoxQuant.Text = material.Quant.ToString();
                dateTimePickerData.Text = material.MatData.ToShortDateString();
                textBoxFornecedorCod.Text = material.FornecedorCod.ToString();
                textBoxFornecedor.Text = material.FornecedorDesc;
                textBoxFase.Text = material.Fase.ToString();

                textBoxDesc.ReadOnly = true;
                textBoxDesc.TabStop = false;
                comboBoxUnid.TabStop = false;
                comboBoxUnid.Enabled = false;
                //textBoxUnid.ReadOnly = true;
                //textBoxUnid.TabStop = false;
                textBoxValor.ReadOnly = true;
                textBoxValor.TabStop = false;
                textBoxQuant.ReadOnly = true;
                textBoxQuant.TabStop = false;
                
                textBoxFornecedorCod.ReadOnly = true;
                textBoxFornecedorCod.TabStop = false;

                textBoxFornecedor.ReadOnly = true;
                textBoxFornecedor.TabStop = false;

                textBoxFase.ReadOnly = true;
                textBoxFase.TabStop = false;

                buttonSalvar.Visible = false;
                buttonCancelar.Text = "Fechar";
                buttonCancelar.Focus();//cursor no botão somente 

            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
            //DialogResult = DialogResult.No;
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            //vai mandar os dados para o Objeto transferência, e negócios, pela acao acaoNatelaSelecionada(acaoNatela)
            
            if (textBoxDesc.Text == "")
            {
                MessageBox.Show("Descrição vazia");
                return;
            }

            if (acaoNatelaSelecionada == AcaoNaTela.Inserir)//Botão salvar irá incluir
            {
                Material materialInsere = new Material();
                materialInsere.CadDesc = textBoxDesc.Text;
                materialInsere.Unid = comboBoxUnid.Text;

                materialInsere.FornecedorCod = Convert.ToInt32(textBoxFornecedorCod.Text);
                materialInsere.Fase = Convert.ToInt32( textBoxFase.Text );

                try
                {
                    if (textBoxValor.Text == "")
                    {
                        materialInsere.Valor = 0;
                    }
                    else
                    {
                        materialInsere.Valor = Convert.ToDecimal(textBoxValor.Text);
                    }

                    if (textBoxQuant.Text == "")
                    {
                        materialInsere.Quant = 0;
                    }
                    else
                    {
                        materialInsere.Quant = Convert.ToDecimal(textBoxQuant.Text);
                    }

                    MaterialNegocios materialNegocios = new MaterialNegocios();
                    string retorno = materialNegocios.Inserir(materialInsere);

                    //tenta converter pra inteiro, pois neste caso deu certo
                    try
                    {
                        int idMaterial = Convert.ToInt32(retorno);

                        MessageBox.Show("Material inserido com sucesso! Código: " + idMaterial);

                        this.DialogResult = DialogResult.Yes;//essa linha fecha a tela como o Close, com resultado Yes(ok)
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível inserir! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;//essa linha fecha a tela como o Close, com resultado No(errado)

                    }
                }
                catch
                {
                    MessageBox.Show("Dados inválidos! Detalhes: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (acaoNatelaSelecionada == AcaoNaTela.Alterar)
            {
                Material materialAltera = new Material();

                materialAltera.CadCod = Convert.ToInt32(textBoxCod.Text);

                materialAltera.CadDesc = textBoxDesc.Text;
                materialAltera.Unid = comboBoxUnid.Text;

                materialAltera.FornecedorCod = Convert.ToInt32(textBoxFornecedorCod.Text);

                materialAltera.Fase = Convert.ToInt32(textBoxFase.Text);
                
                try
                {
                    if (textBoxValor.Text == "")
                    {
                        materialAltera.Valor = 0;
                    }
                    else
                    {
                        materialAltera.Valor = Convert.ToDecimal(textBoxValor.Text);
                    }

                    if (textBoxQuant.Text == "")
                    {
                        materialAltera.Quant = 0;
                    }
                    else
                    {
                        materialAltera.Quant = Convert.ToDecimal(textBoxQuant.Text);
                    }

                    MaterialNegocios materialNegocios = new MaterialNegocios();
                    string retorno = materialNegocios.Alterar(materialAltera);

                    //tenta converter pra inteiro, pois neste caso deu certo
                    try
                    {
                        int idMaterial = Convert.ToInt32(retorno);

                        MessageBox.Show("Material Alterado com sucesso! Código: " + idMaterial);

                        this.DialogResult = DialogResult.Yes;//essa linha fecha a tela como o Close, com resultado Yes(ok)
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível alterar! Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;//essa linha fecha a tela como o Close, com resultado No(errado)
                    }
                }
                catch
                {
                    MessageBox.Show("Dados inválidos! Detalhes: ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void textBoxValor_KeyPress(object sender, KeyPressEventArgs e)
        {//keypress não deixa informar ponto e nem letras
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!textBoxValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }



        /*private void textBoxQuant_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!textBoxValor.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }*/

        private void textBoxValor_Validated(object sender, EventArgs e)
        {//no validated formata
            Decimal valor;

            // verificar se espaço ou vazio
            if ((textBoxValor.Text != "") && (textBoxValor.Text != " "))
            {
                try
                {
                    valor = Convert.ToDecimal(textBoxValor.Text);
                    textBoxValor.Text = string.Format("{0:N2}", valor);
                }
                catch
                {
                    MessageBox.Show("Favor digitar somente números!");
                    textBoxValor.Text = "0,00";
                    textBoxValor.Focus();
                }
            }
        }

        private void textBoxQuant_Validated(object sender, EventArgs e)
        {
            Decimal valor;
            // verificar se espaço ou vazio
            if ((textBoxQuant.Text != "") && (textBoxQuant.Text != " "))
            {
                try
                {
                    valor = Convert.ToDecimal(textBoxQuant.Text);
                    textBoxQuant.Text = string.Format("{0:N3}", valor);
                }
                catch
                {
                    MessageBox.Show("Favor digitar somente números!");
                    textBoxQuant.Text = "0,000";
                    textBoxQuant.Focus();
                }
            }

        }

        private void textBoxDesc_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxUnid_Validated(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBuscaFornecedor_Click(object sender, EventArgs e)
        {
            /*string nome = "";
            //Chamar instancia o Form de Fornecedores(cria-se um objeto dele para chama-lo)
            FrmFornecedorSelecionar frmFornecedor = new FrmFornecedorSelecionar(nome);

            //DialogResult dialogResult = 
                frmFornecedor.Show();//Dialog para travar essa janela para não mexer nas outras

            textBoxFornecedor.Text = nome;*/

        }

        private void textBoxFase_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
