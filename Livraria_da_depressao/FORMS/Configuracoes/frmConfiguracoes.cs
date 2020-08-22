using Livraria_da_depressao.FORMS.Configuracoes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao.FORMS
{
    public partial class frmConfiguracoes : Form
    {
        public frmConfiguracoes()
        {
            InitializeComponent();
        }
        public frmConfiguracoes(string origem)
        {
            InitializeComponent();
            if (origem == "autor")
            {
                ucGerAutores1.BringToFront();
            }
            else if (origem == "funcionario")
            {
                ucGerFuncionarios1.BringToFront();
            } 
            else if (origem == "usuario")
            {
                ucGerUsuarios1.BringToFront();
            } 
            else if (origem == "categoria")
            {
                ucGerCategorias1.BringToFront();
            }
            else if (origem == "editora")
            {
                ucGerEditoras1.BringToFront();
            }
            else if (origem == "multa")
            {
                ucGerMultas1.BringToFront();
            }
            else if (origem == "livro")
            {
                ucGerLivros1.BringToFront();
            }
        }

        private void frmConfiguracoes_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial fm = new frmMenuInicial();
            fm.Show();
        }

        private void btGerFuncionarios_Click(object sender, EventArgs e)
        {
            ucGerFuncionarios1.BringToFront();
        }

        private void btGerLivros_Click(object sender, EventArgs e)
        {
            ucGerLivros1.BringToFront();
        }

        private void btGerEditoras_Click(object sender, EventArgs e)
        {
            ucGerEditoras1.BringToFront();
        }

        private void btGerAutores_Click(object sender, EventArgs e)
        {
            ucGerAutores1.BringToFront();
        }

        private void btGerCategorias_Click(object sender, EventArgs e)
        {
            ucGerCategorias1.BringToFront();
        }

        private void btGerMultas_Click(object sender, EventArgs e)
        {
            ucGerMultas1.BringToFront();
        }

        private void btGerUsuarios_Click_1(object sender, EventArgs e)
        {
            ucGerUsuarios1.BringToFront();
        }

        private void ucGerUsuarios1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
