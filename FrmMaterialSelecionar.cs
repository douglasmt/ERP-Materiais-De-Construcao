using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocios;
using ObjetoTransferencia;

namespace Apresentacao
{
    public partial class FrmMaterialSelecionar : Form
    {
        public FrmMaterialSelecionar()//para chamar, isntanciar uma classe no principal
        {
            InitializeComponent();

            AtualizarGrid();

            //para não colocar as colunas com nomes errados
            dataGridViewPrincipal.AutoGenerateColumns = false;

        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            MaterialNegocios materialNegocios = new MaterialNegocios();//para usar a classe de Negocios

            MaterialColecao materialColecao = materialNegocios.ConsultarPorDesc(textBoxPesquisa.Text);

            dataGridViewPrincipal.DataSource = null; //para limpar
            dataGridViewPrincipal.DataSource = materialColecao; //e colocar o MaterialColeção criado
            dataGridViewPrincipal.Update();
            dataGridViewPrincipal.Refresh();
        }


        private void buttonFechar_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            //verificar linha selecionada, como a propriedade MultiSelect do grid é False
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado");
                return;//o programa pára mesmo com o IF abaixo
            }

            DialogResult resultado = MessageBox.Show(
                    "Tem certeza?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.No)
            {
                return;
            }

            //se as opções não precisarem dar return, quer dizer que pode começar a seleção do registro de exclusão
            Material materialSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Material);
            //o selectedRows [0] pega a linha selecionada que fica em DataBoundItem

            MaterialNegocios materialNegocios = new MaterialNegocios();//passa o objeto pelo DEL_COD
            string retorno = materialNegocios.Excluir(materialSelecionado);// e deleta pegando o Código de volta

            try
            {
                int codMaterial = Convert.ToInt32(retorno);

                MessageBox.Show("Material excluído com sucesso.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                AtualizarGrid();
            }
            catch 
            {
                MessageBox.Show("Não foi possível Excluir. Detalhes: " + retorno, " Atenção ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            //verificar linha selecionada, como a propriedade MultiSelect do grid é False
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum cliente selecionado");
                return;
            }

            //se as opções não precisarem dar return, quer dizer que pode começar a seleção do registro de exclusão
            Material materialSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Material);
            //o selectedRows [0] pega a linha selecionada que fica em DataBoundItem

            //Chamar instancia o Form Cliente Cadastrar(cria-se um objeto dele para chama-lo)
            FrmMaterialCadastrar frmMaterialCadastrar = new FrmMaterialCadastrar(AcaoNaTela.Alterar, materialSelecionado);//para o Cadastrar
            
            DialogResult dialogResult = frmMaterialCadastrar.ShowDialog();//Dialog para travar essa janela para não mexer nas outras

            if (dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {

            FrmMaterialCadastrar frmMaterialCadastrar = new FrmMaterialCadastrar(AcaoNaTela.Inserir, null);//null pois é novo
            
            DialogResult dialogResult = frmMaterialCadastrar.ShowDialog();

            if(dialogResult == DialogResult.Yes)
            {
                AtualizarGrid();
            }

        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            //verificar linha selecionada, como a propriedade MultiSelect do grid é False
            if (dataGridViewPrincipal.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum material selecionado");
                return;
            }

            //se as opções não precisarem dar return, quer dizer que pode começar a seleção do registro de exclusão
            Material materialSelecionado = (dataGridViewPrincipal.SelectedRows[0].DataBoundItem as Material);
            //o selectedRows [0] pega a linha selecionada que fica em DataBoundItem

            FrmMaterialCadastrar frmMaterialCadastrar = new FrmMaterialCadastrar(AcaoNaTela.Consultar, materialSelecionado);
            
            frmMaterialCadastrar.ShowDialog();
        }

        private void buttonTotais_Click(object sender, EventArgs e)
        {
            FrmTotais frmTotais = new FrmTotais();
            frmTotais.ShowDialog();
        }

        private void dataGridViewPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
