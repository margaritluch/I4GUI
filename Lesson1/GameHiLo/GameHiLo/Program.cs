using System;

namespace GameHiLo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lav et program som implementerer spillet Hi - Lo(gæt et tal).
             I denne udgave af HI-Lo skal computeren vælge et tal mellem 1 og 100, og spilleren(brugeren) 
             skal så gætte tallet. 
            */
            int number;
            int guessedNumber;
            bool isGuessed = false;

            Console.WriteLine("***" + " " + "Welcome to the Hi_Lo game" + " " + "***");
            Console.WriteLine("The computer choose a number between 1 and 100, you guess it");
            number = new Random().Next(1, 100);

            while (!isGuessed)
            {
                Console.WriteLine("Enter your guess: ");
                guessedNumber = int.Parse(Console.ReadLine());

                if (guessedNumber > number)
                {
                    Console.WriteLine("You guess is too high");
                }
                else if (guessedNumber < number)
                {
                    Console.WriteLine("Your guess is too low");
                }
                else
                {
                    isGuessed = true;
                }
            }
            Console.WriteLine("YOU GOT IT!");
            Console.ReadKey();
        }
    }
}
