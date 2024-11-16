/**
 * @file GestorReservas.cs
 * @brief Definição da classe GestorReservas para gestão de reservas no sistema de alojamentos turísticos.
 * @details Este ficheiro contém a implementação da classe GestorReservas, responsável por gerir as reservas, permitindo adicionar, procurar, verificar disponibilidade e listar as reservas feitas pelos clientes.
 * 
 * @author Duarte "macrogod" Pereira
 * @date 15/11/2024
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
     * @class GestorReservas
     * @brief Representa o gestor de reservas no sistema.
     * @details A classe GestorReservas é responsável por gerir as reservas dos clientes, permitindo adicionar, procurar, verificar a disponibilidade de alojamentos e listar todas as reservas realizadas.
     */
    public class GestorReservas
    {
        #region Attributes
        /**
         * @brief Número máximo de reservas que o sistema pode armazenar.
         */
        private const int MAX_RESERVAS = 100;

        /**
         * @brief Array para armazenar as reservas feitas pelos clientes.
         */
        private Reserva[] reservas;

        /**
         * @brief Contador do número atual de reservas no sistema.
         */
        private int numeroAtualReservas = 0;
        #endregion

        #region Constructors
        /**
         * @brief Construtor que inicializa o gestor de reservas com um array vazio.
         * @details Inicializa um array de reservas com o tamanho máximo definido por MAX_RESERVAS.
         */
        public GestorReservas()
        {
            reservas = new Reserva[MAX_RESERVAS];
        }
        #endregion

        #region Methods
        /**
         * @brief Adiciona uma nova reserva ao sistema.
         * @param reserva A reserva a ser adicionada.
         * @return Um valor inteiro que indica o sucesso da operação: 0 se a reserva for adicionada com sucesso, 1 se o limite de reservas for atingido.
         */
        public int AdicionarReserva(Reserva reserva)
        {
            if (numeroAtualReservas < MAX_RESERVAS)
            {
                reservas[numeroAtualReservas] = reserva;
                numeroAtualReservas++;
                return 0; // Reserva adicionada com sucesso
            }
            else
            {
                return 1; // Limite de reservas atingido
            }
        }

        /**
         * @brief Procura uma reserva no sistema, dado o ID do cliente e o ID do alojamento.
         * @param idCliente O ID do cliente que fez a reserva.
         * @param idAlojamento O ID do alojamento reservado.
         * @return O objeto Reserva correspondente ao cliente e alojamento fornecidos, ou null caso não encontre a reserva.
         */
        public Reserva ProcurarReserva(int idCliente, int idAlojamento)
        {
            for (int i = 0; i < numeroAtualReservas; i++)
            {
                // Verifica se a reserva corresponde ao ID do cliente e ID do alojamento
                if (reservas[i].Cliente.GetIdCliente() == idCliente && reservas[i].AlojamentoReservado.IdAlojamento == idAlojamento)
                {
                    return reservas[i]; // Retorna a reserva encontrada
                }
            }
            return null; // Retorna null caso não encontre a reserva
        }

        /**
         * @brief Exibe as informações de uma reserva encontrada.
         * @param idCliente O ID do cliente que fez a reserva.
         * @param idAlojamento O ID do alojamento reservado.
         * @details Chama o método ProcurarReserva para procurar a reserva, e, caso encontrada, exibe as suas informações.
         */
        public void MostrarReservaEncontrada(int idCliente, int idAlojamento)
        {
            // Chama o método ProcurarReserva para procurar a reserva
            Reserva reservaEncontrada = ProcurarReserva(idCliente, idAlojamento);

            // Verifica se a reserva foi encontrada
            if (reservaEncontrada != null)
            {
                // Exibe as informações da reserva encontrada
                reservaEncontrada.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }

        /**
         * @brief Verifica a disponibilidade de um alojamento para um intervalo de datas.
         * @param idAlojamento O ID do alojamento a ser verificado.
         * @param dataInicio A data de início da reserva desejada.
         * @param dataFim A data de fim da reserva desejada.
         * @return Um valor booleano que indica se o alojamento está disponível: true se estiver disponível, false se já estiver reservado.
         */
        public bool VerificarDisponibilidade(int idAlojamento, DateTime dataInicio, DateTime dataFim)
        {
            // Itera por todas as reservas existentes
            for (int i = 0; i < numeroAtualReservas; i++)
            {
                Reserva reserva = reservas[i];

                // Verifica se o alojamento corresponde ao ID fornecido
                if (reserva.AlojamentoReservado.IdAlojamento == idAlojamento)
                {
                    // Verifica se existe sobreposição de datas
                    if (dataInicio < reserva.DataFim && dataFim > reserva.DataInicio)
                    {
                        return false; // Não disponível
                    }
                }
            }
            return true; // Disponível
        }

        /**
         * @brief Lista todas as reservas registadas no sistema.
         * @details Exibe as informações de todas as reservas registadas, caso existam. Caso contrário, exibe uma mensagem informando que não há reservas registadas.
         */
        public void ListarReservas()
        {
            if (numeroAtualReservas == 0)
            {
                Console.WriteLine("Não há reservas registadas.");
            }
            else
            {
                Console.WriteLine("\nLista de Reservas:");
                for (int i = 0; i < numeroAtualReservas; i++)
                {
                    reservas[i].ExibirInformacoes(); // Exibe informações de cada reserva
                    Console.WriteLine("--------------------------");
                }
            }
        }
        #endregion

        #region Destructor
        /**
         * @brief Destrutor da classe GestorReservas.
         */
        ~GestorReservas()
        {
        }
        #endregion
    }
}