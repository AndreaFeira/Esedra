using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    public class FemaleShopper
    {
        public ICreditCard creditCard { get; set; }

        public FemaleShopper()
        {
        }

        public string charge()
        {
            return creditCard.charge();
        }

    }
}
