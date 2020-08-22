using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.DTO;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class frmUsuarioConf : Form
    {
        public int codigoFunc = 0;
        public string action = ""; 
        public string cid;
        public string cnome;
        public string cusuario;
        public string ccargo;
        public string cpermissao;
        public frmUsuarioConf()
        {
            InitializeComponent();
        }

        public frmUsuarioConf(List<string> campos, string editar)
        {
            InitializeComponent();
            action = editar;
            cboFuncionario.Text = campos[1];
            txtNovoUsuario.Text = campos[2];
            cboCodigoFuncionario.Text = campos[0];
            cboNovaPermissao.Text = campos[4];

        }

        private void frmUsuarioConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes frm = new frmConfiguracoes("usuario");
            frm.Show();
        }

        private void btCadastrarUsuario_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idUsuarioConf = cboCodigoFuncionario.Text;
                confdto.nomeUsuarioConf = txtNovoUsuario.Text;
                confdto.senhaUsuarioConf = txtNovaSenha.Text;
                confdto.permissaoUsuarioConf = cboNovaPermissao.Text;
                result = confbll.cadastrar_usuario(confdto);
                if (result == true)
                {
                    MessageBox.Show("Registro inserido!");
                }
                this.Close();
            }
        }

        private void btCancelarUsuario_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUsuarioConf_Load(object sender, EventArgs e)
        {
            if (action == "editar")
            {
                txtNovaSenha.Visible = false;
                btEditarUsuario.Visible = true;
                btCadastrarUsuario.Visible = false;
            }
            else
            {
                txtNovaSenha.Visible = true;
                btEditarUsuario.Visible = false;
                btCadastrarUsuario.Visible = true;
            }
            carregar_funcionarios();
        }

        private void carregar_funcionarios()
        {
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_funcionarios";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cboFuncionario.Items.Add(row[1]);
                cboCodigoFuncionario.Items.Add(row[0]);
            }
        }

        private void cboFuncionario_TextChanged(object sender, EventArgs e)
        {
            if(action != "editar")
            {
                cboCodigoFuncionario.Text = Convert.ToString(cboCodigoFuncionario.Items[cboFuncionario.SelectedIndex]);
            }
        }

        private void btEditarUsuario_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idUsuarioConf = cboCodigoFuncionario.Text;
                confdto.nomeUsuarioConf = txtNovoUsuario.Text;
                confdto.permissaoUsuarioConf = cboNovaPermissao.Text;

                configuracoesBLL confbll = new configuracoesBLL();
                result = confbll.editar_usuario(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }
    }
}
