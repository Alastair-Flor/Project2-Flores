using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Dungeons and Dating Sim!");
        Console.WriteLine("In this game you will get to choose a DND love interest and see where the pursuit leads!");
        Console.WriteLine("But remember, in the game of love you have to know how to play to win their favor.");
        Console.WriteLine("First things first, what's your name?");
        string playerName = Console.ReadLine();
        Console.WriteLine("HA! " + playerName + "? Really??? Wow, your parents must have loved you. Ahem- anyway...");
        Console.WriteLine("Choose your Build: Jock or Nerd.");

        // Choose character class
        string classChoice = Console.ReadLine();
        Console.WriteLine("You are now a: " + classChoice + ". Cool! Let's see if you peaked in high school.");

        // Create the character based on the input
        Character player = new Character(playerName, classChoice);

        // Create a wild monster
        Monster monster = new Monster("Your Muse", 0);
        //Monster monster = new Monster("Otis Lee Lector", 0);
        //Monster monster = new Monster("Brunte", 0);
        //Monster monster = new Monster("Kaelan Shadowvale", 0);

        // Create directions
        Direction north = new Direction("Scarecrow", "You approach what you think is only a pile of burlap and hay. \n On closer inspection, a scarecrow woman with a pumpkin head emerges. \n Dispite her ragged construction, she seemes oddly classy. \n She dawns a burlap puffy jacket and short form-fitting dress. \n A belt is sinched around her waist to accentuate and keep her straw body together. \n A thick spellbook that was obviously meant for necromancy sits on the table beside her. \n Suddenly, she approaches with a sinister carved grin and outstretches her hand introducing herself as Zephira Xi. \n Although friendly, you can tell she is not sincere. \n Gaining her favor won't be easy.");
        Direction south = new Direction("Cowboy", "You walk closer to a man covered head to toe in cowboy attire \n Even his face and hands are meticulously covered by a bandana and gloves. \n As you close the distance, a pungent smell of rotting flesh assults your nose. \n The cowboy notices your wretching and exsaperatedly exclaims that everyone's so dramatic. They are not. \n Suddenly, he approaches with an outstretched hand and introduces himself as Otis Lee Lector.  \n As you take it, his arm falls right off the joint and onto the floor. \n Otis scrambles to reattach the rotting limb and then insists you didn't see that. \n Dispite his circumstances, you offended him earlier. \n Gaining his favor won't be easy.");
        Direction east = new Direction("Vampire", "You approach a regal-looking man in a dark corner. \n His long dark hair and deep skin seem to consume the shadows around him as he elegantly plays the violin. \n You are drawn to him as his sweet, yet sad melody echos in your brain. \n Suddenly, the music stops and the vampire turns to look at you. His expression is pained and exhausted. \n Like a flip of a switch he smiles and extends his hand, introducing himself as Kaelan Shadowvale. \n You ask him about the song, but he brushes it off and quickly changes the subject. \n Dispite his now happy demeanor, you can tell something is weighing on him. \n Gaining his favor won't be easy.");
        Direction west = new Direction("Gnome", "You look down to your left and jump to see a 3 and a half foot stalky gnome. How long had he been standing there?? \n He looks up at you with a very stern expression. \n As he stares you take note of his dark short curly hair, big round glasses, and a thick trimmed beard. \n After a few akward moments, you avert your gaze and ask him his name. \n Suddenly, he grabs your hand and tells you his name is Brunte and to act normal in a low and paranoid voice. \n As quickly as he pulled you in, he lets you go and returns to his stoic, yet wary state. \n Brunte seems a little high-strung in this enviornment. \n Gaining his favor won't be easy.");

        // Choose a direction
        Console.WriteLine("You go to a speed dating bar and the nice employees at the show you 4 profiles. Which do you choose: Cowboy, Scarecrow, Vampire, Gnome.");
        string directionChoice = Console.ReadLine();
        
        Direction chosenDirection = null; //saves direction choice

        if (directionChoice.Equals("Scarecrow", StringComparison.OrdinalIgnoreCase))
        {
            chosenDirection = north;
        }
        else if (directionChoice.Equals("Cowboy", StringComparison.OrdinalIgnoreCase))
        {
            chosenDirection = south;
        }
        else if (directionChoice.Equals("Vampire", StringComparison.OrdinalIgnoreCase))
        {
            chosenDirection = east;
        }
        else if (directionChoice.Equals("Gnome", StringComparison.OrdinalIgnoreCase))
        {
            chosenDirection = west;
        }
        else
        {
            Console.WriteLine("Invalid choice. You give up your pursuit of love.");
            return;
        }
        chosenDirection.DisplayInfo(); //Displays Love interest

        Console.WriteLine("You get out a small mirror and check if anything is in your teeth. What will you do?");
        PerformActions(player, monster, chosenDirection);

        Console.WriteLine("Looks like you'll be living a real loveless existance.");
        Console.ReadLine();
    }

    static void PerformActions(Character character, Monster monster, Direction direction)
    {
        while (character.Health > 0 && monster.Health < 10)
        {
            Console.WriteLine(character.Name + " is getting ready to woo. Choose: 1 to Flex Your Muscles, 2 to Say a Cool Quip");
            string action = Console.ReadLine();

            if (action == "1")
            {
                character.Attack(monster, direction);
            }
            else if (action == "2")
            {
                character.CastSpell(monster, direction);
            }

            character.DisplayHealth();
            character.DisplayStoryBasedOnHealth(); // Display story based on character's health
            monster.DisplayHealth();
            monster.DisplayStoryBasedOnHealth(character); // Display story based on monster's health

            if (monster.Health < 10)
            {
                monster.Attack(character);
                character.DisplayHealth();
                character.DisplayStoryBasedOnHealth(); // Display story based on character's health
            }

            if (character.Health <= 0)
            {
                Console.WriteLine(character.Name + " is devastated. " + character.Name + " didn't know they could be torn down so fast. Everyone always said that the worst thing they could say was no, but " + character.Name + " thinks that this is probably worse. Defeated, " + character.Name + " heads into the forest never to be seen again.");
            }
            else if (monster.Health >= 10)
            {
                Console.WriteLine("Your " + monster.Name + " is impressed by how many interesting qualities you have. " + character.Name + " is taken over by a stomach full of butterflies. Dispite the nerves, " + character.Name + " asks if " + monster.Name + " wants to go on a date. They graciously accept. \n Even in a crazy world like this, love is in the air. \n The End");
            }
        }
    }
}