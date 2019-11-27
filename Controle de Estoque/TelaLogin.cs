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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(this.Width / 2 - 114, this.Height / 2 - 240);
            label1.Location = new Point(this.Width / 2 - 231, pictureBox1.Location.Y - 80);
            txtUser.Location = new Point(this.Width / 2 - 143,pictureBox1.Location.Y + 230);
            label2.Location = new Point(txtUser.Location.X - 75, pictureBox1.Location.Y + 235);
            btnEntrar.Location = new Point(this.Width / 2 - 63,txtUser.Location.Y + 35);

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtUser.Text.ToString().Trim() == "" )
            {
                txtUser.Text = "";
                MessageBox.Show("Preencha o campo Usuário!", "Campo Vazio", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return;
            }
            ChamarLogin();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChamarLogin()
        {
            CadastroDeSaída cadastro_saida = new CadastroDeSaída();
            cadastro_saida.Show();
            this.Hide();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ChamarLogin();
            }
        }
    }
}
