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
using Livraria_da_depressao.FORMS.Principal;

namespace Livraria_da_depressao.FORMS.UCs
{
    public partial class ucEmprestimos : UserControl
    {
        public ucEmprestimos()
        {
            InitializeComponent();
        }

        private void ucEmprestimos_Load(object sender, EventArgs e)
        {
            carregar_emprestimos();
        }

        private void carregar_emprestimos()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_emprestimos";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            DateTime dateObj = DateTime.Now;
            var hoje = dateObj.Date;

            foreach (DataRow row in dt.Rows)
            {
                inicioBLL ibll = new inicioBLL();
                inicioDTO idto = new inicioDTO();

                DateTime dateObjMysql = Convert.ToDateTime(row[2]);
                var entregaPrevista = dateObjMysql.Date;
                var status = row[4];

                if (row[4].ToString() == "pontual" && DateTime.Compare(hoje, entregaPrevista) > 0)
                {
                    idto.statusEmprestimo = "atraso";
                    idto.idEmprestimo = row[0].ToString();
                    idto.dataEntrega = null;
                    ibll.atualizar_status_emprestimo(idto);
                    status = "atraso";
                }
                idto.idEmprestimo = row[0].ToString();
                string multa = ibll.pesquisar_multa_emprestimo(idto);
                dgvListaEmprestimos.Rows.Add(row[0], row[7], row[6], row[1], row[2], row[3], status, multa, row[5], row[8]);
            }
        }

        private void btAtualizarEmprestimo_Click(object sender, EventArgs e)
        {
            if (dgvListaEmprestimos.CurrentRow.Cells[0].Value != null) {
                List<string> campos = new List<string>();
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[2].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[5].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[6].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[7].Value.ToString());
                ((Form)this.TopLevelControl).Hide();
                frmAtualizarEmprestimo ae = new frmAtualizarEmprestimo(campos);
                ae.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para atualizar.");
            }
        }

        private void btDetalhesEmprestimo_Click(object sender, EventArgs e)
        {
            if (dgvListaEmprestimos.CurrentRow.Cells[0].Value != null)
            {
                List<string> campos = new List<string>();
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[1].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[2].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[3].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[4].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[5].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[6].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[7].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[8].Value.ToString());
                campos.Add(dgvListaEmprestimos.CurrentRow.Cells[9].Value.ToString());
                frmDetalhesEmprestimo de = new frmDetalhesEmprestimo(campos);
                de.Show();
            }
            else
            {
                MessageBox.Show("Esta linha esta vazia. Por favor escolha outra.");
            }
            
        }

        private void btNovoEmprestimo_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmNovoEmprestimo ne = new frmNovoEmprestimo();
            ne.Show();
        }
    }
}
