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
    public partial class frmEditoraConf : Form
    {
        public frmEditoraConf()
        {
            InitializeComponent();
        }

        public frmEditoraConf(List<string> campos, string action)
        {
            InitializeComponent();
            if (action == "editar")
            {
                btEditarEditora.Visible = true;
                btCadastrarEditora.Visible = false;
            }
            txtCodigoEditora.Text = campos[0];
            txtNomeEditora.Text = campos[1];
        }

        private void btEditarEditora_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idEditoraConf = txtCodigoEditora.Text;
                confdto.nomeEditoraConf = txtNomeEditora.Text;

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.editar_editora(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btCadastrarEditora_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.nomeEditoraConf = txtNomeEditora.Text;
                result = confbll.cadastrar_editora(confdto);
                if (result == true)
                {
                    MessageBox.Show("Registro inserido!");
                }
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditoraConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes cf = new frmConfiguracoes("editora");
            cf.Show();
        }
    }
}
