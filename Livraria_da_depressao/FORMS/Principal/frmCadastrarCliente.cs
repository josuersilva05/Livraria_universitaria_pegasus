using Livraria_da_depressao.CODE.BLL;
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

namespace Livraria_da_depressao.FORMS.Principal
{
    public partial class frmCadastrarCliente : Form
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
            cboClienteRegularizado.SelectedIndex = 1;
            cboSexoCliente.SelectedIndex = 0;
        }

        private void frmCadastrarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial mi = new frmMenuInicial("cadastro");
            mi.Show();
        }

        private void btConfirmarCadastro_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja cadastrar este cliente?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                string csexo = cboSexoCliente.Text.Substring(0, 1).ToLower();

                inicioDTO idto = new inicioDTO();
                idto.nomeCliente = txtNomeCliente.Text;
                idto.cpfCliente = txtCpfCliente.Text;
                idto.emailCliente = txtEmailCliente.Text;
                idto.celularCliente = txtCelularCliente.Text;
                if (cboClienteRegularizado.Text == "Regularizado")
                {
                    idto.regularizadoCliente = "regularizado";
                }
                else { 
                    idto.regularizadoCliente = "nao_regularizado";
                }
                idto.sexoCliente = csexo;

                inicioBLL ibll = new inicioBLL();
                result = ibll.cadastrar_cliente(idto);
                if (result == true)
                {
                    MessageBox.Show("Cliente Cadastrado!", "Resultado", MessageBoxButtons.OK);
                }
                this.Close();
            }
        }
    }
}
