using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ObjetoTransferencia;
using Negocios;

namespace Apresentacao
{
    public partial class FrmTotais : Form
    {
        public FrmTotais()
        {
            InitializeComponent();

            checadorRadio();
            
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            MaterialTotal materialTotal = new MaterialTotal();

            if (radioButtonFornecedor.Checked)
            {
                if (textBoxFornecedor.Text == "")
                {
                    MessageBox.Show("Sem dados para pesquisa!");
                    return;
                }

                materialTotal.Fornecedor =  textBoxFornecedor.Text;
                MaterialNegocios materialNegocios = new MaterialNegocios();
                materialNegocios.TotaisPorForn(materialTotal);                
            }
            else
            {
                if (textBoxFase.Text == " " || textBoxFase.Text == "")
                {
                    MessageBox.Show("Sem dados para pesquisa!");
                    return;
                } else {
                    try {
                        Convert.ToInt32(textBoxFase.Text);
                    } catch
                    {
                        MessageBox.Show("Não é númerico!");
                        return;
                    }
                }

                materialTotal.Fase = Convert.ToInt32(textBoxFase.Text);///ver aqui
                MaterialNegocios materialNegocios = new MaterialNegocios();
                materialNegocios.TotaisPorFase(materialTotal);                
            }
                                    
            textBoxTotal.Text = String.Format("{0:N2}", materialTotal.Total);
        }

        private void FrmTotais_Load(object sender, EventArgs e)
        {

        }

        private void radioButtonFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            checadorRadio();
        }

        private void radioButtonFase_CheckedChanged(object sender, EventArgs e)
        {
            checadorRadio();
        }

        private void checadorRadio()
        {
            if (radioButtonFornecedor.Checked)
            {
                textBoxFase.ReadOnly = true;
                textBoxFornecedor.ReadOnly = false;
            }
            else
            {
                textBoxFornecedor.ReadOnly = true;
                textBoxFase.ReadOnly = false;
            }
        }
    }
}
