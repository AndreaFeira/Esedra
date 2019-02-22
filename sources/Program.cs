using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Using a resolver to remove all concrete dependency of the shopper
            ICreditCard creditCard = CreditCardResolver.resolve();

            Shopper shopper = new Shopper(creditCard);

            Console.WriteLine(string.Format("Shopper is {0}", shopper.charge()));

            Console.ReadKey();
        }
    }
}
