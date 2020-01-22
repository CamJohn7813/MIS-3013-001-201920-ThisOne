using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables_Cameron_Johnson
{
    class Program
    {
        static void Main(string[] args)
        {
            //create a string named firstName
            string firstName;

            //assign a value to firstName (use your name)
            firstName = "Cameron";

            //create an int named faavoriteNumber and assign your favorite number to it
            int favoriteNumber = 27;

            double crazyNumber = 8.3784 * favoriteNumber;

            string lastName = "Johnson";
            string fullName = firstName + lastName;

            Console.WriteLine(fullName + "has the favorite number of " + favoriteNumber + " which equates to a crazy number of " + crazyNumber);

            //MAKE IT DYNAMIC
            Console.WriteLine("Please enter your first name: >>");

            Console.WriteLine("Please enter your last name: >>");
            Console.WriteLine("Please enter your favorite number: >>");
            

            Console.WriteLine(fullName + "has the favorite number of " + favoriteNumber + " which equates to a crazy number of " + crazyNumber);



            Console.ReadKey();
        }
    }
}
