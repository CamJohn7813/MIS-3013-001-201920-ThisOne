using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            const double sales_tax = 0.085;//8.5%
            string item;
            int quantity;
            double price;
            Console.Write("What is the product name of the item you are purchasing: ");
            item = Console.ReadLine();
            Console.WriteLine("How many " + item + " do you want to buy: ");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the price for each " + item + "?");
            price = double.Parse(Console.ReadLine());
            double subTotal = quantity * price;
            double salesTax = sales_tax * subTotal;
            double salesTotal = subTotal + salesTax;
            Console.WriteLine("Your subtotal for your bill is: " + subTotal.ToString("C") + "\nYour sales tax for your bill is: " + salesTax.ToString("C")
            + "\nYour total for your bill is: " + salesTotal.ToString("C"));
            Console.ReadLine();
        }
    }
}
