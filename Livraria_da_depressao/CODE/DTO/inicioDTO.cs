using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria_da_depressao.CODE.DTO
{
    class inicioDTO
    {
        // CLIENTE
        private string _idCliente;
        private string _nomeCliente;
        private string _cpfCliente;
        private string _emailCliente;
        private string _celularCliente;
        private string _sexoCliente;
        private string _regularizadoCliente;

        public string idCliente { get { return _idCliente; } set { _idCliente = value; } }
        public string nomeCliente { get { return _nomeCliente; } set { _nomeCliente = value; } }
        public string cpfCliente { get { return _cpfCliente; } set { _cpfCliente = value; } }
        public string emailCliente { get { return _emailCliente; } set { _emailCliente = value; } }
        public string celularCliente { get { return _celularCliente; } set { _celularCliente = value; } }
        public string sexoCliente { get { return _sexoCliente; } set { _sexoCliente = value; } }
        public string regularizadoCliente { get { return _regularizadoCliente; } set { _regularizadoCliente = value; } }



        // EMPRESTIMO
        private string _idEmprestimo;
        private string _dataPedido;
        private string _dataPrevistaEntrega;
        private string _dataEntrega;
        private string _statusEmprestimo;
        private string _idFuncionarioEmprestimo;
        private string _idClienteEmprestimo;
        private string _idLivroEmprestimo;
        private float _totalEmprestimo;

        public string idEmprestimo { get { return _idEmprestimo; } set { _idEmprestimo = value; } }
        public string dataPedido { get { return _dataPedido; } set { _dataPedido = value; } }
        public string dataPrevistaEntrega { get { return _dataPrevistaEntrega; } set { _dataPrevistaEntrega = value; } }
        public string dataEntrega { get { return _dataEntrega; } set { _dataEntrega = value; } }
        public string statusEmprestimo { get { return _statusEmprestimo; } set { _statusEmprestimo = value; } }
        public string idFuncionarioEmprestimo { get { return _idFuncionarioEmprestimo; } set { _idFuncionarioEmprestimo = value; } }
        public string idClienteEmprestimo { get { return _idClienteEmprestimo; } set { _idClienteEmprestimo = value; } }
        public string idLivroEmprestimo { get { return _idLivroEmprestimo; } set { _idLivroEmprestimo = value; } }
        public float totalEmprestimo { get { return _totalEmprestimo; } set { _totalEmprestimo = value; } }



        // RESERVA
        private string _idReserva;
        private string _idLivro;
        private string _nomeLivro;
        private string _dataRetiradaPrevista;
        private string _statusReserva;

        public string idReserva { get { return _idReserva; } set { _idReserva = value; } }
        public string idLivro { get { return _idLivro; } set { _idLivro = value; } }
        public string nomeLivro { get { return _nomeLivro; } set { _nomeLivro = value; } }
        public string dataRetiradaPrevista { get { return _dataRetiradaPrevista; } set { _dataRetiradaPrevista = value; } }
        public string statusReserva { get { return _statusReserva; } set { _statusReserva = value; } }
                  




    }
}
