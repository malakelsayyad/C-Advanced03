using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringFunctions
    {
        public static int GetCountOfUpperCase (string word)
        { 
            int Count = 0;


            if(!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsUpper(word[i]))
                    {
                        Count++;
                    }
                }
            }
            return Count;
        }

        public static int GetCountOfLowerCase(string word)
        {
            int Count = 0;


            if (!string.IsNullOrEmpty(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsLower(word[i]))
                    {
                        Count++;
                    }
                }
            }
            return Count;
        }
    }
}
