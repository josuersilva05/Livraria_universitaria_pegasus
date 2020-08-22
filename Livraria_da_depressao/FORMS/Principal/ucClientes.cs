using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Livraria_da_depressao.CODE.DAL;
using MySql.Data.MySqlClient;
using Livraria_da_depressao.CODE.DTO;
using Livraria_da_depressao.CODE.BLL;

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class ucClientes : UserControl
    {
        public string colunaPesquisa;
        public ucClientes()
        {
            InitializeComponent();
            cboItemPesquisa.SelectedIndex = 0;
        }

        private void ucClientes_Load(object sender, EventArgs e)
        {
            carregar_clientes();
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            pesquisar_cliente();
        }

        private void pesquisar_cliente()
        {
            if(cboItemPesquisa.SelectedIndex == 0)
                colunaPesquisa = "nome";
            else
                colunaPesquisa = "cpf";

            dgvListaClientes.Rows.Clear();

            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call pesquisar_cliente(@texto, @coluna)";
                cmd.Parameters.AddWithValue("@texto", txtPesquisa.Text);
                cmd.Parameters.AddWithValue("@coluna", colunaPesquisa);
                cmd.ExecuteNonQuery();

                Conexao.con.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string regularizado;
                    if (row[4].ToString() == "regularizado")
                        regularizado = "Regularizado";
                    else
                        regularizado = "Não regularizado";

                    string sexo = row[6].ToString().ToUpper();

                    dgvListaClientes.Rows.Add(row[0], row[1], row[2], row[3], regularizado, row[5], sexo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }

        }

        private void carregar_clientes()
        {
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call carregar_clientes";
                cmd.ExecuteNonQuery();

                Conexao.con.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    string regularizado;
                    if (row[4].ToString() == "regularizado")
                        regularizado = "Regularizado";
                    else
                        regularizado = "Não regularizado";

                    string sexo = row[6].ToString().ToUpper();

                    dgvListaClientes.Rows.Add(row[0], row[1], row[2], row[3], regularizado, row[5], sexo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar dados: " + ex.Message);
            }
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            if (dgvListaClientes.CurrentRow.Cells[0].Value != null) {
                ((Form)this.TopLevelControl).Hide();
                List<string> campos = new List<string>();
                campos.Add(dgvListaClientes.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvListaClientes.CurrentRow.Cells[1].Value.ToString());
                campos.Add(dgvListaClientes.CurrentRow.Cells[2].Value.ToString());
                campos.Add(dgvListaClientes.CurrentRow.Cells[3].Value.ToString());
                campos.Add(dgvListaClientes.CurrentRow.Cells[4].Value.ToString());
                campos.Add(dgvListaClientes.CurrentRow.Cells[5].Value.ToString());
                campos.Add(dgvListaClientes.CurrentRow.Cells[6].Value.ToString());

                frmCliente cl = new frmCliente(campos);
                cl.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para atualizar.");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvListaClientes.CurrentRow.Cells[0].Value != null) {
                DialogResult resp = MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    bool result = false;
                    inicioDTO idto = new inicioDTO();
                    inicioBLL ibll = new inicioBLL();
                    idto.idCliente = dgvListaClientes.CurrentRow.Cells[0].Value.ToString();
                    result = ibll.excluir_cliente(idto);
                    if (result == true)
                    {
                        MessageBox.Show("Registro excluido com sucesso!");
                        dgvListaClientes.Rows.Clear();
                        carregar_clientes();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um registro para excluir.");
            }
        }

        private void btNovoCliente_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmCadastrarCliente ne = new frmCadastrarCliente();
            ne.Show();
        }
    }
}
