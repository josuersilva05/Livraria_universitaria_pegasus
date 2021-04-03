using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.DTO;
using MySql.Data.MySqlClient;
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
    public partial class frmLivroConf : Form
    {
        public List<string> vCampos;
        public string action = "";
        public frmLivroConf()
        {
            InitializeComponent();
        }
        public frmLivroConf(List<string> campos, string editar)
        {
            InitializeComponent();
            action = editar;
            vCampos = campos;
        }

        private void frmLivroConf_Load(object sender, EventArgs e)
        {
            if (action == "editar")
            {
                btEditarLivro.Visible = true;
                btCadastrarLivro.Visible = false;
                txtNomeLivro.Text = vCampos[1];
                cboAutor.Items.Add(vCampos[2]);
                cboCategoria.Items.Add(vCampos[3]);
                cboEditora.Items.Add(vCampos[4]);
                txtIsbn.Text = vCampos[5];
                txtQuantidade.Text = vCampos[6];
                txtValorLivro.Text = vCampos[7];
                cboCodigoCategoria.Items.Add(vCampos[8]);
                cboCodigoAutor.Items.Add(vCampos[9]);
                cboCodigoEditora.Items.Add(vCampos[10]);
            }
            else
            {
                btEditarLivro.Visible = false;
                btCadastrarLivro.Visible = true;
            }
            
            carregar_autores();
            carregar_editoras();
            carregar_categorias();

            cboAutor.SelectedIndex = 0;
            cboCodigoAutor.SelectedIndex = 0;
            cboEditora.SelectedIndex = 0;
            cboCodigoEditora.SelectedIndex = 0;
            cboCategoria.SelectedIndex = 0;
            cboCodigoCategoria.SelectedIndex = 0;
        }

        private void btCadastrarLivro_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo inserir este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idCategoriaConf = cboCodigoCategoria.Text;
                confdto.idAutorConf = cboCodigoAutor.Text;
                confdto.idEditoraConf = cboCodigoEditora.Text;
                confdto.qtdLivroConf = txtQuantidade.Text;
                confdto.nomeLivroConf = txtNomeLivro.Text;
                confdto.isbnLivroConf = txtIsbn.Text;
                confdto.valorLivro = txtValorLivro.Text;
                result = confbll.cadastrar_livro(confdto);
                if (result == true)
                {
                    MessageBox.Show("Registro inserido!");
                }
                this.Close();
            }
        }

        private void btEditarLivro_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar este registro?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                configuracoesBLL confbll = new configuracoesBLL();
                configuracoesDTO confdto = new configuracoesDTO();
                confdto.idLivroConf = vCampos[0];
                confdto.idCategoriaConf = cboCodigoCategoria.Text;
                confdto.idAutorConf = cboCodigoAutor.Text;
                confdto.idEditoraConf = cboCodigoEditora.Text;
                confdto.qtdLivroConf = txtQuantidade.Text;
                confdto.nomeLivroConf = txtNomeLivro.Text;
                confdto.isbnLivroConf = txtIsbn.Text;
                confdto.valorLivro = txtValorLivro.Text.Replace(",",".");
                result = confbll.editar_livro(confdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!");
                }
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void carregar_autores()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_autores";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cboAutor.Items.Add(row[1]);
                cboCodigoAutor.Items.Add(row[0]);
            }
        }

        private void carregar_editoras()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_editoras";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cboEditora.Items.Add(row[1]);
                cboCodigoEditora.Items.Add(row[0]);
            }
        }

        private void carregar_categorias()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_categorias";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                cboCategoria.Items.Add(row[1]);
                cboCodigoCategoria.Items.Add(row[0]);
            }
        }

        private void frmLivroConf_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmConfiguracoes fc = new frmConfiguracoes("livro");
            fc.Show();
        }

        private void cboAutor_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboAutor.SelectedIndex;
            cboCodigoAutor.SelectedIndex = ind;
        }

        private void cboEditora_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboEditora.SelectedIndex;
            cboCodigoEditora.SelectedIndex = ind;
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = cboCategoria.SelectedIndex;
            cboCodigoCategoria.SelectedIndex = ind;
        }
    }
}
