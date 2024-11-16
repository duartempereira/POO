using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public class GestorClientes
    {
        #region Attributes
        private const int MAX_CLIENTES = 20;
        private Cliente[] clientes; // Array para armazenar clientes
        private int numeroAtualClientes = 0; // Conta o número atual de clientes no array
        #endregion

        #region Constructors
        public GestorClientes()
        {
            // Inicializa o array com o valor da constante
            clientes = new Cliente[MAX_CLIENTES];
        }
        #endregion

        #region Methods
        public int AdicionarCliente(Cliente cliente)
        {
            if (numeroAtualClientes < MAX_CLIENTES)
            {
                clientes[numeroAtualClientes] = cliente;
                numeroAtualClientes++;
                return 0; // Indica que o cliente foi adicionado com sucesso
            }
            else
            {
                return 1; // Indica que o limite de clientes foi atingido
            }
        }

        public Cliente ProcurarCliente(string numeroIdentificacao)
        {
            // Percorre todos os clientes registados
            for (int i = 0; i < numeroAtualClientes; i++)
            {
                // Verifica se o número de identificação do cliente corresponde ao procurado
                if (clientes[i].NumeroIdentificacao == numeroIdentificacao)
                {
                    return clientes[i]; // Retorna o objeto Cliente encontrado
                }
            }

            // Caso não encontre, retorna null
            return null;
        }

        public void MostrarClienteEncontrado(string numeroIdentificacao)
        {
            // Chama o método ProcurarCliente para procurar o cliente
            Cliente clienteEncontrado = ProcurarCliente(numeroIdentificacao);

            // Verifica se o cliente foi encontrado
            if (clienteEncontrado != null)
            {
                // Se o cliente for encontrado, exibe as suas informações
                clienteEncontrado.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("Cliente não encontrado.");
            }
        }

        public void ListarClientes()
        {
            if (numeroAtualClientes == 0)
            {
                Console.WriteLine("Nenhum cliente registado.");
                return;
            }

            Console.WriteLine("Clientes registados:");
            for (int i = 0; i < numeroAtualClientes; i++)
            {
                clientes[i].ExibirInformacoes(); // Chama o método ExibirInformacoes do Cliente
                Console.WriteLine("--------------------------");
            }
        }
        #endregion

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~GestorClientes()
        {
        }
        #endregion
    }
}