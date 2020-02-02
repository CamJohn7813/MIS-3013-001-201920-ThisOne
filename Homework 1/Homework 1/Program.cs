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
            const double SALES_TAX = 0.085;//8.5%
            string itemName;
            int quantity;
            double price;
            Console.Write("Item name: ");
            itemName = Console.ReadLine();
            Console.WriteLine("Enter " + itemName + " qunatity: ");
            quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter " + itemName + "'s price: ");
            price = double.Parse(Console.ReadLine());
            //calculate subtotal
            double subTotal = quantity * price;
            double salesTax = SALES_TAX * subTotal;
            double salesTotal = subTotal + salesTax;
            //print
            Console.WriteLine("Sub Total: " + subTotal.ToString("C") + "\nSales Tax: " + salesTax.ToString("C")
            + "\nSales Total: " + salesTotal.ToString("C"));
            //pause
            Console.ReadLine();
        }
    }
}
