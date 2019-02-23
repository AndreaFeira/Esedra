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

            ///////////////////////////////////
            //Using Resolver with configuration file.
            //This will remove all concrete dependency of the shopper
            ///////////////////////////////////

            ICreditCard creditCard = CreditCardResolver.resolve();

            Shopper shopper = new Shopper(creditCard);
            Console.WriteLine(string.Format("Shopper is {0}", shopper.charge()));


            ///////////////////////////////////
            //Using Esedra IoC Container
            ///////////////////////////////////
            EsedraContainer EsedraIoC = new EsedraContainer();

            //register dependencies
            EsedraIoC.register<Shopper, Shopper>();
            EsedraIoC.register<ICreditCard, MasterCard>();

            Shopper s = EsedraIoC.Inject<Shopper>();
            Console.WriteLine(string.Format("Shopper is {0}", s.charge()));



            Console.ReadKey();
        }
    }
}
