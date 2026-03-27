using System;
using WarGame.Core.Game_Logic;
using WarGame.Core.Players;


Game.Functional = true;
Game.Winner = false;
Game.RoundLimit = 10000;
int menuOption; //was causing issues with validation later, so I had to assign this 
while (Game.Functional == true)
{
    Console.WriteLine($"----------Main Menu----------\n" +
        $"1. Play Game\n" +
        $"2. How to play\n" +
        $"3. Exit\n\n");
    menuOption = Convert.ToInt32(Console.ReadLine());
    Console.Clear();//for readability
    if (menuOption == 1) //I don't know how to do switch cases yet, but I know they're probably better here
    {
        Table.MakeDeck();
        Console.WriteLine("How many players do you want to play with? (2-4)");
        Game.Input = Console.ReadLine();

        while (true) //this doesn't let any input through except what we want
        {
            if (Game.Input != "2" && Game.Input != "3" && Game.Input != "4")
            {
                Console.WriteLine("Invalid input. Please try again\n\n");
                Game.Input = Console.ReadLine();
            }
            else
            {
                break;
            }
        }
        int playersToMake = Convert.ToInt32(Game.Input); //takes the validated input, and makes that many players

        Console.WriteLine("What are the names of the players?");
        List<string> names = new List<string>(); //this makes passing the names into the method way easier later
        for (int i = 0; i < playersToMake; i++)
        {
            Console.WriteLine($"Name of player {i + 1}:\n"); //it's i+1, because loops start at 0
            string playerName = Console.ReadLine();
            while (true)
            {
                if (names.Contains(playerName)) //stops direct duplicates, but allows for variations (eg. John and john)
                {
                    Console.WriteLine($"You already have {playerName} added. Please try a different name\n");
                    playerName = Console.ReadLine(); //asks for input again, so we don't get stuck
                }
                else
                {
                    names.Add(playerName);  
                    Console.WriteLine(""); //for readability
                    Console.WriteLine($"{names[i]} added to the game! Players created: {i + 1} / {playersToMake}");
                    Thread.Sleep(553);
                    Console.Clear();
                    break;
                }
            }
        }

        Table.MakePlayers(playersToMake, names);
        Dealer.Deal();

        foreach (Player player in Dealer.Players.Values)
        {
            PlayerHands.AddHand(player, player.PlayerHand);
        }

        int PlayedRounds = 0;

        while (Game.Winner == false)
        {
            if (PlayedRounds == Game.RoundLimit)
            {
                Console.WriteLine("The war has taken its toll. There will be no victor this day.");
                Console.WriteLine("The war is over.\n\n");
                Thread.Sleep(1000);
                Console.WriteLine("Press enter to return to the menu");
                Console.ReadLine();
                Game.Winner = true;
            }
            foreach (Player? player in Dealer.Players.Values)
            {
                if (player.PlayerHand.Cards.Count == 52)
                {
                    Console.WriteLine($"{player.Name} has obtained every last soldier. All are loyal to them. The ones who aren't have submitted.");
                    Game.Winner = true;
                }
                var playedcard = player.PlayerHand.PlayCard(player);

                if (playedcard == null)
                {
                    player.Eliminated = true;
                    Console.WriteLine($"Player {player.ID + 1}: {player.Name} has perished in the war. They are no longer");
                    continue;
                }

                else
                {
                    PlayedCards.PlayCard(player, playedcard);
                    Console.WriteLine($"Player {player.ID + 1}: {player.Name} plays the {playedcard.Rank} of {playedcard.Suit}");
                    //Thread.Sleep(500);
                }
            }

            Console.WriteLine($"{PlayedCards.Winner} wins the hand with the {PlayedCards.CompareCards(PlayedCards.Cards)}\n\n");
            Pot.WinCards(Dealer.Players[(PlayedCards.Winner)]);
            PlayedRounds++;
            //Thread.Sleep(1000);
            //Console.Clear();
        }
        Console.WriteLine("The war is over.");
        Thread.Sleep(1000);
        Console.WriteLine("");
    }
    if (menuOption == 2)
    {
        Console.WriteLine("In the main menu, press the one key to access the creation screen\n\n" +
            "From there, enter the amount of players you want (with a minimum of 2, and maximum of 4)\n " +
            "You have to input a number, because I'm too lazy to run the proper validation\n\n" +
            "Then, simply enter the names of each player\n (no direct duplicates, but you can have variations. eg. 'John' and 'john')\n\n" +
            "Lastly, the deck will be shuffled randomly, distributed to each player, and the simulation will run.\n The winner will be declared (or lack thereof)\n\n\n" +
            "Press enter to return to the menu :3");
        Console.ReadLine();
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
