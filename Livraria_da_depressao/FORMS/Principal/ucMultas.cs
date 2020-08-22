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

namespace Livraria_da_depressao.FORMS
{
    public partial class ucMultas : UserControl
    {
        public ucMultas()
        {
            InitializeComponent();
        }

        private void ucMultas_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call carregar_multas";
                cmd.ExecuteNonQuery();

                Conexao.con.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    double valor = Convert.ToDouble(row[6].ToString());
                    int dias = Convert.ToInt32(row[7].ToString());
                    double total = Convert.ToDouble(valor * dias);
                    dgvListaMultas.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], total, row[8]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar as multas: "+ex.Message);
            }
            
        }

        private void btAtualizarMulta_Click(object sender, EventArgs e)
        {
            if (dgvListaMultas.CurrentRow.Cells[0].Value != null)
            {

            }
            else
            {
                MessageBox.Show("Escolha um registro para atualizar.");
            }
        }

        private void btNovaMulta_Click(object sender, EventArgs e)
        {

        }
    }
}
