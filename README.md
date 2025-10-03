# 💳 Credit Card Factory (Factory Method Pattern)

A practical demonstration of the **Factory Method** design pattern in **C#**. This project showcases how to decouple object creation from business logic by leveraging the Factory Method, making your code more maintainable, scalable, and aligned with SOLID principles.

---

## 🚀 Technologies & Tools

- ![C#](https://img.shields.io/badge/C%23-239120?style=flat-square&logo=c-sharp&logoColor=white) **C#**
- ![DotNet](https://img.shields.io/badge/.NET-512BD4?style=flat-square&logo=dotnet&logoColor=white) **.NET Console Application**

---

## 📐 Design Principles & Patterns

- **Factory Method Pattern**  
  Provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

- **SOLID Principles**  
  - **S**ingle Responsibility Principle  
  - **O**pen/Closed Principle  

---

## 🏗️ Project Structure

### 🧩 Product (Abstract Class)
Defines the contract for all credit card types.
```csharp
public abstract class CreditCard
{
    public int Limit { get; set; }
}
```

### 🪪 Concrete Products
- `CreditCardGold` (Limit: 5000)
- `CreditCardBlack` (Limit: 10000)
- `CreditCardPlatinum` (Limit: 15000)

```csharp
public class CreditCardGold : CreditCard
{
    public CreditCardGold() { Limit = 5000; }
}
// ... other products follow same pattern
```

### 🏭 Creator (Factory)
Abstracts the creation process.
```csharp
public abstract class CreditCardFactory
{
    public abstract CreditCard RequestCreditCard();
}
```

### 🏢 Concrete Factories
Each factory produces a specific credit card.
```csharp
public class GoldFactory : CreditCardFactory
{
    public override CreditCard RequestCreditCard() => new CreditCardGold();
}
// ... other factories follow same pattern
```

---

## 🖥️ How It Works

The user selects a credit card type, and the appropriate factory creates the corresponding product:

```csharp
Console.WriteLine("Choose your Credit Card.");
Console.WriteLine("1: Gold\n2: Black\n3: Platinum");
var selected = Console.ReadLine();

CreditCardFactory factory = selected switch
{
    "1" => new GoldFactory(),
    "2" => new BlackFactory(),
    "3" => new PlatinumFactory(),
    _ => null
};

if (factory != null)
{
    var card = factory.RequestCreditCard();
    Console.WriteLine($"Credit Card Type: {card.GetType().Name} | Limit: {card.Limit}");
}
```

---

## 📦 Output Examples

```
Choose your Credit Card.
1: Gold
2: Black
3: Platinum
1

Credit Card Type: CreditCardGold | Limit: 5000
```
