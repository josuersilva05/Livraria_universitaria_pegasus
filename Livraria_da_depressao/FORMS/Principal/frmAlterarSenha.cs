using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class frmAlterarSenha : Form
    {
        public frmAlterarSenha()
        {
            InitializeComponent();
        }

        private void btAlterarSenha_Click(object sender, EventArgs e)
        {
            if (txtNovaSenha.Text == txtConfirmarSenha.Text)
            {
                bool result;
                lblErroSenha.Visible = false;
                usuarioSessaoDTO sdto = new usuarioSessaoDTO();
                sdto.novaSenha = txtConfirmarSenha.Text;
                LoginBLL lbll = new LoginBLL();
                result = lbll.alterar_senha(sdto);
                if (result == true)
                {
                    MessageBox.Show("Senha alterada com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Não foi possível alterar a senha.");
                }
            }
            else
            {
                lblErroSenha.Text = "Senhas não correspondem.";
                lblErroSenha.Visible = true;
            }
        }

        private void frmAlterarSenha_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial mi = new frmMenuInicial("perfil");
            mi.Show();
        }
    }
}
