using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameHiLo2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lav et program som implementerer spillet Hi - Lo(gæt et tal).
             I denne udgave af HI-Lo skal brugeren tænke på et tal mellem 1 og 100,
             og computeren skal så gætte tallet.*/

            int guessedNumber;
            int number;
            bool isGuessed = false;

            Console.WriteLine("***" + " " + "Welcome to the Hi_Lo game" + " " + "***");
            Console.WriteLine("Think of a number between 1 and 100");
            Console.WriteLine("I will make a guess");
            guessedNumber = new Random().Next(1, 100);
            Console.WriteLine("My guess is:" + guessedNumber);
            Console.WriteLine("Tell me if I'm <H>igh,<L>ow or <E>qual?:");

            while (!isGuessed)
            {
                string highLowOrEqual = Console.ReadLine();

                if (highLowOrEqual.ToLower() == "h")
                {
                    number = new Random().Next(1, guessedNumber);
                    Console.WriteLine("My guess is:" + number);
                    Console.WriteLine("Tell me if I'm <H>igh, <L>ow or <E>qual?:");
                }
                else if (highLowOrEqual.ToLower() == "l")
                {
                    number = new Random().Next(guessedNumber, 100);
                    Console.WriteLine("My guess is:" + number);
                    Console.WriteLine("Tell me if I'm <H>igh, <L>ow or <E>qual?:");
                }
                else if (highLowOrEqual.ToLower() == "e")
                {
                    isGuessed = true;
                }
                else
                {
                    Console.WriteLine("Wrong typo. Type <h> for high, <l> for low or <e> for equal. ");
                }
            }

            Console.WriteLine("***" + " " + "I GOT IT!" + " " + "***");
            Console.ReadKey();
        }
    }
}