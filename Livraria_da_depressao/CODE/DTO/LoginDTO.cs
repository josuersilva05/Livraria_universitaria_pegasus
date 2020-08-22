using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_da_depressao.CODE.DTO
{
    class LoginDTO
    {
        private string _nomeUsuario;
        private string _senha;

        public string nomeUsuario { get { return _nomeUsuario; } set { _nomeUsuario = value; } }
        public string senha { get { return _senha; } set { _senha = value; } }
    }
}
