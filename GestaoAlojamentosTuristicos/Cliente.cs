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
        static private int numeroAtualClientes = 0;

        private int idCliente;
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
            idCliente = ++numeroAtualClientes;
        }
        #endregion

        #region Methods
        // Método para retornar o ID do Cliente
        public int GetIdCliente()
        {
            return idCliente;
        }
        #endregion

        #region Properties
        #endregion

        #region Overrides
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"ID Cliente: {idCliente}");

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