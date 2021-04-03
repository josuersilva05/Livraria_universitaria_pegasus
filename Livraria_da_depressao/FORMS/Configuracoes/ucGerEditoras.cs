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

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class ucGerEditoras : UserControl
    {
        public ucGerEditoras()
        {
            InitializeComponent();
        }

        private void btNovaEditora_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmEditoraConf ec = new frmEditoraConf();
            ec.Show();
        }

        private void btEditarEditora_Click(object sender, EventArgs e)
        {
            if (dgvEditoras.CurrentRow.Cells[0].Value != null) {
                List<string> campos = new List<string>();
                campos.Add(dgvEditoras.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvEditoras.CurrentRow.Cells[1].Value.ToString());

                ((Form)this.TopLevelControl).Hide();
                frmEditoraConf fu = new frmEditoraConf(campos, "editar");
                fu.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para editar.");
            }
        }

        private void ucGerEditoras_Load(object sender, EventArgs e)
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
                dgvEditoras.Rows.Add(row[0], row[1]);
            }
        }
    }
}
