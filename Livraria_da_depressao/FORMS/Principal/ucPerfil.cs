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
using Livraria_da_depressao.CODE.DTO;
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DAL;

namespace Livraria_da_depressao.FORMS
{
    public partial class ucPerfil : UserControl
    {
        public ucPerfil()
        {
            InitializeComponent();
            cboSexo.SelectedIndex = 0;
        }

        private void lblAlterarDados_Click(object sender, EventArgs e)
        {
            txtNomeFuncionario.Enabled = true;
            txtNomeUsuario.Enabled = true;
            cboSexo.Enabled = true;
            lblCancelar.Visible = true;
            btSalvarAlteracoesPerfil.Visible = true;
        }

        private void lblAlterarSenha_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmAlterarSenha alts = new frmAlterarSenha();
            alts.Show();
        }

        private void ucPerfil_Load(object sender, EventArgs e)
        {
            setarCampos();
        }

        private void lblCancelar_Click(object sender, EventArgs e)
        {
            desabilitarCampos();
            setarCampos();
        }

        private void setarCampos()
        {
            string nomeFoto;
            lblNomeUsuario.Text = "Bem vindo " + usuarioSessaoDTO.nomeFuncionario;
            txtNomeFuncionario.Text = usuarioSessaoDTO.nomeFuncionario;
            txtNomeUsuario.Text = usuarioSessaoDTO.usuario;
            txtCargo.Text = usuarioSessaoDTO.cargoUsuario;

            if (usuarioSessaoDTO.sexoUsuario == "m")
            {
                cboSexo.SelectedIndex = 0;
                nomeFoto = "homem.jpg";
            }
            else if (usuarioSessaoDTO.sexoUsuario == "f")
            {
                cboSexo.SelectedIndex = 1;
                nomeFoto = "mulher.jpg";
            }
            else
            {
                cboSexo.SelectedIndex = 2;
                nomeFoto = "indefinido.jpg";
            }
            //@"C:/Users/josue/source/repos/Livraria_da_depressao/Livraria_da_depressao/IMG/" + nomeFoto
            //Image foto = Image.FromFile(@"C:/Users/Casa/source/repos/Livraria_da_depressao/Livraria_da_depressao/IMG/" + nomeFoto);
            ArquivosDeSistema file = new ArquivosDeSistema();
            Console.Write(file.ImagesDirectory);
            
            Image foto = Image.FromFile(file.ImagesDirectory + "/" + nomeFoto);
            pcbFotoPerfil.Image = foto;
            pcbFotoPerfil.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void desabilitarCampos()
        {
            txtNomeFuncionario.Enabled = false;
            txtNomeUsuario.Enabled = false;
            cboSexo.Enabled = false;
            lblCancelar.Visible = false;
            btSalvarAlteracoesPerfil.Visible = false;
        }

        private void btSalvarAlteracoesPerfil_Click(object sender, EventArgs e)
        {
            bool result = false;
            DialogResult resp = MessageBox.Show("Deseja mesmo atualizar estes dados?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resp == System.Windows.Forms.DialogResult.Yes)
            {
                usuarioSessaoDTO sdto = new usuarioSessaoDTO();
                sdto.novoNomeFunc = txtNomeFuncionario.Text;
                sdto.novoUsuario = txtNomeUsuario.Text;
                sdto.novoSexo = cboSexo.Text.Substring(0, 1).ToLower();

                LoginBLL lbll = new LoginBLL();
                result = lbll.atualizar_perfil(sdto);
                if (result == true)
                {
                    MessageBox.Show("Alterações salvas!");
                    desabilitarCampos();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar os dados. Por favor contate o responsável pelo sistema.");
                }
            }
        }
    }
}
