using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Teste
{
    class Program
    {
        # region Constants / Variaveis

        const string _ARQUIVO_TEXTO = "textoB.txt";
        const string _LETRAS_FOO = "t,s,w,l,h";

        # endregion

        # region Main

        static void Main(string[] args)
        {
            int countPreposicao = 0;
            int countVerbo = 0;
            int countVerboPrimeiraPessoa = 0;

            foreach (string palavra in LerPalavrasTexto(_ARQUIVO_TEXTO))
            {
                if (IsPreposicao(palavra))
                {
                    countPreposicao++;
                }

                if (IsVerbo(palavra))
                {
                    countVerbo++;

                    if (isVerboPrimeiraPessoa(palavra))
                    {
                        countVerboPrimeiraPessoa++;
                    }
                }                
            }

            Console.WriteLine("Total de preposições : " + countPreposicao.ToString());
            Console.WriteLine("Total de verbos : " + countVerbo.ToString());
            Console.WriteLine("Total de verbos em primeira pessoa : " + countVerboPrimeiraPessoa.ToString());
            Console.ReadKey();
        }

        # endregion

        # region Ler texto

        /// <summary>
        /// Retorna as palavras do texto.
        /// </summary>
        /// <param name="url"></param>
        /// <returns></returns>
        private static List<string> LerPalavrasTexto(string arquivo)
        {
            List<string> listPalavras = new List<string>();

            System.IO.StreamReader texto = new System.IO.StreamReader(arquivo);
            string linha = "";
            while (true)
            {
                linha = texto.ReadLine();
                if (linha != null)
                {
                    listPalavras.AddRange(CarregarListString(linha, ' '));
                }
                else
                {
                    break;
                }
            }

            return listPalavras;
        }

        # endregion

        # region Processa texto

        /// <summary>
        /// Verifica se é preposição
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        private static bool IsPreposicao(string palavra)
        {
            if (palavra.Length.Equals(3) && palavra.ToLower().IndexOf("m").Equals(-1))
            {
                foreach (string s in CarregarListString(_LETRAS_FOO, ','))
                {
                    if (palavra.ToLower().EndsWith(s))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }            
        }

        /// <summary>
        /// Verifica se é verbo.
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        private static bool IsVerbo(string palavra)
        {
            if (palavra.Length >= 8)
            {
                foreach (string s in CarregarListString(_LETRAS_FOO, ','))
                {
                    if (palavra.ToLower().EndsWith(s))
                    {
                        return true;
                    }
                }

                return false;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Verifica se o verbo é primeira pessoa.
        /// </summary>
        /// <param name="palavra"></param>
        /// <returns></returns>
        private static bool isVerboPrimeiraPessoa(string palavra)
        {
            foreach (string s in CarregarListString(_LETRAS_FOO, ','))
            {
                if (palavra.ToLower().StartsWith(s))
                {
                    return true;
                }
            }

            return false;
        }

        # endregion

        # region Auxiliares

        /// <summary>
        /// Separa uma string em uma lista.
        /// </summary>
        /// <param name="texto"></param>
        /// <param name="separador"></param>
        /// <returns></returns>
        private static List<string> CarregarListString(string texto, char separador)
        {
            string[] arrayTexto = texto.Split(separador);
            return arrayTexto.OfType<string>().ToList();
        }

        # endregion

    }
}
