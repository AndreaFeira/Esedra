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
            ICreditCard visa = new Visa();
            ICreditCard masterCard = new MasterCard();

            Shopper s1 = new Shopper(masterCard);
            Shopper s2 = new Shopper(visa);

            Console.WriteLine(string.Format("Shopper1 is {0}", s1.charge()));
            Console.WriteLine(string.Format("Shopper2 is {0}", s2.charge()));


            Console.ReadKey();
        }
    }
}
