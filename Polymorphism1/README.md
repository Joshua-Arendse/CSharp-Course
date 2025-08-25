# 💳 Polymorphism with Interfaces – Payment Processing

This project demonstrates **polymorphism** in C# using **interfaces**.  
A `IPaymentProcessor` interface is defined, and two implementations (`CreditCardProcessor` and `PaypalProcessor`) show how different payment methods can share a common contract.

---

## 📖 Concepts Covered
- **Interfaces** (`IPaymentProcessor`)
  - Define a contract for processing payments.
  - Classes must implement the method `ProcessPayment(decimal amount)`.

- **Polymorphism**
  - `PaymentService` works with **any** class that implements `IPaymentProcessor`.
  - The actual behaviour depends on which processor is injected (`CreditCardProcessor` or `PaypalProcessor`).

- **Dependency Injection**
  - `PaymentService` receives the processor via its constructor (`constructor injection`).
  - Promotes loose coupling and flexibility.

---

## 🖥️ Example Code

```csharp
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}

public class CreditCardProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}

public class PaypalProcessor : IPaymentProcessor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount}");
    }
}

public class PaymentService
{
    private readonly IPaymentProcessor _processor;

    public PaymentService(IPaymentProcessor processor)
    {
        _processor = processor;
    }

    public void ProcessOrderPayment(decimal amount)
    {
        _processor.ProcessPayment(amount);
    }
}
```

---

## ▶️ Usage Example

```csharp
IPaymentProcessor creditCardProcessor = new CreditCardProcessor();
PaymentService paymentService = new PaymentService(creditCardProcessor);
paymentService.ProcessOrderPayment(100.00m);

IPaymentProcessor paypalProcessor = new PaypalProcessor();
paymentService = new PaymentService(paypalProcessor);
paymentService.ProcessOrderPayment(200.00m);
```

**Output:**
```
Processing credit card payment of 100.00
Processing paypal payment of 200.00
```

---

## 🧠 What You Learn
- How interfaces allow different implementations of the same behaviour.
- How polymorphism helps write flexible, maintainable code.
- Basics of **dependency injection** in C#.

---

## ▶️ Run the Program
```bash
cd Polymorphism1
dotnet run
```