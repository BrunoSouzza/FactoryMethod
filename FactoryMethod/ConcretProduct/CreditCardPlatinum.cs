using FactoryMethod.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.ConcretProduct
{
    public class CreditCardPlatinum : CreditCard
    {
        public CreditCardPlatinum()
        {
            Limit = 15000;
        }
    }
}
