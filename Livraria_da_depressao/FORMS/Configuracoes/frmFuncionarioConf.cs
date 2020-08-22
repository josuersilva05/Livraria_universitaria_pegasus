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
    public partial class frmFuncionarioConf : Form
    {
        public string codigo;
        public string cnome;
        public string csexo;
        public string cargo;
        public string opEditar;
        public frmFuncionarioConf()
        {
            InitializeComponent();
            cboSexoFunc.SelectedIndex = 0;
        }

        public frmFuncionarioConf(List<string> campos, string editar)
        {
            InitializeComponent();
            codigo = campos[0];
            cnome = campos[1];
            cargo = campos[2];
            csexo = campos[3];
            opEditar = editar;
        }

        private void frmFuncionarioConf_Load(object sender, EventArgs e)
        {
            if (opEditar == "editar")
            {
                txtNomeFunc.Text = cnome;
                txtCargoFunc.Text = cargo;
                for (int i = 0; i<3; i++)

                {
                    string charSexo = cboSexoFunc.Items[i].ToString().Substring(0, 1).ToLower();
                    if (csexo == charSexo)
                    {
                        cboSexoFunc.SelectedIndex = i;
                    }
                }
                btSalvarAlteracoesFuncionario.Visible = true;
                btCadastrarFuncionario.Visible = false;
            }
            else
            {
                btSalvarAlteracoesFuncionario.Visible = false;
                btCadastrarFuncionario.Visible = true;
            }
        }

        private void btCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                csexo = cboSexoFunc.Text.Substring(0, 1).ToLower();

                configuracoesDTO confdto = new configuracoesDTO();
                confdto.nomeFuncionarioConf = txtNomeFunc.Text;
                confdto.cargoFuncionarioConf = txtCargoFunc.Text;
                confdto.sexoFuncionarioConf = Convert.ToChar(csexo);

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.cadastrar_funcionario(confdto);
                if (result == true)
                {
                    MessageBox.Show("Registro inserido!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btSalvarAlteracoesFuncionario_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                csexo = cboSexoFunc.Text.Substring(0, 1).ToLower();

                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idfuncionario = codigo;
                confdto.nomeFuncionarioConf = txtNomeFunc.Text;
                confdto.cargoFuncionarioConf = txtCargoFunc.Text;
                confdto.sexoFuncionarioConf = Convert.ToChar(csexo);

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.editar_funcionario(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }

        private void btCancelarFuncionario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmFuncionarioConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes frm = new frmConfiguracoes("funcionario");
            frm.Show();
        }
    }
}
