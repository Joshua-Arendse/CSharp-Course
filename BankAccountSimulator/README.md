# 🏦 BankAccountSimulator – Simple C# Console Banking App

**BankAccountSimulator** is a basic C# console application that simulates real-world bank account operations. It allows users to create a bank account, deposit and withdraw funds, and check their balance — all using object-oriented principles.

---

## 📚 Concepts Practised

- ✅ Classes and Objects
- ✅ Access modifiers (encapsulation with `private`)
- ✅ Properties and constructors
- ✅ User input and type conversion
- ✅ Menu-driven console application
- ✅ Basic validation and conditionals

---

## 🧩 Class: `BankAccount`

```csharp
public class BankAccount
{
    public string AccountHolder { get; set; }
    public string AccountNumber { get; set; }
    private decimal Balance { get; set; }

    public void Deposit(decimal amount);
    public void Withdraw(decimal amount);
    public void ViewBalance();
}
```

- Uses a `private` field for balance to protect data (encapsulation)
- Includes logic to prevent invalid transactions

---

## 💻 Program Flow

1. User enters:
   - Account holder's name
   - Account number
   - Initial balance
2. Displays an interactive bank menu:
   - Deposit
   - Withdraw
   - View balance
   - Exit
3. All inputs are parsed and validated
4. Console displays confirmation or errors accordingly

---

## 🧪 Sample Output

```
Welcome to the Bank!
Enter Account Holder Name: Josh
Enter Account Number: 00123
Enter Initial Balance: 5000

Bank Menu:
1. Deposit
2. Withdraw
3. View Balance
4. Exit
Choose an option: 1
Enter amount to deposit: 250
Deposit R250.00. New Balance: R5250.00.

Bank Menu:
Choose an option: 2
Enter amount to withdraw: 1000
Withdrew R1000.00. New Balance: R4250.00.
```

---

## ▶️ How to Run

```bash
dotnet run
```

Ensure both files are in the same project folder under the `BankAccountSimulator` namespace:
- `Program.cs`
- `BankAccount.cs`

---

## 🔧 Future Features

- Add account types (savings, cheque)
- Implement overdraft or interest
- Add transaction history
- PIN/password protection
- File saving and loading of account data

---

This project is a great beginner’s introduction to **object-oriented programming, encapsulation, and building user-friendly console apps** in C#. 💰
