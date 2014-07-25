using System.Collections.Generic;
using System.Linq;

namespace ExameIValueDesenvolvedor
{
    /// <summary>
    /// Classe que contém os cálculos de verbos e preposições em IValuesh
    /// </summary>
    public static class BlIValuesh
    {
        //Declaro lista de char somente readonly para letras do tipo foo  em IValuesh
        //tipo foo: t, s, w, l e h
        public static readonly List<char> LetrasTipoFoo = new List<char> { 't', 's', 'w', 'l', 'h' };

        /// <summary>
        /// Método responsável por obter a quantidade de verbos no texto em IValuesh
        /// </summary>
        /// <param name="verbosTexto">Verbos do texto em questão</param>
        /// <returns>Quantidade de verbos encontradas no texto</returns>
        public static int ObterQuantidadeDeVerbosNoTexto(IEnumerable<string> verbosTexto)
        {
            return verbosTexto.Count();
        }

        /// <summary>
        /// Método responsável por obter a quantidade de verbos em primeira pessoa no texto em IValuesh
        /// </summary>
        /// <param name="verbosTexto">Verbos encontrados no text</param>
        /// <returns>Quantidade de verbos em primeira pessoa encontrados no texto</returns>
        public static int ObterQuantidadeDeVerbosNoTextoEmPrimeiraPessoa(IEnumerable<string> verbosTexto)
        {
            //obtenho quantidade de verbos que começam com uma letra tipo foo
            return verbosTexto.Count(verbo => LetrasTipoFoo.Contains(verbo.First()));
        }

        /// <summary>
        /// Método responsável por obter os verbos do texto em IValuesh
        /// </summary>
        /// <param name="textoDesejado">Texto em IValuesh</param>
        /// <returns>Lista de verbos encontrados no texto</returns>
        public static List<string> ObterVerbosNoTexto(string textoDesejado)
        {
            //Obtenho os verbos que são palavras de 8 ou mais letras que terminam numa letra tipo foo
            var verbosTextoB = textoDesejado.Split(' ').Where(verbo => verbo.Length >= 8 && LetrasTipoFoo.Contains(verbo.Last())).ToList();
            return verbosTextoB;
        }

        /// <summary>
        /// Método responsável por obter a quantidade de preposições no texto  em IValuesh
        /// </summary>
        /// <param name="textoDesejado">String referente ao texto que se deseja utilizar A ou B ... </param>
        /// <returns>Quantidade de preposições no texto</returns>
        public static int ObterQuantidadePreposicoesNoTexto(string textoDesejado)
        {
            //Obtenho as quantidades de preposições que são as palavras de 3 letras que terminam numa letra tipo foo, mas onde não ocorre a letra m
            var qtdPreposicoesTextoB = textoDesejado.Split(' ').Count(preposicao => preposicao.Length == 3 && !preposicao.Contains("m") && LetrasTipoFoo.Contains(preposicao.Last()));
            return qtdPreposicoesTextoB;
        }
    }
}
