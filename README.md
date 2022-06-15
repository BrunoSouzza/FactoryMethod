# Factory Method (en-es)

> Implemeting theFactory Method design pattern

Main benefits
* Define an interface for creating objects but allows subclasses to decide which class to instantiale.
* Allows the Client to not need to know what king of objects will be created
* Uses inheritance and dependes on a class to handle the instantiation of the desired object.
* It avoids firm coupling between the creator and the concrete products. 
* Simple Responsability Principle (SOLID).
* Open/Closed Principle (SOLID).
---
## **Product**

Note the **CreditCard** class.
It is an abstract class which ensures implementation by Concrete Products. We also have the **Limit** property which will be filled in by the Product's Concrete classes.

```cs
// Product
public abstract class CreditCard
{
    public int Limit { get; set; }
}
```
---
## **Concrete Product**

We created the Concrete Products classes that will be responsible for defining the **Limit** of our Product.

Note that we have 3 clasess, **CreditCardGold, CreditCardBlack e CreditCardPlatinum**, both implement the abstract class **CreditCard** ans define the limit of each Product.

```cs
// Concrete Product
public class CreditCardBlack : CreditCard
{
    public CreditCardBlack()
    {
        Limit = 10000;
    }
}

// Concrete Product
public class CreditCardGold : CreditCard
{
    public CreditCardGold()
    {
        Limit = 5000;
    }
}

// Concrete Product
public class CreditCardPlatinum : CreditCard
{
    public CreditCardPlatinum()
    {
        Limit = 15000;
    }
}
```
---
## **Creator**

Here we implement the Factory Method pattern. Note that this is an abstract class, as it will be implemented by the **Concrete Creator** and we will create a **RequestCreditCard()** method returning the **Product**.
```cs
// Creator Factory
public abstract class CreditCardFactory
{
    public abstract CreditCard RequestCreditCard();
}
```
---
## **Concrete Creator**
Here we create the Concrete Product classes and implement the abstract class **CreditCardFactory**, overriding the **RequestCreditCard()**, returning our **Concrete Product** according to what our **Factory** needs. 

```cs
// Concrete Creator
public class BlackFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard()
    {
        return new CreditCardBlack();
    }
}

// Concrete Creator
public class GoldFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard()
    {
        return new CreditCardGold();
    }
}

// Concrete Creator
public class PlatinumFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard()
    {
        return new CreditCardPlatinum();
    }
}
```

In a Program class, notice that we created a simple program where the user will choose 3 options.

Note that we create a **Create Factory** and based on the selected option, we install a **Concrete Factory** and then display the data in  console.

```cs
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
```

Console Output - Option 1.
```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
1

Credit Card Type: CreditCardGold | Limit: 5000
```
Console Output - Option 2.
```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
2

Credit Card Type: CreditCardBlack | Limit: 10000
```
Console Output - Option 3.
```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
3

Credit Card Type: CreditCardPlatinum | Limit: 15000
```
>Finish... Thank you!! 

---
# Factory Method (pt-br)

> Impementando o padrão de projeto Factory Method

Principais benefícios
* Define uma interface para criar objetos mas permite que as subclasses decidam qual classe instanciar.
* Permite que o Cliente não precise saber quais tipo de objetos serão criados.
* Usa herança e depende de uma classe para tratar com a instanciação do objeto desejado.
* Evita aclopamento firme entr criador e os produtos concretos.
* Princípio de responsabilidade única (SOLID). 
* Princípio de aberto/fechado (SOLID).
---
## **Product**

Observe a classe **CreditCard**. 
Trata-se de uma classe abstrata que garante a implementação pelos Concrete Products. Nela também criamos a propriedade **Limit** que será preenchida pelas classes Concretas do Produto.
```cs
// Product
public abstract class CreditCard
{
    public int Limit { get; set; }
}
```
---

## **Concrete Product**
Criamos as classes Concrete Products que terão a resposabilidade de definir o **Limit** dos nossos Produtos.

Observe que temos 3 classes, **CreditCardGold, CreditCardBlack e CreditCardPlatinum**, ambas implementam a classe abstrata **CreditCard** e definem o limite de cada Produto.

```cs
// Concrete Product
public class CreditCardBlack : CreditCard
{
    public CreditCardBlack()
    {
        Limit = 10000;
    }
}

// Concrete Product
public class CreditCardGold : CreditCard
{
    public CreditCardGold()
    {
        Limit = 5000;
    }
}

// Concrete Product
public class CreditCardPlatinum : CreditCard
{
    public CreditCardPlatinum()
    {
        Limit = 15000;
    }
}
```
---
## **Creator**
Aqui implementamos o padrão Factory Method. Observe que trata-se de uma classe abstrata, pois será implementada pelos **Concrete Creator** e criarmos um método **RequestCreditCard()** retornando o **Product**.
```cs
// Creator Factory
public abstract class CreditCardFactory
{
    public abstract CreditCard RequestCreditCard();
}
```
---

## **Concrete Creators**
Aqui criamos as classes Concretas dos Produtos e implementamos a classe abstrata **CreditCardFactory**, sobrescrevendo o método **RequestCreditCard()**, retornando o nosso **Concrete Product** de acordo com o que nossa **Factory** necessita. 

```cs
// Concrete Creator
public class BlackFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard()
    {
        return new CreditCardBlack();
    }
}

// Concrete Creator
public class GoldFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard()
    {
        return new CreditCardGold();
    }
}

// Concrete Creator
public class PlatinumFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard()
    {
        return new CreditCardPlatinum();
    }
}
```
---
Em uma classe Program, observe que criamos um programada simples onde o usuário escolherá 3 opções.

Observe que criamos um **Create Factory** e baseado na opçãp selecionada, instaciamos uma **Concrete Factory** e posteriormente exibimos os dados em console.

```cs
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
```

Saída do Console - Opção 1.
```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
1

Credit Card Type: CreditCardGold | Limit: 5000
```
Saída do Console - Opção 2.
```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
2

Credit Card Type: CreditCardBlack | Limit: 10000
```
Saída do Console - Opção 3.
```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
3

Credit Card Type: CreditCardPlatinum | Limit: 15000
```
>Finish... Thank you!! 