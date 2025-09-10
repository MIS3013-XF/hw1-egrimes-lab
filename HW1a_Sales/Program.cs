// HW1a Sales Total

// Your Name: Elizabeth Grimes
// Did you seek help ? If yes, specify the helper or web link here: TA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1a_Sales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the product name of the item you are purchasing?");
            string productName = Console.ReadLine();

            Console.WriteLine("How many Football Ticket's do you want to buy?");
            string footballTickets = Console.ReadLine();
            double footballTicketsNum = Convert.ToDouble(footballTickets);

            Console.WriteLine("What is the price for each Football Ticket?");
            string footballTicketPrice = Console.ReadLine();
            double footballTicketPriceNum = Convert.ToDouble(footballTicketPrice);

            double subTotal = footballTicketsNum * footballTicketPriceNum;
            double salesTax = subTotal * .085;
            double total = subTotal + salesTax;

            Console.WriteLine("Your subtotal for your bill is: " + subTotal.ToString("C"));
            Console.WriteLine("Your sales tax for your bill is: " + salesTax.ToString("C"));
            Console.WriteLine("Your total for your bill is: " + total.ToString("C"));


            Console.ReadKey();

        }
    }
}
