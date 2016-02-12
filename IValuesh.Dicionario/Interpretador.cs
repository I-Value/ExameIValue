using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IValuesh.Dicionario
{
    public class Interpretador
    {
        public static Palavra Interpretar(List<Letra> Letras)
        {
            if (Letras.IsPreposicao())
            {
                return new Preposicao(Letras);
            }
            else if (Letras.IsVerbo())
            {
                return new Verbo(Letras);
            }
            else
            {
                return new Palavra(Letras);
            }
        }
    }
}
