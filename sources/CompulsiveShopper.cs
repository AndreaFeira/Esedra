using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    public class CompulsiveShopper : ICreditCardDependent
    {
        private ICreditCard emptyCreditCard;

        public void InjectADependency(ICreditCard c)
        {
            this.emptyCreditCard = c;
        }

        public string charge()
        {
            return emptyCreditCard.charge();
        }

    }
}
