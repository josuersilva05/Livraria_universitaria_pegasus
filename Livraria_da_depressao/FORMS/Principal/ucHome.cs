using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Livraria_da_depressao.CODE.DAL;
using System.Threading;
using MySqlX.XDevAPI.Relational;
using Livraria_da_depressao.FORMS.Principal;
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;
using System.Diagnostics;

namespace Livraria_da_depressao.FORMS
{
    public partial class ucHome : UserControl
    {
        public DataTable dt_pub = new DataTable();
        public int lim = 2;
        public ucHome()
        {
            InitializeComponent();
            cboParmPesquisa.SelectedIndex = 1;
            carregar_emprestimos_hoje();
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            panResultadosPesquisa.Visible = true;
            panEntregas.Visible = false;
            efetuarPesquisa();
        }

        private void efetuarPesquisa()
        {
            if (cboParmPesquisa.Text == "LIVROS")
            {
                dgvResultadosPesquisa.Columns[2].Visible = false;
                dgvResultadosPesquisa.Columns[3].Visible = false;
                dgvResultadosPesquisa.Columns[4].Visible = false;
                dgvResultadosPesquisa.Columns[5].Visible = true;

                dt_pub = pesquisar_livro();

                txtPesquisaLivro.SelectionStart = txtPesquisaLivro.Text.Length;
                dgvResultadosPesquisa.Rows.Clear();
                foreach (DataRow row in dt_pub.Rows)
                {
                    string qtd = pesquisar_disponibilidade_livro(row[0].ToString());
                    dgvResultadosPesquisa.Rows.Add(row[0], row[1], null, null, null, qtd);
                }

            }
            else if (cboParmPesquisa.Text == "AUTORES")
            {
                dgvResultadosPesquisa.Columns[2].Visible = true;
                dgvResultadosPesquisa.Columns[3].Visible = false;
                dgvResultadosPesquisa.Columns[4].Visible = false;
                dgvResultadosPesquisa.Columns[5].Visible = true;

                dt_pub = pesquisar_autor();

                txtPesquisaLivro.SelectionStart = txtPesquisaLivro.Text.Length;
                dgvResultadosPesquisa.Rows.Clear();
                foreach (DataRow row in dt_pub.Rows)
                {
                    string qtd = pesquisar_disponibilidade_livro(row[0].ToString());
                    dgvResultadosPesquisa.Rows.Add(row[0], row[2], row[1], null, null, qtd);
                }
            }
            else if (cboParmPesquisa.Text == "CATEGORIA")
            {
                dgvResultadosPesquisa.Columns[2].Visible = false;
                dgvResultadosPesquisa.Columns[3].Visible = true;
                dgvResultadosPesquisa.Columns[4].Visible = false;
                dgvResultadosPesquisa.Columns[5].Visible = true;

                dt_pub = pesquisar_categoria();

                txtPesquisaLivro.SelectionStart = txtPesquisaLivro.Text.Length;
                dgvResultadosPesquisa.Rows.Clear();
                foreach (DataRow row in dt_pub.Rows)
                {
                    string qtd = pesquisar_disponibilidade_livro(row[0].ToString());
                    dgvResultadosPesquisa.Rows.Add(row[0], row[2], null, row[1], null, qtd);
                }
            }
            else if (cboParmPesquisa.Text == "EDITORA")
            {
                dgvResultadosPesquisa.Columns[2].Visible = false;
                dgvResultadosPesquisa.Columns[3].Visible = false;
                dgvResultadosPesquisa.Columns[4].Visible = true;
                dgvResultadosPesquisa.Columns[5].Visible = true;

                dt_pub = pesquisar_editora();

                txtPesquisaLivro.SelectionStart = txtPesquisaLivro.Text.Length;
                dgvResultadosPesquisa.Rows.Clear();
                foreach (DataRow row in dt_pub.Rows)
                {
                    string qtd = pesquisar_disponibilidade_livro(row[0].ToString());
                    dgvResultadosPesquisa.Rows.Add(row[0], row[2], null, null, row[1], qtd);
                }
            }
            else if (cboParmPesquisa.Text == "ID")
            {
                if (cboParmPesquisa.Text == "ID" && System.Text.RegularExpressions.Regex.IsMatch(txtPesquisaLivro.Text, "[^0-9]"))
                {
                    lblErroPesquisa.Text = "Por favor, ao pesquisar por ID insira apenas números.";
                    txtPesquisaLivro.Text.Remove(txtPesquisaLivro.Text.Length - 1);
                }
                else
                {
                    lblErroPesquisa.Text = "";
                    dgvResultadosPesquisa.Columns[2].Visible = false;
                    dgvResultadosPesquisa.Columns[3].Visible = false;
                    dgvResultadosPesquisa.Columns[4].Visible = false;
                    dgvResultadosPesquisa.Columns[5].Visible = true;

                    dt_pub = pesquisar_livro_id();

                    txtPesquisaLivro.SelectionStart = txtPesquisaLivro.Text.Length;
                    dgvResultadosPesquisa.Rows.Clear();
                    foreach (DataRow row in dt_pub.Rows)
                    {
                        string qtd = pesquisar_disponibilidade_livro(row[0].ToString());
                        dgvResultadosPesquisa.Rows.Add(row[0], row[1], null, null, null, qtd);
                    }
                }
            }
        }

