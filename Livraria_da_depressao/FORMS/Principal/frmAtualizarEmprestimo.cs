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

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class frmAtualizarEmprestimo : Form
    {
        public int i = 0;
        public frmAtualizarEmprestimo()
        {
            InitializeComponent();
        }

        public frmAtualizarEmprestimo(List<string> campos)
        {
            InitializeComponent();
            pesquisar_multa_emprestimo(campos[0]);
            txtClienteEmprestimo.Text = campos[1];
            txtIdEmprestimo.Text = campos[0];
            if (campos[2] != "")
                ckbLivroEntregue.Checked = true;    
            for (i = 0; i<4; i++)
            {
                if (cboStatusEmprestimo.Items[i].ToString().ToLower() == campos[3])
                {
                    cboStatusEmprestimo.SelectedIndex = i;
                    break;
                }
            }
            lblTemMulta.Text = campos[4];
            if (campos[4] == "Não")
                ckbMultaPaga.Enabled = false;

            if (ckbLivroEntregue.Checked == true && ckbMultaPaga.Checked == true)
                btSalvarEmprestimo.Enabled = false;
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btSalvarEmprestimo_Click(object sender, EventArgs e)
        {
            if (cboStatusEmprestimo.SelectedIndex != i || ckbLivroEntregue.Checked == true)
            {
                DateTime dt = DateTime.Now;
                inicioDTO idto = new inicioDTO();
                idto.idEmprestimo = txtIdEmprestimo.Text;
                idto.dataEntrega = dt.ToString("yyyy-MM-dd HH:mm");
                idto.statusEmprestimo = cboStatusEmprestimo.Text;
                inicioBLL ibll = new inicioBLL();
                ibll.atualizar_status_emprestimo(idto);
                if (ckbMultaPaga.Checked == true)
                {
                    ibll.atualizar_multa_paga(idto);
                }
            }
            else
            {
                MessageBox.Show("Para atualizar este registro deve haver alguma alteração.");
            }
            this.Close();
        }

        private void frmAtualizarEmprestimo_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial mi = new frmMenuInicial("emprestimo");
            mi.Show();
        }

        private void pesquisar_multa_emprestimo(string id)
        {
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select statusMulta from MULTA where idEmprestimo = @id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                Conexao.con.Close();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow row in dt.Rows)
                    if (row[0].ToString() == "paga") ckbMultaPaga.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar o registro: " + ex.Message);
                Conexao.con.Close();
            }
        }
    }
}
