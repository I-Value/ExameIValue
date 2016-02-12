using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IValuesh.Dicionario
{
    public class Palavra
    {
        public Palavra(List<Letra> pLetras)
        {
            Letras = pLetras;
        }

        public List<Letra> Letras { get; set; }
    }
}
