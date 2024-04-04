using CursoWindowsFormsBiblioteca;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            bool situacaoLogin = login.VerificarLogin(txtNome.Text, txtSenha.Text);
            if(situacaoLogin == true)
            {
                FrmPrincipal frm = new FrmPrincipal();
                frm.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Nome ou senha incorreta!");
            }
        }

        private void txtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btEntrar.Focus();
            }
        }
    }
}
