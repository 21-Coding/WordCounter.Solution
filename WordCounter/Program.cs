using System;
using System.Threading;


namespace Counter.Models
{
    class Program
    {
      public static void QuickText(string line)
      {
        for (int i = 0; i < line.Length; i++)
          {
            Console.Write(line[i]);
            System.Threading.Thread.Sleep(50);
          }
      }
        static void Main()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White; 
            QuickText("Welcome to Word Counter!");
            System.Threading.Thread.Sleep(1000);

            Console.Clear();
            QuickText("Please enter a sentence:");
            string inputSent = Console.ReadLine();

            Console.Write("Please give me a word in that sentence to count:");
            string inputWord = Console.ReadLine();
            Console.Clear();


            Word newWord = new Word(inputSent, inputWord);

            if (newWord.HowManyWordsASent() == 0)
            {
              Console.ForegroundColor = ConsoleColor.Red;
              QuickText("Error, please return to the main menu. Good Bye.");
              System.Threading.Thread.Sleep(1000);
              Console.Clear();
              Main();
            }
            else 
            {
              QuickText("Looks like " + newWord.Count + " shows up " + newWord.HowManyWordsASent() + " time(s) in your sentence.");
              System.Threading.Thread.Sleep(1000);
              Console.Clear();
              Main();
            }

            // int countWords = newWord.HowManyWordsASent();
            // countWords.HowManyWordsASent();


            // if ( countWords > 1 )
            // {
              
            //   QuickText($"There are {countWords} instances of {inputWord}.");
            // }
            // else {
            //   QuickText("Try again.");
            // }


        }
    }
}
