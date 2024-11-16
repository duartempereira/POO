/**
 * @file Reserva.cs
 * @brief Representa uma reserva feita por um cliente para um alojamento.
 * @details Esta classe armazena informações sobre uma reserva, incluindo o cliente, o alojamento, as datas de início e fim, o preço total, e o cálculo do número de noites. Ela também é responsável por gerar um ID único para cada reserva.
 *  
 * @author Duarte "macrogod" Pereira
 * @date 13/11/2024
 * @note Esta classe faz parte do sistema de Gestão de Alojamentos Turísticos.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    /**
     * @class Reserva
     * @brief Representa uma reserva de alojamento feita por um cliente.
     * @details Esta classe contém informações detalhadas sobre uma reserva, incluindo a data de início e fim da estadia, o cliente que fez a reserva, o alojamento reservado e o preço total da reserva. A classe também calcula o preço total com base no número de noites e no preço por noite do alojamento reservado.
     */
    public class Reserva
    {
        #region Attributes
        private static int numeroAtualReservas = 0; ///< Gera IDs únicos para as reservas.
        private int idReserva; ///< ID único da reserva.
        private DateTime dataInicio; ///< Data de início da reserva.
        private DateTime dataFim; ///< Data de fim da reserva.
        private Cliente cliente; ///< Cliente que fez a reserva.
        private Alojamento alojamentoReservado; ///< Alojamento reservado.
        private decimal precoTotal; ///< Preço total da reserva.
        #endregion

        #region Constructors
        /**
         * @brief Construtor para a criação de uma nova reserva.
         * @details Este construtor inicializa os dados da reserva, incluindo o ID único, as datas de início e fim, o cliente, o alojamento reservado e calcula o preço total da reserva.
         * 
         * @param dataInicio Data de início da reserva.
         * @param dataFim Data de fim da reserva.
         * @param cliente Cliente que está a fazer a reserva.
         * @param alojamentoReservado Alojamento que está a ser reservado.
         */
        public Reserva(DateTime dataInicio, DateTime dataFim, Cliente cliente, Alojamento alojamentoReservado)
        {
            idReserva = ++numeroAtualReservas; // Gera um ID único para cada reserva.
            DataInicio = dataInicio;
            DataFim = dataFim;
            Cliente = cliente;
            AlojamentoReservado = alojamentoReservado;
            PrecoTotal = CalcularPrecoTotal(); // Calcula o preço total da reserva.
        }
        #endregion

        #region Methods
        /**
         * @brief Calcula o preço total da reserva com base nas noites de estadia.
         * @details Este método calcula o preço total multiplicando o número de noites pela tarifa diária do alojamento.
         * 
         * @return O preço total da reserva em formato decimal.
         */
        public decimal CalcularPrecoTotal()
        {
            int numeroNoites = (dataFim - dataInicio).Days; // Calcula o número de noites.
            return numeroNoites * alojamentoReservado.PrecoPorNoite; // Retorna o preço total.
        }

        /**
         * @brief Exibe as informações detalhadas sobre a reserva.
         * @details Este método imprime no console as informações da reserva, incluindo o ID da reserva, nome do cliente, nome do alojamento, datas de início e fim, preço total, e número de dias de estadia.
         */
        public void ExibirInformacoes()
        {
            Console.WriteLine();
            Console.WriteLine("Informações da Reserva:");
            Console.WriteLine($"ID Reserva: {idReserva}");
            Console.WriteLine($"Cliente: {cliente.Nome}");
            Console.WriteLine($"Alojamento: {alojamentoReservado.Nome}");
            Console.WriteLine($"Data de Início: {dataInicio:dd/MM/yyyy}");
            Console.WriteLine($"Data de Fim: {dataFim:dd/MM/yyyy}");
            Console.WriteLine($"Preço Total: {precoTotal:C}");
            Console.WriteLine($"Número de Dias: {NumeroDiasEstadia}");
        }
        #endregion

        #region Properties
        /**
         * @brief Obtém ou define o ID da reserva.
         * @details O ID da reserva é gerado automaticamente e não pode ser alterado manualmente.
         */
        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        /**
         * @brief Obtém ou define a data de início da reserva.
         * @details A data de início é usada para calcular o número de noites e o preço total.
         */
        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        /**
         * @brief Obtém ou define a data de fim da reserva.
         * @details A data de fim é usada para calcular o número de noites e o preço total.
         */
        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        /**
         * @brief Obtém ou define o cliente da reserva.
         * @details O cliente é a pessoa que fez a reserva.
         */
        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        /**
         * @brief Obtém ou define o alojamento reservado.
         * @details O alojamento é o espaço turístico que o cliente escolheu para a sua estadia.
         */
        public Alojamento AlojamentoReservado
        {
            get { return alojamentoReservado; }
            set { alojamentoReservado = value; }
        }

        /**
         * @brief Obtém ou define o preço total da reserva.
         * @details O preço total é calculado com base na quantidade de noites e no preço por noite do alojamento.
         */
        public decimal PrecoTotal
        {
            get { return precoTotal; }
            set { precoTotal = value; }
        }

        /**
         * @brief Obtém o número de dias de estadia.
         * @details Esta propriedade calcula e retorna a diferença entre a data de fim e a data de início.
         */
        public int NumeroDiasEstadia
        {
            get
            {
                return (DataFim - DataInicio).Days; // Calcula a diferença em dias.
            }
        }
        #endregion

        #region Destructor
        /**
         * @brief Destrutor da classe Reserva.
         * @details Método chamado quando a instância de Reserva é destruída.
         */
        ~Reserva()
        {
        }
        #endregion
    }
}