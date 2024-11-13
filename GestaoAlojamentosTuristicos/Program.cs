using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criação de um Cliente
            Cliente cliente = new Cliente(
                "Duarte Pereira",
                new DateTime(2003, 11, 12), // Data de nascimento
                "271234567",
                "+351 938123456",
                "duarte.pereira@email.com"
            );

            // Mostrar as informações do Cliente
            cliente.ExibirInformacoes();

            // Pausa o programa para ver o resultado na consola
            Console.ReadLine();
        }
    }
}