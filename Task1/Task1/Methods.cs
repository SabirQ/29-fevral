using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
   static class Methods
    {
        public static string Capitalized(this string sentence)
        {
            StringBuilder capitalized = new StringBuilder();
            sentence = sentence.ToLower();
            capitalized.Append(Char.ToUpper(sentence[0]));
            for (int i = 1; i < sentence.Length; i++)
            {
                if (sentence[i]==' ')
                {
                    capitalized.Append(Char.ToUpper(sentence[i]));
                    capitalized.Append(Char.ToUpper(sentence[i + 1]));
                    i++;
                }
                else
                {
                    capitalized.Append(sentence[i]);
                }
            }
            return Convert.ToString(capitalized);
        }

        
    }
}
