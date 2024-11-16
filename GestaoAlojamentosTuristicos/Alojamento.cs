/**
 * @file Alojamento.cs
 * @brief Definição da classe Alojamento e enums relacionados para gestão de alojamentos turísticos.
 * @details Este ficheiro contém a implementação da classe Alojamento, que representa um alojamento turístico com atributos como nome, preço, localização, tipo e estado. Também inclui enums para os tipos e estados dos alojamentos.
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
     * @enum Tipo
     * @brief Enumeração que define os tipos de alojamento.
     */
    public enum Tipo
    {
        Apartamento, /**< Representa um apartamento. */
        Casa,        /**< Representa uma casa. */
        Quarto,      /**< Representa um quarto. */
        Hotel,       /**< Representa um hotel. */
        Hostel       /**< Representa um hostel. */
    }

    /**
     * @enum EstadoAlojamento
     * @brief Enumeração que define os estados possíveis de um alojamento.
     */
    public enum EstadoAlojamento
    {
        Disponivel, /**< O alojamento está disponível. */
        Ocupado     /**< O alojamento está ocupado. */
    }

    /**
     * @class Alojamento
     * @brief Representa um alojamento turístico com diversas informações.
     * @details Esta classe inclui atributos como nome, preço por noite, localização, tipo e estado do alojamento.
     */
    public class Alojamento
    {
        #region Attributes
        /**
         * @brief ID único do alojamento.
         */
        private int idAlojamento;

        /**
         * @brief Nome do alojamento.
         */
        private string nome;

        /**
         * @brief Preço por noite do alojamento.
         */
        private decimal precoPorNoite;

        /**
         * @brief Localização do alojamento.
         */
        private string localizacao;

        /**
         * @brief Tipo do alojamento (definido pelo enum Tipo).
         */
        private Tipo tipo;

        /**
         * @brief Estado do alojamento (definido pelo enum EstadoAlojamento).
         */
        private EstadoAlojamento estado;

        /**
         * @brief Contador estático para atribuir IDs únicos aos alojamentos.
         */
        private static int numeroAtualAlojamentos = 0;
        #endregion

        #region Constructors
        /**
         * @brief Construtor que inicializa um novo alojamento.
         * @param nome Nome do alojamento.
         * @param precoPorNoite Preço por noite do alojamento.
         * @param localizacao Localização do alojamento.
         * @param tipo Tipo do alojamento.
         */
        public Alojamento(
            string nome,
            decimal precoPorNoite,
            string localizacao,
            Tipo tipo)
        {
            IdAlojamento = ++numeroAtualAlojamentos;  // Incrementa o contador e atribui o ID
            Nome = nome;
            PrecoPorNoite = precoPorNoite;
            Localizacao = localizacao;
            Tipo = tipo;
        }
        #endregion

        #region Properties
        /**
         * @brief Obtém ou define o ID do alojamento.
         */
        public int IdAlojamento
        {
            get { return idAlojamento; }
            set { idAlojamento = value; }
        }

        /**
         * @brief Obtém ou define o nome do alojamento.
         */
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        /**
         * @brief Obtém ou define o preço por noite do alojamento.
         */
        public decimal PrecoPorNoite
        {
            get { return precoPorNoite; }
            set { precoPorNoite = value; }
        }

        /**
         * @brief Obtém ou define a localização do alojamento.
         */
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }

        /**
         * @brief Obtém ou define o tipo do alojamento.
         */
        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        /**
         * @brief Obtém ou define o estado do alojamento.
         */
        public EstadoAlojamento Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        #endregion

        #region Overrides
        /**
         * @brief Exibe informações detalhadas do alojamento na consola.
         */
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine();  // Adiciona uma linha em branco para separar as informações de outros alojamentos
            Console.WriteLine("Informações do Alojamento:");
            Console.WriteLine($"ID Alojamento: {IdAlojamento}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço por Noite: {PrecoPorNoite} EUR");
            Console.WriteLine($"Localização: {Localizacao}");
            Console.WriteLine($"Tipo: {Tipo}");
            Console.WriteLine($"Estado: {Estado}"); // Mostrar estado
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        /**
         * @brief Destrutor da classe Alojamento.
         */
        ~Alojamento()
        {
        }
        #endregion
    }
}