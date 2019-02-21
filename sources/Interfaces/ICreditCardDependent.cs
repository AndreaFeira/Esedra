using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esedra.Interfaces
{
    public interface ICreditCardDependent
    {
        void InjectADependency(ICreditCard c);
    }
}
