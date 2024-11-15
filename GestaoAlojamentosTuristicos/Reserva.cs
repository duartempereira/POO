using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public class Reserva
    {
        #region Attributes
        private static int numeroAtualReservas = 0; // Gera IDs únicos para as reservas
        private int idReserva;
        private DateTime dataInicio;
        private DateTime dataFim;
        private Cliente cliente;
        private Alojamento alojamentoReservado;
        private decimal precoTotal;
        #endregion

        #region Constructors
        public Reserva(DateTime dataInicio, DateTime dataFim, Cliente cliente, Alojamento alojamentoReservado)
        {
            idReserva = ++numeroAtualReservas; // Gera um ID único para cada reserva
            DataInicio = dataInicio;
            DataFim = dataFim;
            Cliente = cliente;
            AlojamentoReservado = alojamentoReservado;
            PrecoTotal = CalcularPrecoTotal();
        }
        #endregion

        #region Methods
        public decimal CalcularPrecoTotal()
        {
            int numeroNoites = (dataFim - dataInicio).Days;
            return numeroNoites * alojamentoReservado.PrecoPorNoite;
        }

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
        }
        #endregion

        #region Properties
        public int IdReserva
        {
            get { return idReserva; }
            set { idReserva = value; }
        }

        public DateTime DataInicio
        {
            get { return dataInicio; }
            set { dataInicio = value; }
        }

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }

        public Alojamento AlojamentoReservado
        {
            get { return alojamentoReservado; }
            set { alojamentoReservado = value; }
        }

        public decimal PrecoTotal
        {
            get { return precoTotal; }
            set { precoTotal = value; }
        }
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        #endregion
    }
}