/**
 * @file GestorClientes.cs
 * @brief Definição da classe GestorClientes para gestão de clientes no sistema de alojamentos turísticos.
 * @details Este ficheiro contém a implementação da classe GestorClientes, responsável por gerir os clientes, permitindo adicionar, procurar, e listar clientes no sistema.
 * 
 * @author Duarte "macrogod" Pereira
 * @date 13/11/2024
 * @note Este ficheiro faz parte do sistema de Gestão de Alojamentos Turísticos.
 * @todo Utilizar listas ao invés de arrays fixos para melhorar a flexibilidade.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    /**
     * @class GestorClientes
     * @brief Representa o gestor de clientes no sistema.
     * @details A classe GestorClientes é responsável por gerir os clientes, permitindo adicionar, procurar, listar clientes e exibir as suas informações no sistema de alojamentos turísticos.
     */
    public class GestorClientes
    {
        #region Attributes
        /**
         * @brief Número máximo de clientes que o sistema pode armazenar.
         */
        private const int MAX_CLIENTES = 20;

        /**
         * @brief Array que armazena os clientes registados.
         */
        private Cliente[] clientes;

        /**
         * @brief Contador do número atual de clientes no sistema.
         */
        private int numeroAtualClientes = 0;
        #endregion

        #region Constructors
        /**
         * @brief Construtor que inicializa o gestor de clientes com um array vazio.
         * @details Inicializa um array de clientes com o tamanho máximo definido por MAX_CLIENTES.
         */
        public GestorClientes()
        {
            clientes = new Cliente[MAX_CLIENTES];
        }
        #endregion

        #region Methods
        /**
         * @brief Adiciona um novo cliente ao sistema.
         * @param cliente O objeto Cliente que será adicionado.
         * @return Um valor inteiro que indica o sucesso da operação: 0 se o cliente for adicionado com sucesso, 1 se o limite de clientes for atingido.
         */
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

        /**
         * @brief Procura um cliente no sistema pelo seu número de identificação.
         * @param numeroIdentificacao O número de identificação do cliente a ser procurado.
         * @return O objeto Cliente correspondente ao número de identificação fornecido, ou null se o cliente não for encontrado.
         */
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

        /**
         * @brief Exibe as informações de um cliente procurado pelo seu número de identificação.
         * @param numeroIdentificacao O número de identificação do cliente a ser exibido.
         * @details Chama o método ProcurarCliente para procurar o cliente e, caso encontrado, exibe as suas informações.
         */
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

        /**
         * @brief Lista todos os clientes registados no sistema.
         * @details Exibe as informações de todos os clientes registados, caso existam. Caso contrário, exibe uma mensagem informando que não há clientes registados.
         */
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

        #region Destructor
        /**
         * @brief Destrutor da classe GestorClientes.
         */
        ~GestorClientes()
        {
        }
        #endregion
    }
}