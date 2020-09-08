using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematica
{
    class Matematica
    {
        public int Parcela1 { get; set; }
        public int Parcela2 { get; set; }

        public string Operacoes { get; set; }

        public Matematica(int parcela1, int parcela2, string operacoes)
        {
            Parcela1 = parcela1;
            Parcela2 = parcela2;
            Operacoes = operacoes;
        }

        public int Resultados()
        {
            int resultado;
            switch (Operacoes)
            {
                case "soma":
                    resultado = Parcela1 + Parcela2;
                    break;
                case "subtracao":
                    resultado = Parcela1 - Parcela2;
                    break;
                case "divisao":
                    resultado = Parcela1 / Parcela2;
                    break;
                case "multiplicacao":
                    resultado = Parcela1 * Parcela2;
                    break;
                default:
                    resultado = -1000;
                    break;
            }
                    return resultado;
            
        }
    }
}
