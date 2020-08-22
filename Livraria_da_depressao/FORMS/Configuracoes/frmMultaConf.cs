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
    public partial class frmMultaConf : Form
    {
        public frmMultaConf()
        {
            InitializeComponent();
        }

        public frmMultaConf(List<string> campos, string action)
        {
            InitializeComponent();
            if (action == "editar")
            {
                btEditarMulta.Visible = true;
                btCadastrarMulta.Visible = false;
            }
            txtCodigoMulta.Text = campos[0];
            txtNomeTipoMulta.Text = campos[1];
            txtValorMulta.Text = campos[2];
        }

        private void btCadastrarMulta_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.nomeMultaConf = txtNomeTipoMulta.Text;
                confdto.valorMultaConf = Convert.ToDouble(txtValorMulta.Text);
                result = confbll.cadastrar_multa(confdto);
                if (result == true)
                {
                    MessageBox.Show("Registro inserido!");
                }
                this.Close();
            }

        }

        private void btEditarMulta_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idMultaConf = txtCodigoMulta.Text;
                confdto.nomeMultaConf = txtNomeTipoMulta.Text;
                confdto.valorMultaConf = Convert.ToDouble(txtValorMulta.Text);

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.editar_multa(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMultaConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes cf = new frmConfiguracoes("multa");
            cf.Show();
        }
    }
}
