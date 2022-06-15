using FactoryMethod.Product;

namespace FactoryMethod.Creator
{
    public abstract class CreditCardFactory
    {
        public abstract CreditCard RequestCreditCard();
    }
}
