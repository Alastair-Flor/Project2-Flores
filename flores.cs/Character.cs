using System;

class Character
{
    // Fields to store character information
    public string Name;
    public string Class;
    public int Health;

    // Constructor to set up a new character with a name, class, and health
    public Character(string name, string characterClass)
    {
        Name = name;
        Class = characterClass;
        Health = 10;  // Start all characters with 10 health
    }

    // Method for the character to attack
    public void Attack(Monster monster, Direction direction)
    {
        string[] attackMessages = {
                "flexes their big muscles! The love interest scoffs.",
                "picks up a random heavy object! They look at you confused, but finds it mildly amusing.",
                "attempts to pick the love interest up. They immediately start yelling to be put down.",
                "crushes an apple with one hand! The love interest finds your bloodlust for apples oddly impressive",
                "gives insight into today's societal structures! They are intrigued by how educated you are in the topic."
            };

        Random random = new Random();
        int index = random.Next(attackMessages.Length);
        Console.WriteLine(Name + " " + attackMessages[index]);

        if (direction.Name == "Cowboy" || direction.Name == "Scarecrow")
        {
            monster.Health += 2; // interest increases after attack}

        }
        else
        {
            monster.Health += 1; // interest increases after attack
        }
    }
  

            // Method for the character to cast a spell (only if they are a Wizard) aka use of a list
            public void CastSpell(Monster monster, Direction direction)
            {
                if (Class == "Nerd")
                {
                    string[] spellMessages = {
                        "tells a funny story! The love interest turns away to hide a laugh.",
                        "says a cheesy pick-up line! They look at you with a flushed expression.",
                        "starts saying interesting facts! The love interest in impressed by your knowledge, but tries to act casual.",
                        "cracks a silly joke! The love interest chuckles and finds you amusing.",
                        "gives insight into today's societal structures! They are intrigued by how educated you are in the topic."
                    };

                    Random random = new Random();
                    int index = random.Next(spellMessages.Length);
                    Console.WriteLine(Name + " " + spellMessages[index]);

            if (direction.Name == "Gnome" || direction.Name == "Scarecrow" || direction.Name == "Vampire")
            {
                monster.Health += 2; // interest increases after spell
            }
            else
            {
                monster.Health += 1; // interest increases after attack
            }
                }
                else
                {
                    Console.WriteLine(Name + " cannot say a fun quip because they did not prepare.");
                }
            }

    // Method to display the current health of the character
    public void DisplayHealth()
    {
        Console.WriteLine(Name + "'s Charisma: " + Health);
    }
       // Method to display story pieces based on health
    public void DisplayStoryBasedOnHealth()
    {
        if (Health > 8)
        {
            Console.WriteLine(Name + " is now a little self-conscious.");
        }
        else if (Health > 5)
        {
            Console.WriteLine(Name + " wonders how much their dignity can take.");
        }
        else if (Health > 3)
        {
            Console.WriteLine(Name + " is starting to feel like maybe they should have played a different dating sim.");
        }
    }
}