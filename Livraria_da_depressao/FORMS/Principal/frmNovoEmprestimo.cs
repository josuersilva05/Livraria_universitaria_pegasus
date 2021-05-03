using Livraria_da_depressao.CODE.DAL;
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
using MySql.Data.MySqlClient;
using Livraria_da_depressao.CODE.BLL;

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class frmNovoEmprestimo : Form
    {
        private List<DataGridViewRow> livros;
        private List<livrosEmprestimoDTO> codLivros = new List<livrosEmprestimoDTO>();
        private List<clientesEmprestimoDTO> listClientes = new List<clientesEmprestimoDTO>();
        private float valorEmprestimo;
        private string data;
        private string entregaPrevista;
        private string hora;
        public frmNovoEmprestimo()
        {
            InitializeComponent(); 
            setarValorEmprestimo();
        }
        public frmNovoEmprestimo(List<DataGridViewRow> items)
        {
            InitializeComponent();
            setarValorEmprestimo();
            livros = items;
            foreach (DataGridViewRow item in items)
            {
                if (item.Cells[1].Value != null)
                {
                    cboLivroEmprestimo.Items.Add(item.Cells[1].Value);
                }
            }

            cboLivroEmprestimo.SelectedIndex = 0;
            cboClienteEmprestimo.SelectedIndex = 0; 
        }
        public frmNovoEmprestimo(List<livrosEmprestimoDTO> parmLivros, List<clientesEmprestimoDTO> parmClientes)
        {
            InitializeComponent();
            setarValorEmprestimo();
            codLivros = parmLivros;
            listClientes = parmClientes;
            cboClienteEmprestimo.Items.Add(listClientes[0].nomeCliente);
            cboLivroEmprestimo.Items.Add(codLivros[0].nomeLivro);
            cboClienteEmprestimo.SelectedIndex = 0;
            cboLivroEmprestimo.SelectedIndex = 0;
        }

        private void btConfirmarEmprestimo_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja cadastrar este emprestimo?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                var dia = dtpEntregaPrevista.Value.Day.ToString("d");
                var mes = dtpEntregaPrevista.Value.Month.ToString();
                var ano = dtpEntregaPrevista.Value.Year.ToString();

                if (mes.Length == 1)
                {
                    mes = "0" + mes;
                }
                data = ano + "-" + mes + "-" + dia;
                hora = dtpHorarioDevolucao.Value.TimeOfDay.ToString();

                int pos = hora.LastIndexOf(".");
                if (pos != 0 && pos > 0)
                {
                    hora = hora.Substring(0, pos);
                }
                entregaPrevista = data + " " + hora;

                string idLivro;
                if (livros != null)
                {
                    idLivro = livros[cboLivroEmprestimo.SelectedIndex].Cells[0].Value.ToString();
                }
                else
                {
                    idLivro = codLivros[cboLivroEmprestimo.SelectedIndex].idLivro.ToString();
                }

                inicioDTO idto = new inicioDTO();
                idto.dataPrevistaEntrega = entregaPrevista;
                idto.idFuncionarioEmprestimo = usuarioSessaoDTO.idUsuario.ToString();
                idto.idClienteEmprestimo = listClientes[cboClienteEmprestimo.SelectedIndex].idCliente.ToString();
                idto.idLivroEmprestimo = idLivro;
                idto.totalEmprestimo = valorEmprestimo;

                inicioBLL ibll = new inicioBLL();
                result = ibll.cadastrar_emprestimo(idto); 
                if (result == true)
                {
                    MessageBox.Show("Emprestimo Cadastrado! \nEntrega prevista para: " + data + " às " + hora, "Resultado", MessageBoxButtons.OK);
                    this.Close();
                }
            }
        }

        private void btCancelarEmprestimo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNovoEmprestimo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial mi = new frmMenuInicial("emprestimo");
            mi.Show();
        }

        private void dtpEntregaPrevista_ValueChanged(object sender, EventArgs e)
        {
            setarValorEmprestimo();
        }

        private void setarValorEmprestimo()
        {
            DateTime entrega = DateTime.Parse(dtpEntregaPrevista.Value.ToString());
            DateTime today = DateTime.Today;
            DateTime umaSemana = today.AddDays(7);
            DateTime duasSemanas = today.AddDays(14);

            if (DateTime.Compare(entrega, umaSemana) <= 0)
            {
                valorEmprestimo = 2.50f;
            }
            else if (DateTime.Compare(entrega, duasSemanas) <= 0)
            {
                valorEmprestimo = 5.0f;
            }
            else
            {
                valorEmprestimo = 10;
            }
            txtValorEmprestimo.Text = valorEmprestimo.ToString();
            data = dtpEntregaPrevista.Value.Date.ToString("d");
        }

        private void cboLivroEmprestimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboLivroEmprestimo.Items.Clear();
            cboLivroEmprestimo.SelectionStart = cboLivroEmprestimo.Text.Length;

            if (codLivros.Count != 0)
            {
                codLivros.Clear();
            }

            MySqlDataAdapter msa = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                if (cboLivroEmprestimo.Text != "")
                {
                    if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
                    Conexao.con.Open();

                    MySqlCommand msc = Conexao.con.CreateCommand();
                    msc.CommandType = CommandType.Text;
                    msc.CommandText = "call pesquisar_livros(@texto, @limite)";
                    msc.Parameters.AddWithValue("@texto", cboLivroEmprestimo.Text);
                    msc.Parameters.AddWithValue("@limite", 10);
                    MySqlDataReader msdr = msc.ExecuteReader();

                    if (msdr.HasRows)
                    {
                        lblErroBuscaLivro.Text = "";
                        Conexao.con.Close();
                        MySqlDataAdapter da = new MySqlDataAdapter(msc);
                        da.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            livrosEmprestimoDTO ledto = new livrosEmprestimoDTO();
                            ledto.idLivro = dr[0].ToString();
                            ledto.nomeLivro = dr[1].ToString();
                            codLivros.Add(ledto);
                            cboLivroEmprestimo.Items.Add(dr[1].ToString());
                        }
                    }
                    else
                    {
                        if (cboLivroEmprestimo.Text.Length >= 2)
                            lblErroBuscaLivro.Text = String.Format("Não foi possível encontrar um livro com \'{0}\'", cboLivroEmprestimo.Text);
                    }

                    Conexao.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta dos livros" + ex.Message);
            } 
            
        }

        private void cboClienteEmprestimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboClienteEmprestimo.Items.Clear();
            cboClienteEmprestimo.SelectionStart = cboClienteEmprestimo.Text.Length;

            if (listClientes.Count != 0)
            {
                listClientes.Clear();
            }

            MySqlDataAdapter msa = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                if (cboClienteEmprestimo.Text != "")
                {
                    if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
                    Conexao.con.Open();

                    MySqlCommand msc = Conexao.con.CreateCommand();
                    msc.CommandType = CommandType.Text;
                    msc.CommandText = "call pesquisar_cliente_regularizado(@texto)";
                    msc.Parameters.AddWithValue("@texto", cboClienteEmprestimo.Text);
                    MySqlDataReader msdr = msc.ExecuteReader();

                    if (msdr.HasRows)
                    {
                        lblErroBuscaCliente.Text = "";
                        Conexao.con.Close();
                        MySqlDataAdapter da = new MySqlDataAdapter(msc);
                        da.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            clientesEmprestimoDTO cedto = new clientesEmprestimoDTO();
                            cedto.idCliente = dr[0].ToString();
                            cedto.nomeCliente = dr[1].ToString();
                            listClientes.Add(cedto);
                            cboClienteEmprestimo.Items.Add(dr[1].ToString());
                        }
                    }
                    else
                    {
                        if (cboClienteEmprestimo.Text.Length >= 2)
                            lblErroBuscaCliente.Text = String.Format("Não foi encontrado nenhum cliente regulariado com \'{0}\'", cboClienteEmprestimo.Text);
                    }

                    Conexao.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta dos livros" + ex.Message);
            }
        }

        
    }
}
