/**
 * @file Program.cs
 * @brief Implementação do programa principal para a gestão de clientes, alojamentos e reservas.
 * @details Este ficheiro contém a lógica principal da aplicação de gestão de alojamentos turísticos. Ele inicializa os gestores de clientes, alojamentos e reservas, e executa uma série de operações como adicionar clientes e alojamentos, listar dados, e criar reservas.
 * 
 * @author Duarte "macrogod" Pereira
 * @date 10/11/2024
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
     * @class Program
     * @brief Contém o método principal que executa a lógica do sistema.
     * @details Esta classe gere a execução do programa. Inicializa os gestores de clientes, alojamentos e reservas, realiza operações como a adição de dados, listagem e procura de clientes e alojamentos, e criação de reservas.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Inicializar os gestores de Clientes, Alojamentos e Reservas
            GestorClientes gestorClientes = new GestorClientes();
            GestorAlojamentos gestorAlojamentos = new GestorAlojamentos();
            GestorReservas gestorReservas = new GestorReservas();

            // 2. Adicionar Clientes
            gestorClientes.AdicionarCliente(new Cliente("Duarte Pereira", new DateTime(2003, 11, 12), "271234567", "+351 938123456", "duarte.pereira@gmail.com"));
            gestorClientes.AdicionarCliente(new Cliente("Joana Barbosa", new DateTime(2002, 5, 19), "111234567", "+351 912345678", "joana.barbosa@gmail.com"));

            // 3. Adicionar Alojamentos
            gestorAlojamentos.AdicionarAlojamento(new Alojamento("Hotel Barcelos", 75.50m, "Barcelos", Tipo.Casa));
            gestorAlojamentos.AdicionarAlojamento(new Alojamento("Hostel Porto", 50.00m, "Porto", Tipo.Hostel));

            // 4. Listar todos os Clientes
            Console.WriteLine("\n--- Lista de Clientes ---");
            gestorClientes.ListarClientes();

            // 5. Procurar e Exibir Cliente por Número de Identificação
            string numeroIdentificacao = "271234567";  // Exemplo de número de identificação
            Console.WriteLine($"\n--- Procurar Cliente com Número de Identificação: {numeroIdentificacao} ---");
            gestorClientes.MostrarClienteEncontrado(numeroIdentificacao);

            // 6. Procurar e Exibir Alojamento por ID
            int idAlojamento = 1;  // Exemplo de ID de alojamento
            Console.WriteLine($"\n--- Procurar Alojamento com ID: {idAlojamento} ---");
            gestorAlojamentos.MostrarAlojamentoEncontrado(idAlojamento);

            // 7. Listar todos os Alojamentos
            Console.WriteLine("\n--- Lista de Alojamentos ---");
            gestorAlojamentos.ListarAlojamentos();

            // 8. Criando uma Reserva
            Cliente clienteReserva = gestorClientes.ProcurarCliente("271234567");  // Cliente para a reserva
            Alojamento alojamentoReserva = gestorAlojamentos.ProcurarAlojamento(idAlojamento);  // Alojamento para a reserva
            Reserva novaReserva = new Reserva(new DateTime(2024, 12, 20), new DateTime(2024, 12, 25), clienteReserva, alojamentoReserva); 
            gestorReservas.AdicionarReserva(novaReserva);  // Adicionando a reserva

            // 9. Listar todas as Reservas
            Console.WriteLine("\n--- Lista de Reservas ---");
            gestorReservas.ListarReservas();

            // 10. Procurar e Exibir Reserva por ID Cliente e ID Alojamento
            Console.WriteLine($"\n--- Procurar Reserva para Cliente ID: 1 e Alojamento ID: {idAlojamento} ---");
            gestorReservas.MostrarReservaEncontrada(1, idAlojamento);

            // 11. Pausar o programa para ver o resultado na consola
            Console.WriteLine("\nPressiona qualquer tecla para finalizar...");
            Console.ReadKey();
        }
    }
}