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
            // Criando o gestor de clientes
            GestorClientes gestorClientes = new GestorClientes();

            // Adicionando clientes ao sistema (exemplo)
            gestorClientes.AdicionarCliente(new Cliente("Duarte Pereira", new DateTime(2003, 11, 12), "271234567", "+351 938123456", "duarte.pereira@gmail.com"));
            gestorClientes.AdicionarCliente(new Cliente("Maria Silva", new DateTime(1990, 5, 15), "111234567", "+351 912345678", "maria.silva@email.com"));

            gestorClientes.ListarClientes();

            // Definir o número de identificação manualmente
            string numeroIdentificacao = "111234567";  // Exemplo de número de identificação

            // Usando o método MostraClienteEncontrado para buscar e mostrar o cliente
            gestorClientes.MostrarClienteEncontrado(numeroIdentificacao);

            // Pausa o programa para ver o resultado na consola
            Console.ReadLine();
        }
    }
}