using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;
using Livraria_da_depressao.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        LoginDTO logdto = new LoginDTO();
        LoginBLL usubll = new LoginBLL();
        private void btEntrar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "" && txtSenha.Text != "")
            {
                logdto.nomeUsuario = txtUsuario.Text;
                logdto.senha = txtSenha.Text;
                if (usubll.verifica_login(logdto) == true)
                {
                    frmMenuInicial fmenu = new frmMenuInicial();
                    this.Hide();
                    fmenu.Show();

                }
                else
                {
                    MessageBox.Show("Usuario ou senha incorretos.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, informe o usuário e a senha.");
            }
            
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

    }
}
