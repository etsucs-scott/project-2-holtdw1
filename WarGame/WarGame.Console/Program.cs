using WarGame.Core;
using WarGame.Core.Game_Logic;


Game.Functional = true;
int menuOption;
while (Game.Functional == true)
{
    Console.WriteLine($"----------Main Menu----------\n" +
        $"1. Play Game\n" +
        $"2. How to play\n" +
        $"3. Exit\n\n" +
        $"{Game.Message}");
    menuOption = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    if (menuOption == 1)
    {
        Table.MakeDeck();
        Thread.Sleep(1000);

        Console.WriteLine("How many players do you want to play with? (2-4)");
        Game.Input = Console.ReadLine();

        if (Game.Input != "2" || Game.Input != "3" || Game.Input != "4")
        {
            Console.WriteLine("Invalid input. Please try again");
        }
        else
        {
            int playersToMake = Convert.ToInt32(Game.Input);

            Console.WriteLine("What are the names of the players?");
            List<string> names = new List<string>();
            for (int i = 0; i < playersToMake; i++)
            {
                Console.WriteLine($"Name of player {i}:");
                names.Add(Console.ReadLine());
            }
            Table.MakePlayers(playersToMake, names);
            Console.WriteLine("That's all for now!");
            Thread.Sleep(1000);
        }
    }
    if (menuOption == 2)
    {
        Console.WriteLine("You haven't made this yet\n\n");
        Thread.Sleep(1000);
        Console.Clear();
    }
    if (menuOption == 3)
    {
        Console.WriteLine("Closing game...");
        Thread.Sleep(1000);
        Game.Functional = false;
        break;
    }
}
