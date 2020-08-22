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
    public partial class frmCliente : Form
    {
        public List<string> vCampos;
        public frmCliente()
        {
            InitializeComponent();
        }

        public frmCliente(List<string> campos)
        {
            InitializeComponent();
            vCampos = campos;
            setarValores();

        }

        private void setarValores()
        {
            txtIdCliente.Text = vCampos[0];
            txtNomeCliente.Text = vCampos[1];
            txtCpfCliente.Text = vCampos[2];
            txtEmailCliente.Text = vCampos[3];
            txtCelularCliente.Text = vCampos[5];
            for (int i=0; i<3; i++)
            {
                if (vCampos[4] == cboStatusCliente.Items[i].ToString()) 
                {
                    cboStatusCliente.SelectedIndex = i;
                    break;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                if (vCampos[6] == cboSexoCliente.Items[i].ToString().Substring(0, 1))
                {
                    cboSexoCliente.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btAtualizarCliente_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Deseja atualizar este registro?","Atualizar",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                bool result = false;
                inicioDTO idto = new inicioDTO();
                idto.idCliente = txtIdCliente.Text;
                idto.nomeCliente = txtNomeCliente.Text;
                idto.cpfCliente = txtCpfCliente.Text;
                idto.emailCliente = txtEmailCliente.Text;
                idto.celularCliente = txtCelularCliente.Text;
                if (cboStatusCliente.Text == "Regularizado")
                    idto.regularizadoCliente = "regularizado";
                else
                    idto.regularizadoCliente = "nao_regularizado";
                idto.sexoCliente = cboSexoCliente.Text.Substring(0, 1).ToLower();
                inicioBLL ibll = new inicioBLL();
                result = ibll.editar_cliente(idto);
                if (result == true)
                    MessageBox.Show("Registro atualizado.");
                else
                    MessageBox.Show("Não foi possível atualizar o registro.");
                this.Close();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMenuInicial mi = new frmMenuInicial("cliente");
            mi.Show();
        }
    }
}
