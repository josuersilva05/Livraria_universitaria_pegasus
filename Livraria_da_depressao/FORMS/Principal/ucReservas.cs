using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Livraria_da_depressao.FORMS.Principal;
using Livraria_da_depressao.CODE.DAL;
using MySql.Data.MySqlClient;

namespace Livraria_da_depressao.FORMS
{
    public partial class ucReservas : UserControl
    {
        public ucReservas()
        {
            InitializeComponent();
        }

        private void btNovaReserva_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmReserva res = new frmReserva();
            res.Show();
        }

        private void btAtualizarReserva_Click(object sender, EventArgs e)
        {
            if (dgvListaReservas.CurrentRow.Cells[0].Value != null)
            {
                DataGridViewRow row = dgvListaReservas.CurrentRow;
                List<string> campos = new List<string>();
                for (int i = 0; i < dgvListaReservas.CurrentRow.Cells.Count; i++)
                    campos.Add(row.Cells[i].Value.ToString());

                ((Form)this.TopLevelControl).Hide();
                frmReserva res = new frmReserva(campos, "editar");
                res.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para atualizar.");
            }
            
        }

        private void ucReservas_Load(object sender, EventArgs e)
        {
            try
            {
                Conexao.con.Open();
                MySqlCommand msc = Conexao.con.CreateCommand();
                msc.CommandType = CommandType.Text;
                msc.CommandText = "call carregar_reservas()";
                MySqlDataReader msda = msc.ExecuteReader();

                if (msda.HasRows)
                {
                    Conexao.con.Close();
                    MySqlDataAdapter da = new MySqlDataAdapter(msc);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        dgvListaReservas.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString(), row[4].ToString(), row[5].ToString(), row[6].ToString(), row[7].ToString(), row[8].ToString());
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Não foi possível carregar as reservas: "+ex.Message);
                Conexao.con.Close();
            }
        }
    }
}
