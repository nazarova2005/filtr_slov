using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrLibrary
{
    public class FiltrClass
    {

        /// <summary>
        /// Заменяет во входной строке все неприличные слова на звездочки ***.
        /// </summary>
        /// <param name="textString">В качестве параметра передается строка, которая может быть пустой или содержать некоторый текст. В тексте может быть 0 или более слов "редиска", записанных в различном регистре.</param>
        /// <returns>Возвращается отфильтрованный текст, в котором все слова редиска заменены на звездочки ***</returns>
        public static string Censore(string textString)
        {
            List<string> word = new List<string>();

            textString = textString.ToLower();

            word = textString.Split(' ').ToList();

            var replacement = word.Select(x => x.Replace("редиска", "***")).ToList();

            string stringWithoutBadWords = string.Join(" ", replacement.ToArray());

            return stringWithoutBadWords;
        }
    }
}
