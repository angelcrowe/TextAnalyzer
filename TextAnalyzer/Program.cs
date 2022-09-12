using System;

namespace TextAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "This is a string of text.";

            Console.WriteLine("Your text is: " + text);
            Console.WriteLine("The number of characters is: " + text.Length);
            Console.WriteLine("In uppercase: " + text.ToUpper());
            Console.WriteLine("Does it contain the word \"text\"? " + text.Contains("text"));

            Console.ReadLine();
        }
    }
}
