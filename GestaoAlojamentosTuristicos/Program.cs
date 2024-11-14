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
            // Cria uma instância de GestorAlojamentos
            GestorAlojamentos gestorAlojamentos = new GestorAlojamentos();

            // Adicionando clientes ao sistema (exemplo)
            gestorClientes.AdicionarCliente(new Cliente("Duarte Pereira", new DateTime(2003, 11, 12), "271234567", "+351 938123456", "duarte.pereira@gmail.com"));
            gestorClientes.AdicionarCliente(new Cliente("Joana Barbosa", new DateTime(2002, 5, 19), "111234567", "+351 912345678", "joana.barbosa@gmail.com"));

            // Adicionando alojamentos ao sistema (exemplo)
            gestorAlojamentos.AdicionarAlojamento(new Alojamento("Hotel Barcelos", 75.50m, "Barcelos", Tipo.Casa));

            // Mostrar a lista de clientes
            gestorClientes.ListarClientes();

            // Definir o número de identificação do cliente manualmente
            string numeroIdentificacao = "111234567";  // Exemplo de número de identificação
            // Usando o método MostraClienteEncontrado para procurar e mostrar o cliente
            gestorClientes.MostrarClienteEncontrado(numeroIdentificacao);

            int idAlojamento = 1;
            gestorAlojamentos.MostrarAlojamentoEncontrado(idAlojamento);

            gestorAlojamentos.ListarAlojamentos();

            // Pausa o programa para ver o resultado na consola
            Console.ReadLine();
        }
    }
}