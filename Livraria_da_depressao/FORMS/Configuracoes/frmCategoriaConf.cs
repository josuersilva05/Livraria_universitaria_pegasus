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
    public partial class frmCategoriaConf : Form
    {
        public frmCategoriaConf()
        {
            InitializeComponent();
        }

        public frmCategoriaConf(List<string> campos, string action)
        {
            InitializeComponent();
            if (action == "editar")
            {
                btEditarCategoria.Visible = true;
                btCadastrarCategoria.Visible = false;
            }
            txtCodigoCategoria.Text = campos[0];
            txtNomeCategoria.Text = campos[1];
        }

        private void btEditarCategoria_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idCategoriaConf = txtCodigoCategoria.Text;
                confdto.nomeCategoriaConf = txtNomeCategoria.Text;

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.editar_categoria(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btCadastrarCategoria_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.nomeCategoriaConf = txtNomeCategoria.Text;
                result = confbll.cadastrar_categoria(confdto);
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

        private void frmCategoriaConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes cf = new frmConfiguracoes("categoria");
            cf.Show();
        }
    }
}
