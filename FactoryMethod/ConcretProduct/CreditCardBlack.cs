using FactoryMethod.Product;

namespace FactoryMethod.ConcretProduct
{
    public class CreditCardBlack : CreditCard
    {
        public CreditCardBlack()
        {
            Limit = 10000;
        }
    }
}
