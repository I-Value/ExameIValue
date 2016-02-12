using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IValuesh.Dicionario
{
    public static class InterpretadorUtil
    {
        public static bool IsPreposicao(this List<Letra> Letras)
        {
            return
                Letras.Count == 3
                && Letras.Count(l => l.Valor.Equals('m')) == 0
                && Letras.Last() is Foo;
        }

        public static bool IsVerbo(this List<Letra> Letras)
        {
            return
                Letras.Count >= 8
                && Letras.Last() is Foo;
        }

        public static bool IsPrimeiraPessoa(this Verbo pVerbo)
        {
            return
                pVerbo.Letras.First() is Foo;
        }
    }
}
