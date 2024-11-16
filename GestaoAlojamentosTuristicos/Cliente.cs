/**
 * @file Cliente.cs
 * @brief Definição da classe Cliente para gestão de clientes no sistema de alojamentos turísticos.
 * @details Este ficheiro contém a implementação da classe Cliente, que herda de Pessoa e adiciona funcionalidades específicas, como a geração de um ID único para cada cliente.
 * 
 * @author Duarte "macrogod" Pereira
 * @date 13/11/2024
 * @note Este ficheiro faz parte do sistema de Gestão de Alojamentos Turísticos.
 * @todo Adicionar validações específicas para o email e telefone.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    /**
     * @class Cliente
     * @brief Representa um cliente no sistema.
     * @details A classe Cliente herda de Pessoa e adiciona um identificador único gerado automaticamente para cada cliente.
     */
    public class Cliente : Pessoa
    {
        #region Attributes
        /**
         * @brief Contador estático para gerar IDs únicos para os clientes.
         */
        static private int numeroAtualClientes = 0;

        /**
         * @brief Identificador único do cliente.
         */
        private int idCliente;
        #endregion

        #region Constructors
        /**
         * @brief Construtor que inicializa um cliente.
         * @param nome Nome do cliente.
         * @param dataNascimento Data de nascimento do cliente.
         * @param numeroIdentificacao Número de identificação (ex.: BI, NIF, etc.).
         * @param email Email do cliente.
         * @param telefone Número de telefone do cliente.
         * @details Este construtor também atribui um identificador único ao cliente.
         */
        public Cliente(
            string nome,
            DateTime dataNascimento,
            string numeroIdentificacao,
            string email,
            string telefone)
            : base(nome, dataNascimento, numeroIdentificacao, email, telefone)
        {
            idCliente = ++numeroAtualClientes; // Incrementa o contador e define o ID único.
        }
        #endregion

        #region Methods
        /**
         * @brief Obtém o identificador único do cliente.
         * @return O ID do cliente.
         */
        public int GetIdCliente()
        {
            return idCliente;
        }
        #endregion

        #region Overrides
        /**
         * @brief Exibe as informações do cliente no console.
         * @details Este método sobrescreve o método ExibirInformacoes da classe base Pessoa, adicionando o ID do cliente.
         */
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"ID Cliente: {idCliente}");
            base.ExibirInformacoes(); // Chama o método da classe base para exibir informações adicionais.
        }
        #endregion

        #region Destructor
        /**
         * @brief Destrutor da classe Cliente.
         */
        ~Cliente()
        {
        }
        #endregion
    }
}