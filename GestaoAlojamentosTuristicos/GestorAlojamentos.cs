using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoAlojamentosTuristicos
{
    public class GestorAlojamentos
    {
        #region Attributes
        private const int MAX_ALOJAMENTOS = 20;
        private Alojamento[] alojamentos; // Array para armazenar alojamentos
        private int numeroAtualAlojamentos = 0; // Conta o número atual de alojamentos no array
        #endregion

        #region Constructors
        public GestorAlojamentos()
        {
            alojamentos = new Alojamento[MAX_ALOJAMENTOS];
        }
        #endregion

        #region Methods
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

        #region Properties
        #endregion

        #region Overrides
        #endregion

        #region OtherMethods
        #endregion

        #region Destructor
        ~GestorAlojamentos()
        {
        }
        #endregion
    }
}