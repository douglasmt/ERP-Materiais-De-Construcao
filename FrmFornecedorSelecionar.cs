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
    public partial class FrmFornecedorSelecionar : Form
    {
        public FrmFornecedorSelecionar(string nome)
        {
            InitializeComponent();

            AtualizarGrid();

            //para não colocar as colunas com nomes errados
            dataGridViewFornecedores.AutoGenerateColumns = false;


        }

        private void buttonPesquisar_Click(object sender, EventArgs e)
        {
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            FornecedorNegocios FornecedorNegocios = new FornecedorNegocios();//para usar a classe de Negocios

            FornecedorColecao fornecedorColecao = FornecedorNegocios.ConsultarPorDesc(textBoxPesquisa.Text);

            dataGridViewFornecedores.DataSource = null; //para limpar
            dataGridViewFornecedores.DataSource = fornecedorColecao; //e colocar o MaterialColeção criado
            dataGridViewFornecedores.Update();
            dataGridViewFornecedores.Refresh();
        }

        private void buttonFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void buttonSelecionar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedorSelecionado = (dataGridViewFornecedores.SelectedRows[0].DataBoundItem as Fornecedor);
            string recebe;
            recebe = fornecedorSelecionado.Nome;
                        
            this.DialogResult = DialogResult.Yes;
        }


    }
}
