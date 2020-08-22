using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_da_depressao.CODE.DTO
{
    class usuarioSessaoDTO
    {
        private static int _idUsuario;
        private static string _usuario;
        private static string _nomeFuncionario;
        private static string _cargoUsuario;
        private static string _sexoUsuario;
        private static string _permissaoUsuario;

        public static int idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public static string usuario { get { return _usuario; } set { _usuario = value;  } }
        public static string nomeFuncionario { get { return _nomeFuncionario; } set { _nomeFuncionario = value; } }
        public static string cargoUsuario { get { return _cargoUsuario; } set { _cargoUsuario = value; } }
        public static string sexoUsuario { get { return _sexoUsuario; } set { _sexoUsuario = value; } }
        public static string permissaoUsuario { get { return _permissaoUsuario; } set { _permissaoUsuario = value; } }



        private string _novoUsuario;
        private string _novoNomeFunc;
        private string _novoSexo;
        private string _novaSenha;

        public string novoUsuario { get { return _novoUsuario; } set { _novoUsuario = value; } }
        public string novoNomeFunc { get { return _novoNomeFunc; } set { _novoNomeFunc = value; } }
        public string novoSexo { get { return _novoSexo; } set { _novoSexo = value; } }
        public string novaSenha { get { return _novaSenha; } set { _novaSenha = value; } }

    }
}
