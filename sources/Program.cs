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
            //////////////////////////////////////////////
            //Manual dependency injection using COSTRUCTOR
            //////////////////////////////////////////////

            ICreditCard visa = new Visa();
            ICreditCard masterCard = new MasterCard();

            Shopper s1 = new Shopper(masterCard);
            Shopper s2 = new Shopper(visa);

            Console.WriteLine(string.Format("Shopper1 is {0}", s1.charge()));
            Console.WriteLine(string.Format("Shopper2 is {0}", s2.charge()));



            //////////////////////////////////////////////
            //Manual dependency injection using getter and setter
            //////////////////////////////////////////////
            ICreditCard femaleVisa = new Visa();
            ICreditCard femaleMasterCard = new MasterCard();

            FemaleShopper fs = new FemaleShopper();

            fs.creditCard = femaleVisa;
            Console.WriteLine(string.Format("FemaleShopper is now {0}", fs.charge()));

            fs.creditCard = femaleMasterCard;
            Console.WriteLine(string.Format("FemaleShopper is now {0}", fs.charge()));

            Console.ReadKey();
        }
    }
}
