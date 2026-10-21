# 🔍 Regex – Regular Expressions in C#

This project introduces **regular expressions (regex)** in C# using the `System.Text.RegularExpressions` namespace. It searches a sentence for every digit using the `\d` pattern, then prints how many matches were found and where each one sits in the text.

---

## 📘 Key Concepts

### 🔹 Regular Expressions
A regex is a **pattern** used to search for, match, or validate text. Here the pattern is:
```csharp
string pattern = @"\d";
```
`\d` matches any **single digit** (0–9). The `@` makes it a verbatim string, so the backslash doesn't need escaping.

### 🔹 The Regex Class
```csharp
Regex regex = new Regex(pattern);
```
Creates a regex object from the pattern so it can be applied to any text.

### 🔹 MatchCollection
```csharp
MatchCollection matchCollection = regex.Matches(text);
```
`Matches()` returns **every** match found in the text, and `.Count` tells you how many.

### 🔹 Match and Groups
Each `Match` has a `Groups` collection. `Groups[0]` is the **whole match**, giving access to:
- `.Value` – the matched text
- `.Index` – the position where it was found in the string

---

## 🧠 How It Works

### ✔️ 1. Import the Namespace
```csharp
using System.Text.RegularExpressions;
```

### ✔️ 2. Define the Pattern and Text
```csharp
string pattern = @"\d";
string text = "Hi there, my number is 12314";
```

### ✔️ 3. Create the Regex and Find Matches
```csharp
Regex regex = new Regex(pattern);
MatchCollection matchCollection = regex.Matches(text);
```

### ✔️ 4. Report the Number of Hits
```csharp
Console.WriteLine("{0} hits found:\n {1}", matchCollection.Count, text);
```

### ✔️ 5. Loop Through Each Match
```csharp
foreach (Match hit in matchCollection)
{
    GroupCollection group = hit.Groups;
    Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
}
```
Prints each digit and its zero-based position in the string.

---

## 🧾 Example Output

```
Hello, World!
5 hits found:
 Hi there, my number is 12314
1 found at 23
2 found at 24
3 found at 25
1 found at 26
4 found at 27
```

---

## 💡 What You Learn

| Concept | Description |
|--------|-------------|
| **Regex Pattern** | Describe what text to look for instead of an exact string |
| **`\d` Character Class** | Matches a single digit (0–9) |
| **`Matches()`** | Finds all matches in a string, not just the first |
| **`Match.Index`** | Tells you where in the string each match starts |
| **`Groups[0]`** | The full text of the match |
| **Verbatim Strings (`@""`)** | Avoid double-escaping backslashes in patterns |

---

## 🧱 Summary

This project demonstrates how to:

- Create a regex pattern and apply it to a string
- Find all matches with `Matches()`
- Read each match's value and position

Note that `\d` matches **one digit at a time**, which is why `12314` gives 5 separate hits. Regex is widely used for **input validation** (emails, phone numbers, IDs), **searching and replacing text**, and **parsing logs or data**.

---

## ▶️ Run the Program

```bash
cd Regex
dotnet run
```

---

## ⏭️ Next Step

Change the pattern to `\d+` so the whole number `12314` is matched as a single hit, then try other patterns such as `\w+` (words) or `[A-Z]` (capital letters). After that, try `regex.IsMatch()` for validation and `Regex.Replace()` for search and replace.
