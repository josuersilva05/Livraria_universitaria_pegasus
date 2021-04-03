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
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class ucGerMultas : UserControl
    {
        public ucGerMultas()
        {
            InitializeComponent();
        }

        private void ucGerMultas_Load(object sender, EventArgs e)
        {
            carregar_multas();
        }

        private void btNovaMulta_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmMultaConf ec = new frmMultaConf();
            ec.Show();
        }

        private void btEditarMulta_Click(object sender, EventArgs e)
        {
            if (dgvMultas.CurrentRow.Cells[0].Value != null) {
                List<string> campos = new List<string>();
                campos.Add(dgvMultas.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvMultas.CurrentRow.Cells[1].Value.ToString());
                campos.Add(dgvMultas.CurrentRow.Cells[2].Value.ToString());

                ((Form)this.TopLevelControl).Hide();
                frmMultaConf fu = new frmMultaConf(campos, "editar");
                fu.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para editar.");
            }
        }

        private void btExcluirMulta_Click(object sender, EventArgs e)
        {
            if (dgvMultas.CurrentRow.Cells[0].Value != null) {
                DialogResult resp = MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    bool status = false;
                    configuracoesBLL confbll = new configuracoesBLL();
                    configuracoesDTO confdto = new configuracoesDTO();
                    confdto.idMultaConf = dgvMultas.CurrentRow.Cells[0].Value.ToString();
                    status = confbll.excluir_multa(confdto);
                    if (status == true)
                    {
                        MessageBox.Show("Registro excluido com sucesso!");
                        dgvMultas.Rows.Clear();
                        carregar_multas();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um registro para excluir.");
            }
        }

        private void carregar_multas()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_tipos_multa";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                dgvMultas.Rows.Add(row[0], row[1], row[2]);
            }
        }
    }
}