        private DataTable pesquisar_livro()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            DataTable dt = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_livros(@texto, @limite)";
                cmd.Parameters.AddWithValue("@texto", txtPesquisaLivro.Text);
                cmd.Parameters.AddWithValue("@limite", lim);
                cmd.ExecuteReader();
                Conexao.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa. " + e.Message);
            }
            return dt;
        }

        private DataTable pesquisar_autor()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            DataTable dt = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_autor(@texto, @limite)";
                cmd.Parameters.AddWithValue("@texto", txtPesquisaLivro.Text);
                cmd.Parameters.AddWithValue("@limite", lim);
                cmd.ExecuteReader();
                Conexao.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa. " + e.Message);
            }
            return dt;
        }

        private DataTable pesquisar_categoria()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            DataTable dt = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_categoria(@texto, @limite)";
                cmd.Parameters.AddWithValue("@texto", txtPesquisaLivro.Text);
                cmd.Parameters.AddWithValue("@limite", lim);
                cmd.ExecuteReader();
                Conexao.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa. " + e.Message);
            }
            return dt;
        }

        private DataTable pesquisar_editora()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            DataTable dt = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_editora(@texto, @limite)";
                cmd.Parameters.AddWithValue("@texto", txtPesquisaLivro.Text);
                cmd.Parameters.AddWithValue("@limite", lim);
                cmd.ExecuteReader();
                Conexao.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa. " + e.Message);
            }
            return dt;
        }

        private DataTable pesquisar_livro_id()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            DataTable dt = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_livros_id(@id, @limite)";
                cmd.Parameters.AddWithValue("@id", txtPesquisaLivro.Text);
                cmd.Parameters.AddWithValue("@limite", lim);
                cmd.ExecuteReader();
                Conexao.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa. " + ex.Message);
            }
            return dt;
        }

        private string pesquisar_disponibilidade_livro(string idLivro)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            DataTable dt = new DataTable();
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_disponibilidade_livro(@id)";
                cmd.Parameters.AddWithValue("@id", idLivro);
                cmd.ExecuteReader();
                Conexao.con.Close();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                string id = "";
                foreach (DataRow row in dt.Rows)
                {
                    id = row[0].ToString();
                }
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a pesquisa. " + ex.Message);
                return "";
            }
        }

        private void btCarregarMais_Click(object sender, EventArgs e)
        {
            lim += 10;
            KeyEventArgs args = new KeyEventArgs(Keys.Enter);
            txtPesquisaLivro_KeyUp(sender, args);
            /*KeyPressEventArgs args = new KeyPressEventArgs(Convert.ToChar(Keys.Enter));
            cboPesquisa_KeyPress(sender, args);*/
        }

        private void btNovoEmprestimo_Click(object sender, EventArgs e)
        {
            if (dgvResultadosPesquisa.CurrentRow.Cells[0].Value != null) {
                List<DataGridViewRow> livrosPesquisa = new List<DataGridViewRow>();
                DataGridViewRow r = (DataGridViewRow)dgvResultadosPesquisa.CurrentRow.Clone();
                int dgvPrimeiraLinha = dgvResultadosPesquisa.CurrentCell.RowIndex;
                for (int i = 0; i < dgvResultadosPesquisa.CurrentRow.Cells.Count; i++)
                {
                    r.Cells[i].Value = dgvResultadosPesquisa.CurrentRow.Cells[i].Value;
                }
                livrosPesquisa.Add(r);

                int t = 0;
                foreach (DataGridViewRow item in dgvResultadosPesquisa.Rows)
                {
                    if (t == dgvPrimeiraLinha)
                    {
                        t++;
                        continue;
                    }
                    else
                    {
                        r = (DataGridViewRow)item.Clone();

                        for (int i = 0; i < item.Cells.Count; i++)
                        {

                            r.Cells[i].Value = item.Cells[i].Value;
                        }
                        livrosPesquisa.Add(r);
                        t++;
                    }
                }

                ((Form)this.TopLevelControl).Hide();
                frmNovoEmprestimo ne = new frmNovoEmprestimo(livrosPesquisa);
                ne.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para realizar um novo empréstimo.");
            }
        }

        private void btCadastrarCliente_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmCadastrarCliente cc = new frmCadastrarCliente();
            cc.Show();
        }

        private void btNovaReserva_Click(object sender, EventArgs e)
        {
            if (dgvResultadosPesquisa.CurrentRow.Cells[0].Value != null) {
                if (dgvResultadosPesquisa.CurrentRow.Cells[2].Value.ToString() == "0")
                {
                    List<string> campos = new List<string>();
                    campos.Add(dgvResultadosPesquisa.CurrentRow.Cells[0].Value.ToString());
                    campos.Add(dgvResultadosPesquisa.CurrentRow.Cells[1].Value.ToString());
                    ((Form)this.TopLevelControl).Hide();
                    frmReserva res = new frmReserva(campos, "nova");
                    res.Show();
                }
                else
                {
                    MessageBox.Show("Este exemplar está disponível. \nPor favor efetue um empréstimo.");
                }
            }
            else
            {
                ((Form)this.TopLevelControl).Hide();
                frmReserva res = new frmReserva();
                res.Show();
            }
        }
        private void carregar_emprestimos_hoje()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call carregar_emprestimos_hoje";
                var resp = cmd.ExecuteReader();
                Conexao.con.Close();

                if (resp.HasRows)
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvEmprestimosHoje.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar os dados: "+ex.Message);
            }
        }

        private void txtPesquisaLivro_KeyUp(object sender, KeyEventArgs e)
        {
            if (chkPesquisaDigitacao.Checked == true) {
                if (txtPesquisaLivro.Text == "")
                {
                    panResultadosPesquisa.Visible = false;
                    panEntregas.Visible = true;
                }
                else
                {
                    panResultadosPesquisa.Visible = true;
                    panEntregas.Visible = false;
                }
                //Consoles funcionam no Windows Forms. Idem Debug.Write();
                //Console.WriteLine("Testando \"A\"");
                efetuarPesquisa();
            }
            else
            {
                if (txtPesquisaLivro.Text == "")
                {
                    panResultadosPesquisa.Visible = false;
                    panEntregas.Visible = true;
                }
            }
        }

    }
}
