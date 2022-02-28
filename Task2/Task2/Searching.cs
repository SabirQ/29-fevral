using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    static class Searching
    {
        public static bool FindOut(this string sentence,string word)
        {
            bool result = false;
            string[] Array = sentence.Split(' ');

            foreach (string element in Array)
            {
                if (word==element)
                {
                    result = true;
                }
            }
            return result;            
        }
    }
}
