using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public enum Tipo
    {
        Apartamento,
        Casa,
        Quarto,
        Hotel,
        Hostel
    }

    public class Alojamento
    {
        #region Attributes
        private int idAlojamento;
        private string nome;
        private decimal precoPorNoite;
        private string localizacao;
        private Tipo tipo;  // Tipo agora é do tipo enum
        private static int numeroAtualAlojamentos = 0; // Atributo estático para controlar o próximo ID
        #endregion

        #region Constructors
        public Alojamento(
            string nome,
            decimal precoPorNoite,
            string localizacao,
            Tipo tipo)
        {
            // Atribuição do ID único (incrementando o contador estático)
            IdAlojamento = ++numeroAtualAlojamentos;  // Incrementa o contador e atribui o ID
            Nome = nome;
            PrecoPorNoite = precoPorNoite;
            Localizacao = localizacao;
            Tipo = tipo;
        }
        #endregion

        #region Properties
        public int IdAlojamento
        {
            get { return idAlojamento; }
            set { idAlojamento = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public decimal PrecoPorNoite
        {
            get { return precoPorNoite; }
            set { precoPorNoite = value; }
        }
        public string Localizacao
        {
            get { return localizacao; }
            set { localizacao = value; }
        }
        public Tipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        #endregion

        #region Overrides
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine();  // Adiciona uma linha em branco para separar as informações de outros alojamentos
            Console.WriteLine("Informações do Alojamento:");
            Console.WriteLine($"ID Alojamento: {IdAlojamento}");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço por Noite: {PrecoPorNoite} EUR");
            Console.WriteLine($"Localização: {Localizacao}");
            Console.WriteLine($"Tipo: {Tipo}");
        }
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~Alojamento()
        {
        }
        #endregion
    }
}