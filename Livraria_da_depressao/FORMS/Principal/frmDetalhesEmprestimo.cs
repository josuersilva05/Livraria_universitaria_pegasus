using Livraria_da_depressao.CODE.DAL;
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
    public partial class frmDetalhesEmprestimo : Form
    {
        public List<string> camposForm;
        public DateTime entregaPrevista;
        public int diasAtraso = 0;
        public double total = 0;
        public string multas = "";
        public string StatusMultas = "";
        public frmDetalhesEmprestimo()
        {
            InitializeComponent();
        }

        public frmDetalhesEmprestimo(List<string> campos)
        {
            InitializeComponent();
            camposForm = campos;
            DateTime dt = DateTime.Now;
            var hoje = dt.Date;
            var entregaAux = Convert.ToDateTime(camposForm[4]);
            entregaPrevista = entregaAux.Date;
            diasAtraso = Convert.ToInt32((hoje - entregaPrevista).TotalDays);
        }

        private void frmDetalhesEmprestimo_Load(object sender, EventArgs e)
        {
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_detalhes_emprestimo(@id)";
            cmd.Parameters.AddWithValue("@id",camposForm[0]);
            cmd.ExecuteNonQuery();
            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            
            foreach (DataRow row in dt.Rows)
            {
                multas += row[1].ToString()+", ";
                StatusMultas = row[2].ToString();
                if (row[0].ToString() == "atraso")
                {
                    total = Convert.ToDouble(row[1].ToString()) * diasAtraso;
                }
                else if(row[0].ToString() == "perca")
                {
                    total += Convert.ToDouble(row[3].ToString());
                }
            }
            if (multas.Length > 0)
            {
                multas = multas.Substring(0, multas.Length - 2);
            }
            setarInfo();
        }

        private void setarInfo()
        {
            lblId.Text = "ID: "+camposForm[0];
            lblAtendente.Text = "Atendente: "+camposForm[8];
            lblDiasAtraso.Text = "Dias em atraso: "+diasAtraso;
            lblEmprestadoEm.Text = "Emprestado em: "+camposForm[3];
            lblEntregueEm.Text = "Entregue em: "+camposForm[5];
            lblLivro.Text = "Livro: "+camposForm[1];
            lblMultas.Text = "Multas: "+multas;
            lblPrevisaoEntrega.Text = "Entrega prevista: "+camposForm[4];
            lblResponsavel.Text = "Responsável: "+camposForm[2];
            lblStatus.Text = "Status: "+camposForm[6];
            lblStatusMulta.Text = "Status Multa: "+StatusMultas;
            lblTotal.Text = "Total: R$ "+total+"0";
            lblValorEmprestimo.Text = "Valor emprestimo: "+camposForm[9];
        }
    }
}
