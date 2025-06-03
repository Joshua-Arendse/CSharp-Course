# 👤 Members – Access Modifiers, Properties, and Class Structure in C#

This project demonstrates **encapsulation and access control** in C# through a class named `Members`. It includes private and public fields, properties, constructors, destructors, and controlled method exposure using parameters.

---

## 📚 Concepts Practised

- ✅ Private vs public fields
- ✅ Properties (`get` / `set`)
- ✅ Constructors and destructors
- ✅ Encapsulation and access control
- ✅ Calling private methods from public methods
- ✅ Debug output and cleanup logic

---

## 🧱 Class: `Members`

### 🔐 Private Fields:
- `memberName` – The member’s name  
- `jobTitle` – The member’s job title  
- `salary` – Private salary data

### 🌐 Public Fields:
- `age` – Member's age

### 🏷️ Property:
```csharp
public string JobTitle
{
    get { return jobTitle; }
    set { jobTitle = value; }
}

### 🧰 Methods:

Introducing(bool isFriend) – Public method that conditionally shows private details

SharingPrivateInfo() – Private method only accessible within the class

Members() – Constructor setting initial field values

~Members() – Destructor that logs object finalisation

### 🧪 Example Output

Object created
My salary is 60000