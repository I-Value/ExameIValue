using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IValuesh.Dicionario
{
    public class Leitor
    {
        private const string LetrasFoo = "tswlh";

        public static List<Palavra> Ler(string Texto)
        {
            List<Palavra> Retorno = new List<Palavra>();

            foreach (string Palavra in Texto.Split(' '))
            {
                List<Letra> Letras = new List<Letra>();

                foreach (char Caracter in Palavra)
                {
                    if (LetrasFoo.Contains(Caracter))
                    {
                        Letras.Add(new Foo(Caracter));
                    }
                    else
                    {
                        Letras.Add(new Bar(Caracter));
                    }
                }

                Retorno.Add(Interpretador.Interpretar(Letras));
            }

            return Retorno;
        }
    }
}
