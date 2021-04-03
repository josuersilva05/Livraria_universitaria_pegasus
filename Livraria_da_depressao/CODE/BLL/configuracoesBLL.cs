using Livraria_da_depressao.CODE.DAL;
using Livraria_da_depressao.CODE.DTO;
using Livraria_da_depressao.FORMS.Configuracoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Livraria_da_depressao.CODE.BLL
{
    class configuracoesBLL
    {
        //////// FUNCIONARIOS
        ///
        public bool cadastrar_funcionario(configuracoesDTO func)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_funcionario(@nome, @cargo, @sexo)";
                cmd.Parameters.AddWithValue("@nome", func.nomeFuncionarioConf);
                cmd.Parameters.AddWithValue("@cargo", func.cargoFuncionarioConf);
                cmd.Parameters.AddWithValue("@sexo", func.sexoFuncionarioConf);
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
        public bool editar_funcionario(configuracoesDTO func)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_funcionario(@id, @nome, @cargo, @sexo)";
                cmd.Parameters.AddWithValue("@id",func.idfuncionario);
                cmd.Parameters.AddWithValue("@nome", func.nomeFuncionarioConf);
                cmd.Parameters.AddWithValue("@cargo", func.cargoFuncionarioConf);
                cmd.Parameters.AddWithValue("@sexo", func.sexoFuncionarioConf);
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
        public bool excluir_funcionario(configuracoesDTO func)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call excluir_funcionario(@id)";
                cmd.Parameters.AddWithValue("@id", func.idfuncionario);
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


        //////// USUARIOS
        ///
        public bool cadastrar_usuario(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_usuario(@id, @usuario, @senha, @permissao)";
                cmd.Parameters.AddWithValue("@id", conf.idUsuarioConf);
                cmd.Parameters.AddWithValue("@usuario", conf.nomeUsuarioConf);
                cmd.Parameters.AddWithValue("@senha", conf.senhaUsuarioConf);
                cmd.Parameters.AddWithValue("@permissao", conf.permissaoUsuarioConf);
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
        public bool editar_usuario(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_usuario_admin(@id, @usuario, @permissao)";
                cmd.Parameters.AddWithValue("@id", conf.idUsuarioConf);
                cmd.Parameters.AddWithValue("@usuario", conf.nomeUsuarioConf);
                cmd.Parameters.AddWithValue("@permissao", conf.permissaoUsuarioConf);
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
        public bool excluir_usuario(configuracoesDTO func)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call excluir_usuario(@id, @usuario)";
                cmd.Parameters.AddWithValue("@id", func.idUsuarioConf);
                cmd.Parameters.AddWithValue("@usuario", func.nomeUsuarioConf);
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

        
        //////// LIVROS
        ///
        public bool cadastrar_livro(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_livro(@idCategoria, @idAutor, @idEditora, @qtd, @nomeLivro, @isbn, @valorLivro)";
                cmd.Parameters.AddWithValue("@idCategoria", conf.idCategoriaConf);
                cmd.Parameters.AddWithValue("@idAutor", conf.idAutorConf);
                cmd.Parameters.AddWithValue("@idEditora", conf.idEditoraConf);
                cmd.Parameters.AddWithValue("@qtd", conf.qtdLivroConf);
                cmd.Parameters.AddWithValue("@nomeLivro", conf.nomeLivroConf);
                cmd.Parameters.AddWithValue("@isbn", conf.isbnLivroConf);
                cmd.Parameters.AddWithValue("@valorLivro", conf.valorLivro);
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
        public bool editar_livro(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_livro(@id, @idCategoria, @idAutor, @idEditora, @qtd, @nomeLivro, @isbn, @valorLivro)";
                cmd.Parameters.AddWithValue("@id", conf.idLivroConf);
                cmd.Parameters.AddWithValue("@idCategoria", conf.idCategoriaConf);
                cmd.Parameters.AddWithValue("@idAutor", conf.idAutorConf);
                cmd.Parameters.AddWithValue("@idEditora", conf.idEditoraConf);
                cmd.Parameters.AddWithValue("@qtd", conf.qtdLivroConf);
                cmd.Parameters.AddWithValue("@nomeLivro", conf.nomeLivroConf);
                cmd.Parameters.AddWithValue("@isbn", conf.isbnLivroConf);
                cmd.Parameters.AddWithValue("@valorLivro", conf.valorLivro);
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
        public bool excluir_livro(configuracoesDTO func)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call excluir_livro(@id)";
                cmd.Parameters.AddWithValue("@id", func.idLivroConf);
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



        //////// AUTORES
        ///
        public bool cadastrar_autor(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_autor(@nome)";
                cmd.Parameters.AddWithValue("@nome", conf.nomeAutorConf);
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
        public bool editar_autor(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_autor(@id, @nome)";
                cmd.Parameters.AddWithValue("@id", conf.idAutorConf);
                cmd.Parameters.AddWithValue("@nome", conf.nomeAutorConf);
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


        
        //////// CATEGORIA
        ///
        public bool cadastrar_categoria(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_categoria(@nome)";
                cmd.Parameters.AddWithValue("@nome", conf.nomeCategoriaConf);
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
        public bool editar_categoria(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_categoria(@id, @nome)";
                cmd.Parameters.AddWithValue("@id", conf.idCategoriaConf);
                cmd.Parameters.AddWithValue("@nome", conf.nomeCategoriaConf);
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


        
        //////// EDITORA
        ///
        public bool cadastrar_editora(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_editora(@nome)";
                cmd.Parameters.AddWithValue("@nome", conf.nomeEditoraConf);
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
        public bool editar_editora(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_editora(@id, @nome)";
                cmd.Parameters.AddWithValue("@id", conf.idEditoraConf);
                cmd.Parameters.AddWithValue("@nome", conf.nomeEditoraConf);
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


        
        //////// MULTAS
        ///
        public bool cadastrar_multa(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call cadastrar_tipo_multa(@nome, @valor)";
                cmd.Parameters.AddWithValue("@nome", conf.nomeMultaConf);
                cmd.Parameters.AddWithValue("@valor", conf.valorMultaConf);
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
        public bool editar_multa(configuracoesDTO conf)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call editar_tipo_multa(@id, @nome, @valor)";
                cmd.Parameters.AddWithValue("@id", conf.idMultaConf);
                cmd.Parameters.AddWithValue("@nome", conf.nomeMultaConf);
                cmd.Parameters.AddWithValue("@valor", conf.valorMultaConf);
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
        public bool excluir_multa(configuracoesDTO func)
        {
            if (Conexao.con.State.ToString() == "Open") { Conexao.con.Close(); }
            try
            {
                bool result = false;
                Conexao.con.Open();
                MySqlCommand cmd = Conexao.con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "call excluir_multa(@id)";
                cmd.Parameters.AddWithValue("@id", func.idMultaConf);
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
        
    }
}
