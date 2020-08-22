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
    public partial class ucGerCategorias : UserControl
    {
        public ucGerCategorias()
        {
            InitializeComponent();
        }

        private void ucGerCategorias_Load(object sender, EventArgs e)
        {
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_categorias";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                dgvCategorias.Rows.Add(row[0], row[1]);
            }
        }

        private void btNovaCategoria_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmCategoriaConf cc = new frmCategoriaConf();
            cc.Show();
        }

        private void btEditarCategoria_Click(object sender, EventArgs e)
        {
            if (dgvCategorias.CurrentRow.Cells[0].Value != null) {
                List<string> campos = new List<string>();
                campos.Add(dgvCategorias.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvCategorias.CurrentRow.Cells[1].Value.ToString());

                ((Form)this.TopLevelControl).Hide();
                frmCategoriaConf fu = new frmCategoriaConf(campos, "editar");
                fu.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para editar.");
            }
        }
    }
}
