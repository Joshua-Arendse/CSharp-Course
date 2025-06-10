# 🗺️ AdventureGame – Text-Based Console RPG in C#

This project is a beginner-friendly interactive adventure game that walks the player through a simple fantasy journey. It features branching story paths, character creation, and chance-based outcomes using randomness.

---

## 📚 Concepts Practised

- ✅ User input (`Console.ReadLine()`)
- ✅ String interpolation
- ✅ `if-else` and nested conditionals
- ✅ Boolean control flow
- ✅ Use of `Random` for chance-based outcomes
- ✅ Game loop progression using flags (`gameContinue`)

---

## 🧾 Gameplay Summary

1. **Character Creation:**  
   Player enters their character's name and selects a type (e.g. Warrior, Wizard, Archer).

2. **First Choice – Enter or Camp:**  
   Determines whether the player camps or enters the dark forest.

3. **Second Choice – Left or Right Path:**  
   - Left: Treasure found.
   - Right: Encounter a beast — choose to fight or flee.

4. **Fight Outcome:**  
   - Based on a random number between 1 and 10.  
   - `luck > 5` = Victory.  
   - `luck > 8` = Victory + treasure drop.  
   - `luck <= 5` = Death.

5. **Game Ends:**  
   A thank-you message and final "Game Over" screen conclude the session.

---

## 🧪 Example Output

Welcome to the adventure game!
Enter your character's name:
Joshua
What is your character type?(Warrior,Wizard or Archer)
Wizard
You, Joshua the Wizard find yourself at the end of the dark forest.
Do you enter the forest or do you camp outside? [Enter/Camp]
enter
You bravely entered the forest.
You have reached a fork in the road. Go left or right?
right
You encounter a wild beast. fight or flee? [fight/flee]
fight
You have defeated the beast!
Thank you for playing the game.
Game over.