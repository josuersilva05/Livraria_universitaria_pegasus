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
using Livraria_da_depressao.CODE.BLL;
using Livraria_da_depressao.CODE.DTO;

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class ucGerUsuarios : UserControl
    {
        public ucGerUsuarios()
        {
            InitializeComponent();
        }
        private void ucGerUsuarios_Load(object sender, EventArgs e)
        {
            carregar_usuarios();
        }
        private void carregar_usuarios()
        {
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_usuarios";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                dgvUsuarios.Rows.Add(row[0].ToString(), row[3], row[1], row[4], row[2]);
            }
        }

        private void btNovoUsuario_Click(object sender, EventArgs e)
        {

            ((Form)this.TopLevelControl).Hide();
            frmUsuarioConf fu = new frmUsuarioConf();
            fu.Show();
        }
        private void btEditarUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Cells[0].Value != null) {
                var aviso = "Por uma questão de acessibilidade de todos os usuários, pedimos que ao alterar um nome de usuário o respectivo deve ser avisado sobre a alteração.";
                MessageBox.Show(aviso, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                List<string> campos = new List<string>();
                campos.Add(dgvUsuarios.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvUsuarios.CurrentRow.Cells[1].Value.ToString());
                campos.Add(dgvUsuarios.CurrentRow.Cells[2].Value.ToString());
                campos.Add(dgvUsuarios.CurrentRow.Cells[3].Value.ToString());
                campos.Add(dgvUsuarios.CurrentRow.Cells[4].Value.ToString());

                ((Form)this.TopLevelControl).Hide();
                frmUsuarioConf fu = new frmUsuarioConf(campos, "editar");
                fu.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para editar.");
            }
        }
        private void btExcluirUsuario_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow.Cells[0].Value != null) {
                DialogResult resp = MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    bool status = false;
                    configuracoesBLL confbll = new configuracoesBLL();
                    configuracoesDTO confdto = new configuracoesDTO();
                    confdto.idUsuarioConf = dgvUsuarios.CurrentRow.Cells[0].Value.ToString();
                    confdto.nomeUsuarioConf = dgvUsuarios.CurrentRow.Cells[2].Value.ToString();
                    status = confbll.excluir_usuario(confdto);
                    if (status == true)
                    {
                        MessageBox.Show("Registro excluido com sucesso!");
                        dgvUsuarios.Rows.Clear();
                        carregar_usuarios();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um registro para excluir.");
            }
        }
    }
}
