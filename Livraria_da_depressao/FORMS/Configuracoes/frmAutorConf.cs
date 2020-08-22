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

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class frmAutorConf : Form
    {
        public frmAutorConf()
        {
            InitializeComponent();
        }

        public frmAutorConf(List<string> campos, string action)
        {
            InitializeComponent();
            if (action == "editar")
            {
                btSalvar.Visible = true;
                btCadastrarAutor.Visible = false;
            }
            txtCodigoAutor.Text = campos[0];
            txtNomeAutor.Text = campos[1];
        }

        private void btCadastrarAutor_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.nomeAutorConf = txtNomeAutor.Text;
                result = confbll.cadastrar_autor(confdto);
                if (result == true)
                {
                    MessageBox.Show("Registro inserido!");
                }
                this.Close();
            }
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idAutorConf = txtCodigoAutor.Text;
                confdto.nomeAutorConf = txtNomeAutor.Text;

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.editar_autor(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btCancelarAutor_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAutorConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes cf = new frmConfiguracoes("autor");
            cf.Show();
        }
    }
}
