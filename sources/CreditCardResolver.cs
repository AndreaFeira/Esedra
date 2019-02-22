using Esedra.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra
{
    public static class CreditCardResolver
    {
        //Resolve dependency over a configuration
        public static ICreditCard resolve()
        {
            string defaultCreditCardType = Properties.Settings.Default.ConfiguredCreditCard;

            if ("Visa" == defaultCreditCardType)
                return new Visa();
            else
                return new MasterCard();
        }
    }
}
