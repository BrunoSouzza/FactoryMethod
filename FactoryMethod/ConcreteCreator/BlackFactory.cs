using FactoryMethod.ConcretProduct;
using FactoryMethod.Creator;
using FactoryMethod.Product;

namespace FactoryMethod.ConcreteCreator
{
    public class BlackFactory : CreditCardFactory
    {
        public override CreditCard RequestCreditCard()
        {
            return new CreditCardBlack();
        }
    }
}
