using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class ucGerLivros : UserControl
    {
        public ucGerLivros()
        {
            InitializeComponent();
        }

        private void ucGerLivros_Load(object sender, EventArgs e)
        {
            carregar_livros();
        }

        private void btNovoLivro_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmLivroConf lc = new frmLivroConf();
            lc.Show();
        }

        private void btEditarLivro_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow.Cells[0].Value != null) {
                List<string> campos = new List<string>();
                for (int i = 0; i < dgvLivros.Columns.Count; i++)
                {
                    if (dgvLivros.CurrentRow.Cells[i].Value.ToString() != null)
                    {
                        campos.Add(dgvLivros.CurrentRow.Cells[i].Value.ToString());
                    }
                }
                if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
                DataTable dt = new DataTable();
                try
                {
                    Conexao.con.Open();
                    MySqlCommand cmd = Conexao.con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "call pesquisa_editar_livro(@id)";
                    cmd.Parameters.AddWithValue("@id", dgvLivros.CurrentRow.Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    Conexao.con.Close();
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível trazer o registro: " + ex.Message);
                    Conexao.con.Close();
                }

                foreach (DataRow row in dt.Rows)
                {
                    campos.Add(row[0].ToString());
                    campos.Add(row[1].ToString());
                    campos.Add(row[2].ToString());
                }

                ((Form)this.TopLevelControl).Hide();
                frmLivroConf lc = new frmLivroConf(campos, "editar");
                lc.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para editar.");
            }
        }

        private void btExcluirLivro_Click(object sender, EventArgs e)
        {
            if (dgvLivros.CurrentRow.Cells[0].Value != null) {
                DialogResult resp = MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    bool status = false;
                    configuracoesBLL confbll = new configuracoesBLL();
                    configuracoesDTO confdto = new configuracoesDTO();
                    confdto.idLivroConf = dgvLivros.CurrentRow.Cells[0].Value.ToString();
                    status = confbll.excluir_livro(confdto);
                    if (status == true)
                    {
                        MessageBox.Show("Registro excluido com sucesso!");
                        dgvLivros.Rows.Clear();
                        carregar_livros();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um registro para excluir.");
            }
        }

        private void carregar_livros()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_livros";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                dgvLivros.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }
        }


        private void pesquisa_editar_livro(configuracoesDTO conf)
        {
            
        }
    }
}
