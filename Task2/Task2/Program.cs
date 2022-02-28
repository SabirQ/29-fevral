using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Sentence = "No pain no gain let us train";
            string SearchWord = "gain";
            
            if (Sentence.FindOut(SearchWord))
            {
                Console.WriteLine($"Verilmish cumlede '{SearchWord}' sozu movcuddur ");
            }
            else
            {
                Console.WriteLine($"Verilmish cumlede '{SearchWord}' sozu movcud deyil ");
            }
        }
    }
}
