using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Util
{
    public class Utilitario
    {

        //Array que define as Letras Tipo FOO do IValuesh
        private char[] letras_foo = { 'T', 'S', 'W', 'L', 'H' };
        
        //Método que realiza a contagem de preposições
        public int ContarPreposicoes(StreamReader reader)
        {
            string texto = reader.ReadToEnd();
            string[] palavras = texto.Split(' ');

            int total_palavras = palavras.Count();
            int total_preposicao = 0;

            for (int i = 0; i < total_palavras; i++)
            {
                //Verifica se a palavra possui 3 letras
                if (palavras[i].Length == 3)
                {
                    //Verifica se a palavra termina com uma letra do tipo FOO
                    if (letras_foo.Contains(Convert.ToChar(palavras[i].Substring(palavras[i].Length - 1, 1).ToUpper())))
                    {
                        //Verifica se a palavra não possui a letra M
                        if (!palavras[i].ToUpper().Contains('M'))
                        {
                            total_preposicao++;
                        }
                    }
                }
            }

            return total_preposicao;
        }

        //Método que realiza a contagem total de verbos e verbos em primeira pessoa
        public void ContarVerbos(StreamReader reader, out int verbos, out int primeira_pessoa)
        {
            string texto = reader.ReadToEnd();
            string[] palavras = texto.Split(' ');
            
            int total_palavras = palavras.Count();
            verbos = 0;
            primeira_pessoa = 0;

            for (int i = 0; i < total_palavras; i++)
            {
                //Verifica se a palavra possui 8 ou mais letras
                if (palavras[i].Length >= 8)
                {
                    //Verifica se a palavra termina com uma letra tipo FOO
                    if (letras_foo.Contains(Convert.ToChar(palavras[i].Substring(palavras[i].Length - 1, 1).ToUpper())))
                    {
                        verbos++;

                        //Verificar se a palavra começa com uma letra tipo FOO
                        if (letras_foo.Contains(Convert.ToChar(palavras[i].Substring(0, 1).ToUpper())))
                        {
                            primeira_pessoa++;
                        }
                    }
                }
            }

        }

    }
}
