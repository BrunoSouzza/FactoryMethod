

using FactoryMethod.ConcreteCreator;
using FactoryMethod.Creator;
using FactoryMethod.Product;

Console.WriteLine("Choose your Credit Card.");
Console.WriteLine("1: Gold");
Console.WriteLine("2: Black");
Console.WriteLine("3: Platinum");
var selected = Console.ReadLine().ToLower();

Console.WriteLine("");


CreditCardFactory creditCardFactory = null;

switch (selected)
{
    case "1":
        creditCardFactory = new GoldFactory();
        break;
    case "2":
        creditCardFactory = new BlackFactory();
        break;
    case "3":
        creditCardFactory = new PlatinumFactory();
        break;
    default:
        break;
}

CreditCard creditCard = creditCardFactory.RequestCreditCard();

Console.WriteLine($"Credit Card Type: {creditCard.GetType().Name} | Limit: {creditCard.Limit}");