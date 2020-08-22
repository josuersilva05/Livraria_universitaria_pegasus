using Livraria_da_depressao.CODE.DTO;
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
    public partial class frmMenuInicial : Form
    {
        public frmMenuInicial()
        {
            InitializeComponent();
            ucHome1.BringToFront();
            if(usuarioSessaoDTO.permissaoUsuario == "admin")
            {
                btConfiguracoes.Visible = true;
            }
            else
            {
                btConfiguracoes.Visible = false;
            }
        }
        
        public frmMenuInicial(string origem)
        {
            InitializeComponent(); 
            if (usuarioSessaoDTO.permissaoUsuario == "admin")
            {
                btConfiguracoes.Visible = true;
            }
            else
            {
                btConfiguracoes.Visible = false;
            }
            if (origem == "cadastro")
            {
                ucHome1.BringToFront();
            } 
            else if (origem == "emprestimo")
            {
                ucEmprestimos1.BringToFront();
            }
            else if (origem == "perfil")
            {
                ucPerfil1.BringToFront();
            }
            else if (origem == "cliente")
            {
                ucClientes1.BringToFront();
            }
            else if (origem == "reserva")
            {
                ucReservas1.BringToFront();
            }
        }

        private void btEmprestimos_Click(object sender, EventArgs e)
        {
            ucEmprestimos1.BringToFront();
        }

        private void btConfiguracoes_Click(object sender, EventArgs e)
        {
            frmConfiguracoes frmC = new frmConfiguracoes();
            this.Hide();
            frmC.Show();
        }

        private void frmMenuInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resp = MessageBox.Show("Tem certeza de que deseja sair?", "Encerrando programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                frmLogin fl = new frmLogin();
                fl.Show();
            }
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ucHome1.BringToFront();
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btPerfil_Click(object sender, EventArgs e)
        {
            ucPerfil1.BringToFront();
        }

        private void btMultas_Click(object sender, EventArgs e)
        {
            ucMultas1.BringToFront();
        }

        private void btClientes_Click(object sender, EventArgs e)
        {
            ucClientes1.BringToFront();
        }

        private void frmMenuInicial_Load(object sender, EventArgs e)
        {
            string opSexo = "";
            if (usuarioSessaoDTO.sexoUsuario == "m")
            {
                opSexo = "o ";
            }
            else
            {
                opSexo = "a ";
            }

            lblBoaVInda.Text = "Bem vind"+ opSexo + usuarioSessaoDTO.nomeFuncionario;

        }

        private void btReservas_Click(object sender, EventArgs e)
        {
            ucReservas1.BringToFront();
        }

    }
}
