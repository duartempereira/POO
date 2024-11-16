/**
 * @file GestorAlojamentos.cs
 * @brief Definição da classe GestorAlojamentos para gestão de alojamentos no sistema de alojamentos turísticos.
 * @details Este ficheiro contém a implementação da classe GestorAlojamentos, responsável por gerir os alojamentos, incluindo funcionalidades como adicionar, procurar, e listar alojamentos.
 * 
 * @author Duarte "macrogod" Pereira
 * @date 14/11/2024
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
     * @class GestorAlojamentos
     * @brief Representa o gestor de alojamentos no sistema.
     * @details A classe GestorAlojamentos é responsável por gerir os alojamentos, permitindo adicionar, procurar e listar os alojamentos disponíveis no sistema.
     */
    public class GestorAlojamentos
    {
        #region Attributes
        /**
         * @brief Número máximo de alojamentos que o sistema pode armazenar.
         */
        private const int MAX_ALOJAMENTOS = 20;

        /**
         * @brief Array que armazena os alojamentos registados.
         */
        private Alojamento[] alojamentos;

        /**
         * @brief Contador do número atual de alojamentos no sistema.
         */
        private int numeroAtualAlojamentos = 0;
        #endregion

        #region Constructors
        /**
         * @brief Construtor que inicializa o gestor de alojamentos com um array vazio.
         * @details Inicializa um array de alojamentos com o tamanho máximo definido por MAX_ALOJAMENTOS.
         */
        public GestorAlojamentos()
        {
            alojamentos = new Alojamento[MAX_ALOJAMENTOS];
        }
        #endregion

        #region Methods
        /**
         * @brief Adiciona um novo alojamento ao sistema.
         * @param alojamento O objeto Alojamento que será adicionado.
         * @return Um valor inteiro que indica o sucesso da operação: 0 se o alojamento for adicionado com sucesso, 1 se o limite de alojamentos for atingido.
         */
        public int AdicionarAlojamento(Alojamento alojamento)
        {
            if (numeroAtualAlojamentos < MAX_ALOJAMENTOS)
            {
                alojamentos[numeroAtualAlojamentos] = alojamento;
                numeroAtualAlojamentos++;
                return 0; // Indica que o alojamento foi adicionado com sucesso
            }
            else
            {
                return 1; // Indica que o limite de alojamentos foi atingido
            }
        }

        /**
         * @brief Procura um alojamento no sistema pelo seu ID.
         * @param idAlojamento O ID do alojamento que se deseja procurar.
         * @return O objeto Alojamento correspondente ao ID fornecido, ou null se o alojamento não for encontrado.
         */
        public Alojamento ProcurarAlojamento(int idAlojamento)
        {
            // Percorre todos os alojamentos registados
            for (int i = 0; i < numeroAtualAlojamentos; i++)
            {
                // Verifica se o número de identificação do alojamento corresponde ao procurado
                if (alojamentos[i].IdAlojamento == idAlojamento)
                {
                    return alojamentos[i]; // Retorna o objeto Alojamento encontrado
                }
            }

            // Caso não encontre, retorna null
            return null;
        }

        /**
         * @brief Exibe as informações de um alojamento procurado pelo seu ID.
         * @param idAlojamento O ID do alojamento a ser exibido.
         * @details Chama o método ProcurarAlojamento para procurar o alojamento e, caso encontrado, exibe as suas informações.
         */
        public void MostrarAlojamentoEncontrado(int idAlojamento)
        {
            // Chama o método ProcurarAlojamento para procurar o alojamento
            Alojamento alojamentoEncontrado = ProcurarAlojamento(idAlojamento);

            // Verifica se o alojamento foi encontrado
            if (alojamentoEncontrado != null)
            {
                // Se o alojamento for encontrado, exibe as suas informações
                alojamentoEncontrado.ExibirInformacoes();
            }
            else
            {
                Console.WriteLine("Alojamento não encontrado.");
            }
        }

        /**
         * @brief Lista todos os alojamentos registados no sistema.
         * @details Exibe as informações de todos os alojamentos, se houver algum registado. Caso contrário, informa que não há alojamentos disponíveis.
         */
        public void ListarAlojamentos()
        {
            if (numeroAtualAlojamentos == 0)
            {
                Console.WriteLine("Não há alojamentos registados.");
            }
            else
            {
                Console.WriteLine("\nLista de Alojamentos:");
                for (int i = 0; i < numeroAtualAlojamentos; i++)
                {
                    alojamentos[i].ExibirInformacoes();
                    Console.WriteLine("--------------------------");
                }
            }
        }
        #endregion

        #region Destructor
        /**
         * @brief Destrutor da classe GestorAlojamentos.
         */
        ~GestorAlojamentos()
        {
        }
        #endregion
    }
}