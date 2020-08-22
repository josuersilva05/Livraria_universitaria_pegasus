using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.DTO;
using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria_da_depressao.CODE.BLL
{
    class LoginBLL
    {
        int i;
        public bool verifica_login(LoginDTO log)
        {
            try
            {
                i = 0;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call verifica_login(@usuario, @senha)";
                cmd.Parameters.AddWithValue("@usuario", log.nomeUsuario);
                cmd.Parameters.AddWithValue("@senha", log.senha);
                cmd.ExecuteNonQuery();
                Conexao.con.Close();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    return false;
                }
                else
                {
                    foreach(DataRow row in dt.Rows)
                    {
                        usuarioSessaoDTO.idUsuario = Convert.ToInt32(row[0].ToString());
                        usuarioSessaoDTO.permissaoUsuario = row[1].ToString();
                        usuarioSessaoDTO.nomeFuncionario = row[2].ToString();
                        usuarioSessaoDTO.cargoUsuario = row[3].ToString();
                        usuarioSessaoDTO.sexoUsuario = row[4].ToString();
                        usuarioSessaoDTO.usuario = log.nomeUsuario;
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao verificar login. "+ex.Message);
                return false;
            }
        }

        public bool atualizar_perfil(usuarioSessaoDTO sdto)
        {
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_perfil(@id, @usuarioAtual, @nomeFuncionario, @sexo, @usuarioNovo)";
                cmd.Parameters.AddWithValue("@id", usuarioSessaoDTO.idUsuario);
                cmd.Parameters.AddWithValue("@usuarioAtual", usuarioSessaoDTO.usuario);
                cmd.Parameters.AddWithValue("@nomeFuncionario", sdto.novoNomeFunc);
                cmd.Parameters.AddWithValue("@sexo", sdto.novoSexo);
                cmd.Parameters.AddWithValue("@usuarioNovo", sdto.novoUsuario);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    usuarioSessaoDTO.usuario = sdto.novoUsuario;
                    usuarioSessaoDTO.sexoUsuario = sdto.novoSexo;
                    usuarioSessaoDTO.nomeFuncionario = sdto.novoNomeFunc;
                    Conexao.con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar registro. " + ex.Message);
                Conexao.con.Close();
                return false;
            }
        }

        public bool verifica_senha(usuarioSessaoDTO sdto)
        {
            try
            {
                int i = 0;
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call verifica_senha(@id, @usuario, @novaSenha)";
                cmd.Parameters.AddWithValue("@id", usuarioSessaoDTO.idUsuario);
                cmd.Parameters.AddWithValue("@usuario", usuarioSessaoDTO.usuario);
                cmd.Parameters.AddWithValue("@novaSenha", sdto.novaSenha);
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                i = Convert.ToInt32(dt.Rows.Count.ToString());
                if (i == 0)
                {
                    Conexao.con.Close();
                    return false;
                }
                else
                {
                    result = true;
                }
                Conexao.con.Close();
                return result;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nâo foi possível buscar o registro: "+ex.Message);
                Conexao.con.Close();
                return false;
            }
        }


        public bool alterar_senha(usuarioSessaoDTO sdto)
        {
            try
            {
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call alterar_senha(@id, @usuario, @novaSenha)";
                cmd.Parameters.AddWithValue("@id", usuarioSessaoDTO.idUsuario);
                cmd.Parameters.AddWithValue("@usuario", usuarioSessaoDTO.usuario);
                cmd.Parameters.AddWithValue("@novaSenha", sdto.novaSenha);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    Conexao.con.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                Conexao.con.Close();
                return false;
            }
        }

    }


}
