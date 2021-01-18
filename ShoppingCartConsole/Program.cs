using ShoppingCartCreator;
using ShoppingCartCreator.Classes;
using ShoppingCartCreator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please select your products:");

            Console.WriteLine("Butter: ");
            int qtyButter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Milk: ");
            int qtyMilk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bread: ");
            int qtyBread = Convert.ToInt32(Console.ReadLine());

            var lstSelectedItems = new List<Tuple<string, int>>() {
              new Tuple<string, int>("Butter", qtyButter),
              new Tuple<string, int>("Milk", qtyMilk),
              new Tuple<string, int>("Bread", qtyBread),
            };

            Resolver res = new Resolver();
            double result = res.displayResult(lstSelectedItems);
            Console.WriteLine("Total {0}", result);
            Console.ReadLine();
        }
    }
}
