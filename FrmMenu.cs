using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()// notar que não revolve mas não obriga a devolver
        {
            InitializeComponent();//linha das coisas que arrastar pra tela, o que constrói a tela com tudo
        }

        private void menuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuMaterial_Click(object sender, EventArgs e)
        {
            FrmMaterialSelecionar frmMaterialSelecionar = new FrmMaterialSelecionar();
            //Instanciando a abertura do Menu que mostra os materiais, pelo construtor '()'
            frmMaterialSelecionar.MdiParent = this/*FrmMenu*/;//está dentro do menu
            frmMaterialSelecionar.Show(); 
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFornecedorSelecionar frmFornecedor = new FrmFornecedorSelecionar("");
            //Instanciando a abertura do Menu que mostra os fornecedores, pelo construtor '()'
            frmFornecedor.MdiParent = this/*FrmMenu*/;//está dentro do menu
            frmFornecedor.Show();
        }
    }
}
