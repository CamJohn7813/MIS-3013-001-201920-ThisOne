using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputFormattingConverting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your first name >>");
            string firstName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite number >>");
            int favNumber = Convert.ToInt32(Console.ReadLine());




            Console.ReadKey();

        }
    }
}
