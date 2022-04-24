using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp9.Extension
{
   static class Extension
    {
        public static string Capitalized(this string text)
        {
            StringBuilder stringBuilder = new StringBuilder(text);
            stringBuilder[0] = Char.ToLower(stringBuilder[0]);

            // return text = stringBuilder.ToString();

            text += Char.ToUpper(stringBuilder[0]);
            for (int i = 0; i < stringBuilder.Length; i++)
            {
                if (stringBuilder[i]==' ')
                {
                    text += stringBuilder[i];
                    text += Char.ToUpper(stringBuilder[i + 1]);
                    i++;
                }
                else
                {
                    text += stringBuilder[i];
                }
               
            }
            return text;
        }
    }
    
}
