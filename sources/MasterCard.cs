using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    public class MasterCard : ICreditCard
    {
        public string charge()
        {
            return "Charge with MasterCard circuit!";
        }
    }
}
