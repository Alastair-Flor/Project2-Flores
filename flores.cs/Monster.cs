using System;
using System.Reflection;

class Monster
{
    public string Name;
    public int Health;

    public Monster(string name, int health)
    {
        Name = name;
        Health = health;
    }

    public void Attack(Character character)
    {
        Console.WriteLine(Name + " jabs back at " + character.Name + "!");
        character.Health -= 2; // Monster attack decreases character's health
    }

    public void DisplayHealth()
    {
        Console.WriteLine(Name + "'s Affection: " + Health);
    }
     // Method to display story pieces based on health
    public void DisplayStoryBasedOnHealth(Character character)
    {
        if (Health > 3)
        {
            Console.WriteLine(Name + " glares at " + character.Name + " and tries to ignore you, but you can tell they are still listening.");
        }
        else if (Health > 5)
        {
            Console.WriteLine(Name + " reluctantly smiles at " + character.Name + ", but still refuses to speak to you.");    
        }
        else if (Health > 7)
        {
            Console.WriteLine(Name + " thinks maybe " + character.Name + "'s intentions really are genuine.");
        }
        else if (Health > 9)
        {
            Console.WriteLine(Name + " wonders why " + character.Name + " is so mean. It just wanted to have a meal with " + character.Name + ". " + character.Name + " is a monster.");
        }
    
    }
}