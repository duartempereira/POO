/**
 * @file Pessoa.cs
 * @brief Definição da classe Pessoa para representar informações pessoais.
 * @details Este ficheiro contém a implementação da classe Pessoa, que armazena informações sobre uma pessoa, como nome, data de nascimento, identificação, telefone e email. Inclui também métodos para calcular a idade e exibir informações.
 * 
 * @author Duarte "macrogod" Pereira
 * @date 13/11/2024
 * @note Este ficheiro faz parte do sistema de Gestão de Alojamentos Turísticos.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    /**
     * @class Pessoa
     * @brief Representa uma pessoa com dados pessoais.
     * @details A classe Pessoa contém informações como nome, data de nascimento, número de identificação, telefone e e-mail. Além disso, tem métodos para calcular a idade da pessoa e exibir os dados.
     */
    public class Pessoa
    {
        #region Attributes
        /**
         * @brief Nome da pessoa.
         */
        private string nome;

        /**
         * @brief Data de nascimento da pessoa.
         */
        private DateTime dataNascimento;

        /**
         * @brief Número de identificação da pessoa.
         */
        private string numeroIdentificacao;

        /**
         * @brief Telefone da pessoa.
         */
        private string telefone;

        /**
         * @brief E-mail da pessoa.
         */
        private string email;
        #endregion

        #region Constructors
        /**
         * @brief Construtor da classe Pessoa.
         * @param nome O nome da pessoa.
         * @param dataNascimento A data de nascimento da pessoa.
         * @param numeroIdentificacao O número de identificação da pessoa.
         * @param telefone O número de telefone da pessoa.
         * @param email O e-mail da pessoa.
         * @details Este construtor inicializa a classe Pessoa com os valores fornecidos para nome, data de nascimento, número de identificação, telefone e e-mail.
         */
        public Pessoa(
            string nome,
            DateTime dataNascimento,
            string numeroIdentificacao,
            string telefone,
            string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            NumeroIdentificacao = numeroIdentificacao;
            Telefone = telefone;
            Email = email;
        }
        #endregion

        #region Methods
        #endregion

        #region Properties
        /**
         * @brief Propriedade para acessar o nome da pessoa.
         * @return O nome da pessoa.
         */
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /**
         * @brief Propriedade para acessar a data de nascimento da pessoa.
         * @return A data de nascimento da pessoa.
         */
        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        /**
         * @brief Propriedade para acessar o número de identificação da pessoa.
         * @return O número de identificação da pessoa.
         */
        public string NumeroIdentificacao
        {
            get { return numeroIdentificacao; }
            set { numeroIdentificacao = value; }
        }

        /**
         * @brief Propriedade para acessar o telefone da pessoa.
         * @return O telefone da pessoa.
         */
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        /**
         * @brief Propriedade para acessar o e-mail da pessoa.
         * @return O e-mail da pessoa.
         */
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        #endregion

        #region Overrides
        /**
         * @brief Exibe as informações completas da pessoa.
         * @details Este método exibe o nome, data de nascimento, idade, número de identificação, telefone e e-mail da pessoa.
         * A idade é calculada utilizando o método CalcularIdade().
         */
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Data de Nascimento: {DataNascimento.ToShortDateString()}");
            Console.WriteLine($"Idade: {CalcularIdade()} anos");
            Console.WriteLine($"Nº Identificação: {NumeroIdentificacao}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"Email: {Email}");
        }
        #endregion

        #region OtherMethods
        /**
         * @brief Calcula a idade da pessoa com base na data de nascimento.
         * @return A idade da pessoa em anos.
         * @details Este método calcula a idade considerando se a pessoa já fez aniversário no ano atual.
         */
        public int CalcularIdade()
        {
            DateTime hoje = DateTime.Today;  // Data de hoje
            int idade = hoje.Year - DataNascimento.Year;  // Subtrai os anos

            // Verifica se a pessoa já fez aniversário este ano
            if (hoje.Month < DataNascimento.Month || (hoje.Month == DataNascimento.Month && hoje.Day < DataNascimento.Day))
            {
                idade--;  // Se ainda não fez aniversário, subtrai 1
            }

            return idade;
        }
        #endregion

        #region Destructor
        /**
         * @brief Destrutor da classe Pessoa.
         * @details Este destrutor é utilizado para limpar recursos quando a instância da classe Pessoa for destruída.
         */
        ~Pessoa()
        {
        }
        #endregion
    }
}