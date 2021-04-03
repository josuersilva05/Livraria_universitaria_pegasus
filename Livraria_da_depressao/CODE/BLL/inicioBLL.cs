using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.DTO;
using MySql.Data.MySqlClient;

namespace Livraria_da_depressao.CODE.BLL
{
    class inicioBLL
    {
        //////// CLIENTE
        ///
        public bool cadastrar_cliente(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_cliente(@nome, @cpf, @email, @celular, @status, @sexo)";
                cmd.Parameters.AddWithValue("@nome", cli.nomeCliente);
                cmd.Parameters.AddWithValue("@cpf", cli.cpfCliente);
                cmd.Parameters.AddWithValue("@email", cli.emailCliente);
                cmd.Parameters.AddWithValue("@celular", cli.celularCliente);
                cmd.Parameters.AddWithValue("@sexo", cli.sexoCliente);
                cmd.Parameters.AddWithValue("@status", cli.regularizadoCliente);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }
        public bool editar_cliente(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_cliente(@id, @nome, @cpf, @email, @celular, @status, @sexo)";
                cmd.Parameters.AddWithValue("@id", cli.idCliente);
                cmd.Parameters.AddWithValue("@nome", cli.nomeCliente);
                cmd.Parameters.AddWithValue("@cpf", cli.cpfCliente);
                cmd.Parameters.AddWithValue("@email", cli.emailCliente);
                cmd.Parameters.AddWithValue("@celular", cli.celularCliente);
                cmd.Parameters.AddWithValue("@status", cli.regularizadoCliente);
                cmd.Parameters.AddWithValue("@sexo", cli.sexoCliente);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }
        public bool excluir_cliente(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call excluir_cliente(@id)";
                cmd.Parameters.AddWithValue("@id", cli.idCliente);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível excluir o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }

        //////// EMPRESTIMO
        ///
        public bool cadastrar_emprestimo(inicioDTO emp)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_emprestimo(@entrega, @idFuncionario, @idCliente, @idLivro, @valorEmprestimo)";
                cmd.Parameters.AddWithValue("@entrega", emp.dataPrevistaEntrega);
                cmd.Parameters.AddWithValue("@idFuncionario", emp.idFuncionarioEmprestimo);
                cmd.Parameters.AddWithValue("@idCliente", emp.idClienteEmprestimo);
                cmd.Parameters.AddWithValue("@idLivro", emp.idLivroEmprestimo);
                cmd.Parameters.AddWithValue("@valorEmprestimo", emp.totalEmprestimo);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível inserir o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }
        public bool editar_emprestimo(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_cliente(@id, @nome, @cpf, @email, @celular, @sexo, @status)";
                cmd.Parameters.AddWithValue("@id", cli.idCliente);
                cmd.Parameters.AddWithValue("@nome", cli.nomeCliente);
                cmd.Parameters.AddWithValue("@cpf", cli.cpfCliente);
                cmd.Parameters.AddWithValue("@email", cli.emailCliente);
                cmd.Parameters.AddWithValue("@celular", cli.celularCliente);
                cmd.Parameters.AddWithValue("@sexo", cli.sexoCliente);
                cmd.Parameters.AddWithValue("@status", cli.regularizadoCliente);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }
        public bool atualizar_status_emprestimo(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call atualizar_emprestimo(@id, @dataEntrega, @status)";
                cmd.Parameters.AddWithValue("@id", cli.idEmprestimo);
                cmd.Parameters.AddWithValue("@dataEntrega", cli.dataEntrega);
                cmd.Parameters.AddWithValue("@status", cli.statusEmprestimo);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }
        public bool atualizar_multa_paga(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call atualizar_multa_emprestimo_paga(@id)";
                cmd.Parameters.AddWithValue("@id", cli.idEmprestimo);
                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar o registro: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }
        public string pesquisar_multa_emprestimo(inicioDTO cli)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call carregar_emprestimo_multa(@id)";
                cmd.Parameters.AddWithValue("@id", cli.idEmprestimo);
                cmd.ExecuteNonQuery();
                Conexao.con.Close();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                string multa = "";

                foreach (DataRow row in dt.Rows)
                {
                    multa = row[0].ToString();
                }
                return multa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar o registro: "+ex.Message);
                return "";
            }
        }


        //////// RESERVA
        ///
        public bool cadastrar_reserva(inicioDTO idto)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand msc = Conexao.con.CreateCommand();
                msc.CommandType = CommandType.Text;
                msc.CommandText = "call cadastrar_reserva(@idCliente, @idFuncionario, @idLivro, @idEmprestimo, @retiradaPrevista)";
                msc.Parameters.AddWithValue("@idCliente", idto.idCliente);
                msc.Parameters.AddWithValue("@idFuncionario", usuarioSessaoDTO.idUsuario);
                msc.Parameters.AddWithValue("@idLivro", idto.idLivro);
                msc.Parameters.AddWithValue("@idEmprestimo", idto.idEmprestimo);
                msc.Parameters.AddWithValue("@retiradaPrevista", idto.dataRetiradaPrevista);
                if(msc.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }

                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível cadastrar a reserva: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }

        public bool editar_reserva(inicioDTO idto)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand msc = Conexao.con.CreateCommand();
                msc.CommandType = CommandType.Text;
                msc.CommandText = "call atualizar_reserva(@idReserva, @status, @dataRetiradaPrevista)";
                msc.Parameters.AddWithValue("@idReserva", idto.idReserva);
                msc.Parameters.AddWithValue("@status", idto.statusReserva.ToLower());
                msc.Parameters.AddWithValue("@dataRetiradaPrevista", idto.dataRetiradaPrevista);
                if (msc.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                    result = true;
                }
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível atualizar a reserva: " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }

        public List<string> pesquisar_idClienteLivroReserva(string id)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                List<string> lst = new List<string>();
                Conexao.con.Open();
                MySqlCommand msc = Conexao.con.CreateCommand();
                msc.CommandType = CommandType.Text;
                msc.CommandText = "call pesquisar_idClienteLivro(@idReserva)";
                msc.Parameters.AddWithValue("@idReserva", id);
                var resp = msc.ExecuteReader();

                if (resp.HasRows)
                {
                    Conexao.con.Close();
                    DataTable dt = new DataTable();
                    MySqlDataAdapter da = new MySqlDataAdapter(msc);
                    da.Fill(dt);

                    foreach (DataRow row in dt.Rows)
                    {
                        lst.Add(row[0].ToString());
                        lst.Add(row[1].ToString());
                    }
                }
                return lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível pesquisar os ID's:" + ex.Message);
                Conexao.con.Close();
                return null;
            }
        }
    }
}
