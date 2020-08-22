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
using System.Runtime.InteropServices;
using Livraria_da_depressao.CODE.DTO;

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class ucSelecionarEmprestimoReserva : UserControl
    {
        private List<reservaDTO> emprestimos = new List<reservaDTO>();
        public ucSelecionarEmprestimoReserva()
        {
            InitializeComponent();
        }
        
        private void ucSelecionarEmprestimoReserva_Load(object sender, EventArgs e)
        {
            if (reservaDTO.idLivroBusca != "")
            {
                try
                {
                    Conexao.con.Open();
                    MySqlCommand msc = Conexao.con.CreateCommand();
                    msc.CommandType = CommandType.Text;
                    msc.CommandText = "call selecionar_emprestimos_disponiveis(@idLivro)";
                    msc.Parameters.AddWithValue("@idLivro", reservaDTO.idLivroBusca);
                    MySqlDataReader msdr = msc.ExecuteReader();

                    if (msdr.HasRows)
                    {
                        Conexao.con.Close();
                        DataTable dt = new DataTable();
                        MySqlDataAdapter da = new MySqlDataAdapter(msc);
                        da.Fill(dt);

                        foreach (DataRow row in dt.Rows)
                        {
                            reservaDTO res = new reservaDTO();
                            res.idEmprestimo = row[0].ToString();
                            res.stringEmprestimo = "# ID: " + row[0].ToString() + " - Entrega prevista: " + row[1].ToString();

                            var dataHora = Convert.ToDateTime(row[1]);
                            res.dataDevolucaoEmprestimo = dataHora.Date.ToString();
                            res.horaDevolucaoEmprestimo = dataHora.TimeOfDay.ToString();
                            emprestimos.Add(res);
                            lstEmprestimosDisponiveis.Items.Add(res.stringEmprestimo);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível carregar os empréstimos. " + ex.Message);
                    Conexao.con.Close();
                }
            }
        }

        private void btAvancar_Click(object sender, EventArgs e)
        {
            if (lstEmprestimosDisponiveis.SelectedIndex != -1)
            {
                this.Visible = false;
                var parent = this.Parent as frmReserva;
                parent.valorCodigo = emprestimos[lstEmprestimosDisponiveis.SelectedIndex].idEmprestimo;
                parent.valorDataRetiradaPrevista = emprestimos[lstEmprestimosDisponiveis.SelectedIndex].dataDevolucaoEmprestimo;
                parent.valorHoraRetiradaPrevista = emprestimos[lstEmprestimosDisponiveis.SelectedIndex].horaDevolucaoEmprestimo;
            }
            else
            {
                MessageBox.Show("Por favor selecione um empréstimo.");
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmMenuInicial mi = new frmMenuInicial();
            mi.Show();
        }
    }
}
