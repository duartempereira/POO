using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public class GestorReservas
    {
        #region Attributes
        private const int MAX_RESERVAS = 100; // Limite de reservas
        private Reserva[] reservas; // Array para armazenar as reservas
        private int numeroAtualReservas = 0; // Contador de reservas no array
        #endregion

        #region Constructors
        public GestorReservas()
        {
            reservas = new Reserva[MAX_RESERVAS]; // Inicializa o array de reservas
        }
        #endregion

        #region Methods
        public int AdicionarReserva(Reserva reserva)
        {
            if (numeroAtualReservas < MAX_RESERVAS)
            {
                reservas[numeroAtualReservas] = reserva; // Adiciona a reserva ao array
                numeroAtualReservas++; // Incrementa o contador
                return 0; // Reserva adicionada com sucesso
            }
            else
            {
                return 1; // Limite de reservas atingido
            }
        }

        public Reserva ProcurarReserva(int idCliente, int idAlojamento)
        {
            for (int i = 0; i < numeroAtualReservas; i++)
            {
                // Usar os métodos GetIdCliente() e acessar Alojamento para obter o ID
                if (reservas[i].Cliente.GetIdCliente() == idCliente && reservas[i].AlojamentoReservado.IdAlojamento == idAlojamento)
                {
                    return reservas[i]; // Retorna a reserva encontrada
                }
            }
            return null; // Retorna null caso não encontre a reserva
        }

        public void MostrarReservaEncontrada(int idCliente, int idAlojamento)
        {
            // Chama o método ProcurarReserva para procurar a reserva
            Reserva reservaEncontrada = ProcurarReserva(idCliente, idAlojamento);

            // Verifica se a reserva foi encontrada
            if (reservaEncontrada != null)
            {
                // Se a reserva for encontrada, exibe as suas informações
                reservaEncontrada.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("Reserva não encontrada.");
            }
        }

        public bool VerificarDisponibilidade(int idAlojamento, DateTime dataInicio, DateTime dataFim)
        {
            // Itera por todas as reservas
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
                    reservas[i].ExibirInformacoes(); // Exibe informações da reserva
                    Console.WriteLine("--------------------------");
                }
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
        ~GestorReservas()
        {
        }
        #endregion
    }
}