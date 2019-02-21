using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    public class Shopper
    {
        private ICreditCard creditCard;

        //Costructor accepts objects that implement ICreditCard interface
        public Shopper(ICreditCard c)
        {
            creditCard = c;
        }

        public string charge()
        {
            return creditCard.charge();
        }

    }
}
