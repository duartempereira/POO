using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public class Cliente : Pessoa
    {
        #region Attributes
        static private int contadorClientes = 0;

        private int numeroCliente;
        #endregion

        #region Constructors
        public Cliente(
            string nome,
            DateTime dataNascimento,
            string numeroIdentificacao,
            string email,
            string telefone)
            : base(nome, dataNascimento, numeroIdentificacao, email, telefone)
        {
            numeroCliente = ++contadorClientes;
        }
        #endregion

        #region Methods
        #endregion

        #region Properties

        #endregion

        #region Overrides
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Numero do cliente: {numeroCliente}");

            base.ExibirInformacoes();
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Cliente()
        {
        }
        #endregion
    }
}