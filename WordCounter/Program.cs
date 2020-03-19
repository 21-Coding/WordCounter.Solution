using System;


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
            QuickText("Welcome to Word Counter!");
            Console.Write("Please enter a word:");

            string inputWord = Console.ReadLine();
            Console.Clear();

            Console.Write("Please enter a sentence:");

            string inputSent = Console.ReadLine();
            Console.Clear();

            // Word newWord = new Word(inputSent);
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
