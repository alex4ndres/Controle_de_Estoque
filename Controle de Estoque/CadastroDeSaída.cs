using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class CadastroDeSaída : Form
    {
        public CadastroDeSaída()
        {
            InitializeComponent();
        }

        private void CadastroDeSaída_Load(object sender, EventArgs e)
        {
            pbMaterial.Image = Properties.Resources.packing_no_material;
            btnSalvar.Location = new Point(this.Width / 2 - 72, btnSalvar.Location.Y);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
            
        }

        private void txtMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (txtMaterial.Text.ToString().Trim() == "")
                {
                    MessageBox.Show("Preencha o campo item!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtQuantidade.Focus();
                }
            }
        }

        private void Salvar()
        {
            if (txtMaterial.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo item!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaterial.Focus();
            }
            else if (txtQuantidade.Text.ToString().Trim() == "")
            {
                MessageBox.Show("Preencha o campo quantidade!", "Campo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantidade.Focus();
            }
            
            if (txtMaterial.Text.ToString().Trim() != "" && txtQuantidade.Text.ToString().Trim() != "")
            {
                var answer = MessageBox.Show("Deseja realmente salvar?", "Alerta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes)
                {
                    // Here we have the SAVE code
                    MessageBox.Show("Dados salvos com sucesso!", "Dados Salvos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
               
            
        }
        //Verifica se o caracter digitado é um numero
        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void txtQuantidade_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Salvar();
            }
        }
    }
}
