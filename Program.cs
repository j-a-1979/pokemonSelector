using System;


class Program
{
    static void Main(string[] args)
    {
        Pokemon pikachu = new Pokemon();

        pikachu.name = "Pikachu";
        pikachu.level = 25;
        pikachu.type = "Electric";

        Pokemon charmander = new Pokemon();
        
        charmander.name = "Charmander";
        charmander.level = 15;
        charmander.type = "Fire";
        
        Pokemon bulbasaur = new Pokemon();

        bulbasaur.name = "Bulbasaur";
        bulbasaur.level = 10;
        bulbasaur.type = "Grass/Poison";

        Console.Write("Enter your name: ");
        string? userName = Console.ReadLine();

        Console.WriteLine("Hola " + userName + ", hoy eliges tu primer pokemon!"); // Greeting message

        // Display available Pokemon

        Console.WriteLine("1. " + pikachu.name + " - Type: " + pikachu.type);
        Console.WriteLine("2. " + charmander.name + " - Type: " + charmander.type);
        Console.WriteLine("3. " + bulbasaur.name + " - Type: " + bulbasaur.type);

        while (true)
        {
            Console.Write("Enter the number or the name of the Pokemon you choose: ");
            string? choice = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(choice))
            {
                Console.WriteLine("Input cannot be empty. Please try again.");
                continue;
            }

            if (choice == "1" || choice.Equals(pikachu.name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You chose " + pikachu.name + "!");
                Console.WriteLine("Congratulations! You have chosen " + pikachu.name + ", the level " + pikachu.level + " " + pikachu.type + " type Pokemon.");
                Console.WriteLine("Good luck on your adventure!\n");
                Console.WriteLine("   (\\__/)");
                Console.WriteLine("   (•ᴥ• )");
                Console.WriteLine("   / >⚡");
                break;

            }
            else if (choice == "2" || choice.Equals(charmander.name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You chose " + charmander.name + "!");
                Console.WriteLine("Congratulations! You have chosen " + charmander.name + ", the level " + charmander.level + " " + charmander.type + " type Pokemon.");
                Console.WriteLine("Good luck on your adventure!\n");
                Console.WriteLine("   (\\__/)");
                Console.WriteLine("   (•ᴥ• )");
                Console.WriteLine("   / >🔥");
                break;

            }
            else if (choice == "3" || choice.Equals(bulbasaur.name, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You chose " + bulbasaur.name + "!");
                Console.WriteLine("Congratulations! You have chosen " + bulbasaur.name + ", the level " + bulbasaur.level + " " + bulbasaur.type + " type Pokemon.");
                Console.WriteLine("Good luck on your adventure!\n");
                Console.WriteLine("   (\\__/)");
                Console.WriteLine("   (•ᴥ• )");
                Console.WriteLine("   / >🌿");
                break;

            }
            else
            {
                Console.WriteLine("Invalid choice. Please restart the program and choose a valid Pokemon.");
                continue;
            }
        }
    }
}