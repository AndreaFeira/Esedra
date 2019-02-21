using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    public class Visa : ICreditCard
    {
        public string charge()
        {
            return "Charge with Visa circuit!";
        }
    }
}
