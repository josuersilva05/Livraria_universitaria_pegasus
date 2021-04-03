using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.DTO;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient.Memcached;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class frmReserva : Form
    {
        private reservaDTO reserva = new reservaDTO();
        private List<reservaDTO> livros = new List<reservaDTO>();
        private List<reservaDTO> clientes = new List<reservaDTO>();
        private string action = "nova";
        public string valorCodigo {
            set { txtCodigoEmprestimo.Text = value; }
        }
        public string valorDataRetiradaPrevista
        {
            set { dtpRetiradaPrevista.Value = Convert.ToDateTime(value);  }
        }
        public string valorHoraRetiradaPrevista
        {
            set { dtpHoraRetiradaPrevista.Value = Convert.ToDateTime(value); }
        }
        public frmReserva()
        {
            InitializeComponent();
            cboStatusReserva.SelectedIndex = 0;
            cboStatusReserva.Enabled = false;
        }

        public frmReserva(List<string> list, string acao)
        {
            InitializeComponent();
            action = acao;
            if (action == "nova")
            {
                //List é um livro
                reservaDTO livro = new reservaDTO();
                livro.idLivro = list[0];
                livro.nomeLivro = list[1];
                livros.Add(livro);
                cboLivroReserva.Items.Add(livros[0].nomeLivro);
                cboStatusReserva.SelectedIndex = 0;
                cboLivroReserva.SelectedIndex = 0;
                reservaDTO.idLivroBusca = list[0];
                cboStatusReserva.SelectedIndex = 0;
                cboStatusReserva.Enabled = false;
            } 
            else if (action == "editar") 
            {
                //List é uma reserva
                ucSelecionarEmprestimoReserva1.Visible = false;
                reserva.idReserva = list[0].ToString();
                cboLivroReserva.Text = list[1].ToString();
                cboClienteReserva.Text = list[2].ToString();
                cboLivroReserva.Enabled = false;
                cboClienteReserva.Enabled = false;
                txtCodigoEmprestimo.Text = list[6].ToString();

                DateTime retiradaPrevista = Convert.ToDateTime(list[4]);
                dtpHoraRetiradaPrevista.Value = Convert.ToDateTime(retiradaPrevista.ToString());
                dtpRetiradaPrevista.Value = Convert.ToDateTime(retiradaPrevista.Date);
            } 
        }

        private void frmReserva_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial mi = new frmMenuInicial("reserva");
            mi.Show();
        }

        private void cboClienteReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboClienteReserva.Items.Clear();
            cboClienteReserva.SelectionStart = cboClienteReserva.Text.Length;

            if (clientes.Count != 0)
            {
                clientes.Clear();
            }

            MySqlDataAdapter msa = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                if (cboClienteReserva.Text != "")
                {
                    if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
                    Conexao.con.Open();

                    MySqlCommand msc = Conexao.con.CreateCommand();
                    msc.CommandType = CommandType.Text;
                    msc.CommandText = "call pesquisar_cliente_regularizado(@texto)";
                    msc.Parameters.AddWithValue("@texto", cboClienteReserva.Text);
                    MySqlDataReader msdr = msc.ExecuteReader();

                    if (msdr.HasRows)
                    {
                        lblErroBuscaCliente.Text = "";
                        Conexao.con.Close();
                        MySqlDataAdapter da = new MySqlDataAdapter(msc);
                        da.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            reservaDTO reserva = new reservaDTO();
                            reserva.idCliente = dr[0].ToString();
                            reserva.nomeCliente = dr[1].ToString();
                            clientes.Add(reserva);
                            cboClienteReserva.Items.Add(dr[1].ToString());
                        }
                    }
                    else
                    {
                        if (cboClienteReserva.Text.Length >= 2)
                            lblErroBuscaCliente.Text = String.Format("Não foi encontrado nenhum cliente regulariado com \'{0}\'", cboClienteReserva.Text);
                    }

                    Conexao.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta dos livros" + ex.Message);
            }
        }

        private void cboLivroReserva_KeyPress(object sender, KeyPressEventArgs e)
        {
            cboLivroReserva.Items.Clear();
            cboLivroReserva.SelectionStart = cboLivroReserva.Text.Length;

            if (livros.Count != 0)
            {
                livros.Clear();
            }

            MySqlDataAdapter msa = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                if (cboLivroReserva.Text != "")
                {
                    if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
                    Conexao.con.Open();

                    MySqlCommand msc = Conexao.con.CreateCommand();
                    msc.CommandType = CommandType.Text;
                    msc.CommandText = "call pesquisar_livros(@texto, @limite)";
                    msc.Parameters.AddWithValue("@texto", cboLivroReserva.Text);
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
                            reservaDTO reserva = new reservaDTO();
                            reserva.idLivro = dr[0].ToString();
                            reserva.nomeLivro = dr[1].ToString();
                            livros.Add(reserva);
                            cboLivroReserva.Items.Add(dr[1].ToString());
                        }
                    }
                    else
                    {
                        if (cboLivroReserva.Text.Length >= 2)
                            lblErroBuscaLivro.Text = String.Format("Não foi possível encontrar um livro com \'{0}\'", cboLivroReserva.Text);
                    }

                    Conexao.con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível realizar a consulta dos livros" + ex.Message);
            }
            this.Close();
        }

        private void btConfirmarReserva_Click(object sender, EventArgs e)
        {
            inicioDTO idto = new inicioDTO();
            inicioBLL ibll = new inicioBLL();
            if (cboClienteReserva.Enabled == false && cboLivroReserva.Enabled == false)
            {
                //ATUALIZAR
                DialogResult resp = MessageBox.Show("Deseja atualizar esta reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    bool fechamento = false;
                    if (cboStatusReserva.Text == "Concluida")
                        fechamento = true;

                    var dia = dtpRetiradaPrevista.Value.Day.ToString("d");
                    var mes = dtpRetiradaPrevista.Value.Month.ToString();
                    var ano = dtpRetiradaPrevista.Value.Year.ToString();

                    if (mes.Length == 1)
                        mes = "0" + mes;

                    var data = ano + "-" + mes + "-" + dia;
                    var hora = dtpHoraRetiradaPrevista.Value.TimeOfDay.ToString();

                    int pos = hora.LastIndexOf(".");
                    if (pos != 0 && pos > 0)
                        hora = hora.Substring(0, pos);

                    var stringDataRetirada = data + " " + hora;

                    idto.idReserva = reserva.idReserva;
                    idto.statusReserva = cboStatusReserva.Text;
                    idto.dataRetiradaPrevista = stringDataRetirada;
                    if (ibll.editar_reserva(idto) == true)
                    {
                        MessageBox.Show("Reserva atualizada com sucesso!");
                        if (fechamento == true)
                        {
                            btConfirmarReserva.BackColor = Color.FromArgb(224, 224, 224);
                            btConfirmarReserva.ForeColor = Color.FromArgb(10,10,10);
                            btConfirmarReserva.Enabled = false;
                            btRealizarEmprestimo.Visible = true;
                        }
                        else
                        {
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível atualizar a reserva.");
                    }
                }
            }
            else
            {
                // CADASTRAR
                DialogResult resp = MessageBox.Show("Deseja cadastrar esta reserva?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    var dia = dtpRetiradaPrevista.Value.Day.ToString("d");
                    var mes = dtpRetiradaPrevista.Value.Month.ToString();
                    var ano = dtpRetiradaPrevista.Value.Year.ToString();

                    if (mes.Length == 1)
                        mes = "0" + mes;

                    var data = ano + "-" + mes + "-" + dia;
                    var hora = dtpHoraRetiradaPrevista.Value.TimeOfDay.ToString();

                    int pos = hora.LastIndexOf(".");
                    if (pos != 0 && pos > 0)
                        hora = hora.Substring(0, pos);

                    var stringDataRetirada = data + " " + hora;

                    if (cboClienteReserva.SelectedIndex < 0 && cboClienteReserva.Text != "")
                        cboClienteReserva.SelectedIndex = 0;

                    if (cboLivroReserva.SelectedIndex < 0 && cboLivroReserva.Text != "")
                        cboLivroReserva.SelectedIndex = 0;

                    idto.idCliente = clientes[cboClienteReserva.SelectedIndex].idCliente;
                    idto.idLivro = livros[cboLivroReserva.SelectedIndex].idLivro;
                    idto.idEmprestimo = txtCodigoEmprestimo.Text;
                    idto.dataRetiradaPrevista = stringDataRetirada;
                    if (ibll.cadastrar_reserva(idto) == true)
                    {
                        MessageBox.Show("Reserva efetuada com sucesso!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível realizar a reserva.");
                    }
                }
            }
        }

        private void cboStatusReserva_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStatusReserva.SelectedIndex == 3)
            {
                panRetirada.BringToFront();
                dtpRetirada.Value = DateTime.Now;
            }
            else
            {
                panRetirada.SendToBack();
            }
        }

        private void btRealizarEmprestimo_Click(object sender, EventArgs e)
        {
            inicioBLL ibll = new inicioBLL();
            var ids = ibll.pesquisar_idClienteLivroReserva(reserva.idReserva);
            
            if (ids.Count != 0 && ids != null)
            {
                livrosEmprestimoDTO objLiv = new livrosEmprestimoDTO();
                clientesEmprestimoDTO objCli = new clientesEmprestimoDTO();
                objLiv.idLivro = ids[1];
                objLiv.nomeLivro = cboLivroReserva.Text;
                objCli.idCliente = ids[0];
                objCli.nomeCliente = cboClienteReserva.Text;

                List<livrosEmprestimoDTO> ledto = new List<livrosEmprestimoDTO>();
                List<clientesEmprestimoDTO> cedto = new List<clientesEmprestimoDTO>();
                ledto.Add(objLiv);
                cedto.Add(objCli);

                frmNovoEmprestimo frm = new frmNovoEmprestimo(ledto, cedto);
                this.Close();
                frm.Show();
            }
            else
            {
                MessageBox.Show("Não foi possível criar o empréstimo. \nPor favor, contate o desenvolvedor.");
            }
        }
    }
}
