using System;

namespace WordCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm, kuvab mitu sõna on lauses "Hello World!"

            string HelloW = "Hello World";

            //while
            /*
            int i = 0;
            int wordCounter = 1;

            while (i < HelloW.Length)
            {
                if(HelloW[i] == ' ')
                {
                    wordCounter++;
                }
                i++;
            }
            Console.WriteLine($"Lauses on {HelloW} on {wordCounter} sõna");
            */
            int wordCounter = 1;
            for(int i=0; i<HelloW.Length; i++)
            {
                if (HelloW[i] == ' ')
                {
                    wordCounter++;
                }
            }
            Console.WriteLine($"Lauses on {HelloW} on {wordCounter} sõna");
        }
    }
}
