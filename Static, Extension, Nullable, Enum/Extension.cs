using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__Extension__Nullable__Enum
{
    internal static class Extension
    {
        public static string ToCapitalized(this string word)//alBert ==> Albert
        {
            StringBuilder builder = new StringBuilder();
            string newWord = word.ToLower();
            builder.Append(char.ToUpper(newWord[0]));

            builder.Append(newWord.Substring(1));

            return builder.ToString();

        }

        public static bool CustomContains(this string sentence,string search)// bu bir cumledir
        {
            string[] words = sentence.Split();

            foreach (var word in words)
            {
                if(word == search)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
