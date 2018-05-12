using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuadroMedalhas
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "admin")
            {
                if(txtSenha.Text == "123")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Senha incorreta.");
                }
            }
            else
            {
                MessageBox.Show("Usuário não encontrado.");
            }


        }

        
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
