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
using Livraria_da_depressao.CODE.DTO;
using System.Collections;
using Livraria_da_depressao.CODE.BLL;

namespace Livraria_da_depressao.FORMS.Configuracoes
{
    public partial class ucGerFuncionarios : UserControl
    {
        public ucGerFuncionarios()
        {
            InitializeComponent();
        }

        private void btNovoFuncionario_Click(object sender, EventArgs e)
        {
            ((Form)this.TopLevelControl).Hide();
            frmFuncionarioConf fu = new frmFuncionarioConf();
            fu.Show();
        }

        private void ucGerFuncionarios_Load(object sender, EventArgs e)
        {
            carregarRegistros();
        }

        private void carregarRegistros()
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            Conexao.con.Open();
            MySqlCommand cmd = Conexao.con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "call carregar_funcionarios";
            cmd.ExecuteNonQuery();

            Conexao.con.Close();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            //dgvFuncionarios.DataSource = dt;
            foreach (DataRow row in dt.Rows)
            {
                string sexo;
                if (row[3].ToString() == "m")
                {
                    sexo = "Masculino";
                }
                else if (row[3].ToString() == "f")
                {
                    sexo = "Feminino";
                }
                else
                {
                    sexo = "Indefinido";
                }
                dgvFuncionarios.Rows.Add(row[0].ToString(), row[1].ToString(), row[2].ToString(), sexo);
            }

            Conexao.con.Close();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentRow.Cells[0].Value != null) {
                List<string> campos = new List<string>();
                campos.Add(dgvFuncionarios.CurrentRow.Cells[0].Value.ToString());
                campos.Add(dgvFuncionarios.CurrentRow.Cells[1].Value.ToString());
                campos.Add(dgvFuncionarios.CurrentRow.Cells[2].Value.ToString());
                var sexo = dgvFuncionarios.CurrentRow.Cells[3].Value.ToString().Substring(0, 1);
                campos.Add(sexo.ToLower());
                ((Form)this.TopLevelControl).Hide();
                frmFuncionarioConf ff = new frmFuncionarioConf(campos, "editar");
                ff.Show();
            }
            else
            {
                MessageBox.Show("Escolha um registro para editar.");
            }
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            if (dgvFuncionarios.CurrentRow.Cells[0].Value != null) {
                DialogResult resp = MessageBox.Show("Deseja realmente excluir este registro?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (resp == System.Windows.Forms.DialogResult.Yes)
                {
                    bool status = false;
                    configuracoesBLL confbll = new configuracoesBLL();
                    configuracoesDTO confdto = new configuracoesDTO();
                    confdto.idfuncionario = dgvFuncionarios.CurrentRow.Cells[0].Value.ToString();
                    status = confbll.excluir_funcionario(confdto);
                    if (status == true)
                    {
                        MessageBox.Show("Registro excluido com sucesso!");
                        dgvFuncionarios.Rows.Clear();
                        carregarRegistros();
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
