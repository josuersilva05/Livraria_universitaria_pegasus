using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class ucConfirmacaoTrocaSenha : UserControl
    {
        public ucConfirmacaoTrocaSenha()
        {
            InitializeComponent();
        }

        private void btVerificaSenha_Click(object sender, EventArgs e)
        {
            if(txtVerificaSenha.Text != "")
            {
                bool result;
                usuarioSessaoDTO sdto = new usuarioSessaoDTO();
                sdto.novaSenha = txtVerificaSenha.Text;
                LoginBLL lbll = new LoginBLL();
                result = lbll.verifica_senha(sdto);
                if (result == true)
                {
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Senhas não correspondem.");
                }
            }
            else
            {
                MessageBox.Show("Por favor informe a senha atual.");
            }
        }
    }
}
