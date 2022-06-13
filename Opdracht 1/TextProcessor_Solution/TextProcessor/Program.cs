using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextProcessor;

namespace TextProcessor
{
    class Program
    {
        static void Main(string[] args)
        {
            WordCountAnalyser analyser = new WordCountAnalyser();
            Console.WriteLine("Enter sentence: ");
            string text = Console.ReadLine();
            // Choose method
            Console.WriteLine("Method choice 1/2/3: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {              
                int result = analyser.CalculateHighestWordCount(text);
                Console.WriteLine("Highest word count is: " + result);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Enter a word to search for: ");
                string word = Console.ReadLine();
                int result = analyser.CalculateWordCount(text, word);
                Console.WriteLine("Count is: " + result);
            }
            else if (choice == 3)
            {
                List<IWordCount> result = analyser.GetMostCountedWords(text, 1);                
            }
            Console.ReadKey();
        }
    }
}
