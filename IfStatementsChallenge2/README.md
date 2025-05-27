# PartyEligibility – Age-Based Club Access

This is a simple C# console program that checks whether a user is allowed to go to a party in a club based on their age and whether they're accompanied by their parents.

## 🎯 What It Does

- Asks the user for their age.
- Grants or denies access to a club based on the following logic:
  - **18 and older**: Full access.
  - **13 to 17**: Allowed only if with parents.
  - **Below 13**: Denied access.

## 🔄 Logic Breakdown

```text
if age >= 18 → "Go party in the club!"
else if age >= 13
    → ask "Are you with your parents?"
    if yes → "Go party in the club with your parents!"
    if no  → "No party for you today!"
else → "No party for you!"
