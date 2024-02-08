using System;
using System.Linq;
using System.Threading;
using Game_RPG.PlayerClass;
using Game_RPG.StructureClass;

namespace Game_RPG
{

    class Program
    {
        public static Structure_Manager Structure_manager = new();
        public static string Game_Option = "Menu_Game";
        public static int X_Position_Player;
        public static int Y_Position_Player;
        public static Hero_Model Player
        {
            get; set;
        }
        static void Main()
        {    
            while(true)
            {
                while (Game_Option == "Menu_Game")
                {
                    Console.WriteLine(
                        "****************************************\n" +
                        "Hello adventurer!!!" +
                        "\n" +
                        "\n" +
                        "[1] New Game\n" +
                        "[2] Save\n" +
                        "[3] Guide\n" +
                        "[4] Exit\n" +
                        "\n " +
                        "****************************************");
                    Console.Write("State your goal: ");
                    switch (Console.ReadLine())
                    {
                            case "1":
                            {
                                Thread.Sleep(300);
                                Console.Clear();
                                Mechanic_system.Character_Create();
                                X_Position_Player = 0;
                                Y_Position_Player = 0;
                                Thread.Sleep(300);
                                Console.Clear();
                                Game_Option = "New_Game";
                                Console.WriteLine("Yum yum, I slept well, but it's time to earn some beer.");
                                Console.WriteLine("You leave the house (crash).\n");
                                Console.Write("[Click enter to continue]");
                                Console.ReadLine();
                            }
                            break;

                            case "2":
                            {
                                try
                                {
                                    // Odczytaj stan gry
                                    Player = SaveSystem.LoadGame("C:\\SaveData.json");
                                    if (Player != null)
                                    {
                                        Console.WriteLine("I managed to read it");
                                        Thread.Sleep(1000);
                                        Game_Option = "New_Game";
                                    }
                                    else
                                    {
                                        Console.WriteLine("There is no saved game data.");
                                        Thread.Sleep(1000);
                                        Console.Clear();
                                        // W tym miejscu możesz ustawić inne akcje, np. uruchomienie nowej gry
                                    }
                                }
                                catch (Exception ex)
                                {
                                    // error
                                    Console.WriteLine($"An error occurred: {ex.Message}");
                                    Console.ReadLine();
                                }
                            }
                            break;

                            case "3":
                            {
                                Console.WriteLine("This is DEMO");
                                Thread.Sleep(1000);
                                Console.Clear();
                            }
                            break;

                            case "4":
                            {
                                Environment.Exit(0);
                            }
                            break;
                            default:
                            {
                                Console.WriteLine("Bad Choose");
                                Thread.Sleep(500);
                                Console.Clear();
                            }
                            break;
                    }
                }

                while (Game_Option == "New_Game")
                {
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine();
                        Interaction_Locationst.Choose_Way();
                        string Choose_Way_Text = Console.ReadLine();
                        if (Choose_Way_Text == "Menu")
                        {
                            Choose_Way_Text = "menu";
                        }
                        else if (Choose_Way_Text == "Left")
                        {
                            Choose_Way_Text = "left";
                        }
                        else if (Choose_Way_Text == "Right")
                        {
                            Choose_Way_Text = "right";
                        }
                        else if (Choose_Way_Text == "Up")
                        {
                            Choose_Way_Text = "up";
                        }
                        else if (Choose_Way_Text == "Down")
                        {
                            Choose_Way_Text = "down";
                        }
                        else if (Choose_Way_Text == "City")
                        {
                            Choose_Way_Text = "city";
                        }

                        try
                        {
                            switch (Choose_Way_Text)
                            {
                                    case "menu":
                                    {
                                        Console.Clear();
                                        while (true)
                                        {
                                            Console.WriteLine("[1]Character window\n[2]Eq\n[3]Exit");
                                            Console.Write("What do you want to see?: ");
                                            string Choise_Okno = Console.ReadLine();
                                            if(Choise_Okno == "1")
                                            {
                                                Player.View_Card();
                                            }

                                            else if (Choise_Okno == "2")
                                            {
                                                Player.Eq_Player();
                                            }

                                            else if (Choise_Okno == "3")
                                            {
                                                break;
                                            }
                                            else
                                            {
                                                Console.Clear();
                                            }
                                        }
                                        Console.Clear();
                                    }
                                    break;

                                    case "left":
                                    {
                                        Interaction_Locationst.Location_Manager(Choose_Way_Text);
                                    }
                                    break;

                                    case "right":
                                    {
                                        Interaction_Locationst.Location_Manager(Choose_Way_Text);
                                    }
                                    break;

                                    case "up":
                                    {
                                        Interaction_Locationst.Location_Manager(Choose_Way_Text);
                                    }
                                    break;

                                    case "down":
                                    {
                                        Interaction_Locationst.Location_Manager(Choose_Way_Text);
                                    }
                                    break;

                                    case "city":
                                    {
                                        Console.Clear();
                                        string userInput;
                                        if ((X_Position_Player == 0 && Y_Position_Player == 0))
                                        {
                                            while (true)
                                            {
                                                Console.Clear();
                                                Console.WriteLine("\n[1] To the Blacksmith\n[2] To the Armorer\n[3] To the Guild\n[4] Leaving the City\n[5] Save game");
                                                Console.Write("Where do you want to go?: ");
                                                userInput = Console.ReadLine();

                                                switch (userInput)
                                                {
                                                        case "1":
                                                        {
                                                            Structure_Manager.Visit_Smithy();
                                                        }
                                                        break;

                                                        case "2":
                                                        {
                                                            Structure_Manager.Visit_Armorer();
                                                        }
                                                        break;

                                                        case "3":
                                                        {
                                                            Structure_Manager.Visit_Adventurers_Guild();
                                                        }
                                                        break;

                                                        case "4":
                                                        {
                                                            Console.Clear();
                                                        }
                                                        break;

                                                        case "5":
                                                        {
                                                            try
                                                            {
                                                                SaveData saveData = new ();
                                                                SaveSystem.SaveGame("C:\\SaveData.json", Player);
                                                                Console.WriteLine("Successfully saved");
                                                                Thread.Sleep(1500);
                                                                Console.Clear();
                                                            }
                                                            catch (Exception ex)
                                                            {
                                                                // Obsłuż błąd
                                                                Console.WriteLine($"An error occurred: {ex.Message}");
                                                                Thread.Sleep(1500);
                                                                Console.Clear();
                                                            }
                                                        }
                                                        break;

                                                        default:
                                                        Console.Clear();
                                                        break;
                                                }

                                                if (userInput == "4")
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        else
                                        {
                                            Console.Write("There is no city here lol");
                                        }                                
                                    }
                                    break;

                                    default:
                                    {
                                        Console.WriteLine("There is no such option!");
                                        Thread.Sleep(500);
                                        Console.Clear();
                                    }
                                    break;
                            }
                        }
                        catch (NullReferenceException)
                        {
                            Console.WriteLine("There's nothing there/Not the right way. Enter button");
                            Console.ReadLine();
                            Console.Clear();
                        }
                    }

                }
            }
        }
    }
}
