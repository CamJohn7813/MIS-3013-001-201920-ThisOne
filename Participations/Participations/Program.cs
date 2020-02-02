CameronJohnson using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose heads or tails >>");
            string usersGuessAsString = Console.ReadLine();
            int usersGuess;


            if (usersGuessAsString == "0") 
            {
                usersGuess = 0;
            }
            else
            {
                usersGuess = 1;
            }

            Random rand = new Random();
            int randomNumber = rand.Next(0, 2);

            Console.ReadKey();
        }
    }
}
