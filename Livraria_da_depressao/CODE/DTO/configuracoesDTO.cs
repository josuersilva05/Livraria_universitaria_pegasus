using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_da_depressao.CODE.DTO
{
    class configuracoesDTO
    {
        // FUNCIONARIOS
        private string _idFuncionarioConf;
        private string _nomeFuncionarioConf;
        private string _cargoFuncionarioConf;
        private char _sexoFuncionarioConf;

        public string idfuncionario { get { return _idFuncionarioConf; } set { _idFuncionarioConf = value; } }
        public string nomeFuncionarioConf { get { return _nomeFuncionarioConf; } set { _nomeFuncionarioConf = value; } }
        public string cargoFuncionarioConf { get { return _cargoFuncionarioConf; } set { _cargoFuncionarioConf = value; } }
        public char sexoFuncionarioConf { get { return _sexoFuncionarioConf; } set { _sexoFuncionarioConf = value; } }


        // USUÁRIOS
        private string _idUsuarioConf;
        private string _nomeUsuarioConf;
        private string _senhaUsuarioConf;
        private string _permissaoUsuarioConf;

        public string idUsuarioConf { get { return _idUsuarioConf; } set { _idUsuarioConf = value; } }
        public string nomeUsuarioConf { get { return _nomeUsuarioConf; } set { _nomeUsuarioConf = value; } }
        public string senhaUsuarioConf { get { return _senhaUsuarioConf; } set { _senhaUsuarioConf = value; } }
        public string permissaoUsuarioConf { get { return _permissaoUsuarioConf; } set { _permissaoUsuarioConf = value; } }


        // AUTOR
        private string _idAutorConf;
        private string _nomeAutorConf;

        public string idAutorConf { get { return _idAutorConf; } set { _idAutorConf = value; } }
        public string nomeAutorConf { get { return _nomeAutorConf; } set { _nomeAutorConf = value; } }


        // CATEGORIA
        private string _idCategoriaConf;
        private string _nomeCategoriaConf;

        public string idCategoriaConf { get { return _idCategoriaConf; } set { _idCategoriaConf = value; } }
        public string nomeCategoriaConf { get { return _nomeCategoriaConf; } set { _nomeCategoriaConf = value; } }


        // EDITORA
        private string _idEditoraConf;
        private string _nomeEditoraConf;

        public string idEditoraConf { get { return _idEditoraConf; } set { _idEditoraConf = value; } }
        public string nomeEditoraConf { get { return _nomeEditoraConf; } set { _nomeEditoraConf = value; } }


        // LIVRO
        private string _idLivroConf;
        private string _nomeLivroConf;
        private string _isbnLivroConf;
        private string _qtdLivroConf;
        private string _valorLivro;

        public string idLivroConf { get { return _idLivroConf; } set { _idLivroConf = value; } }
        public string nomeLivroConf { get { return _nomeLivroConf; } set { _nomeLivroConf = value; } }
        public string isbnLivroConf { get { return _isbnLivroConf; } set { _isbnLivroConf = value; } }
        public string qtdLivroConf { get { return _qtdLivroConf; } set { _qtdLivroConf = value; } }
        public string valorLivro { get { return _valorLivro; } set { _valorLivro = value; } }


        // MULTA
        private string _idMultaConf;
        private string _nomeMultaConf;
        private double _valorMultaConf;

        public string idMultaConf { get { return _idMultaConf; } set { _idMultaConf = value; } }
        public string nomeMultaConf { get { return _nomeMultaConf; } set { _nomeMultaConf = value; } }
        public double valorMultaConf { get { return _valorMultaConf; } set { _valorMultaConf = value; } }
    }
}
