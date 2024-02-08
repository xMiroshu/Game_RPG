using System;
using System.Linq;
using System.Threading;
using Game_RPG.PlayerClass;

namespace Game_RPG.StructureClass
{
    class Structure_Manager
    {
        public static void Visit_Smithy()
        {
            while (true)
            {
                Console.Clear();
                NPC.Smithy_Blacksmith("welcome");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            if (Program.Player.Class_Character == "Archer")
                            {
                                var eligibleBows = Item_Manager.Weapons_items
                                    .Where(item => item.Lvl_Item <= Program.Player.Lvl_Character && item.Class_Item == ClassItem.Archer)
                                    .Select(item => $"ID: {item.ID_Item}, Name: {item.Name_Item}, Info: {item.Info_Item}, Price: {item.Price_Item} gold, Request Lvl: {item.Lvl_Item}");

                                foreach (var bow in eligibleBows)
                                {
                                    Console.WriteLine(bow);
                                }
                            }

                            else if (Program.Player.Class_Character == "Warrior")
                            {
                                var eligibleSwords = Item_Manager.Weapons_items
                                    .Where(item => item.Lvl_Item <= Program.Player.Lvl_Character && item.Class_Item == ClassItem.Warrior)
                                    .Select(item => $"ID: {item.ID_Item}, Name: {item.Name_Item}, Info: {item.Info_Item}, Price: {item.Price_Item} gold, Request Lvl: {item.Lvl_Item}");

                                foreach (var sword in eligibleSwords)
                                {
                                    Console.WriteLine(sword);
                                }
                            }

                            else if (Program.Player.Class_Character == "Mag")
                            {
                                var eligibleStaws = Item_Manager.Weapons_items
                                    .Where(item => item.Lvl_Item <= Program.Player.Lvl_Character && item.Class_Item == ClassItem.Mag)
                                    .Select(item => $"ID: {item.ID_Item}, Name: {item.Name_Item}, Info: {item.Info_Item}, Price: {item.Price_Item} gold, Request Lvl: {item.Lvl_Item}");

                                foreach (var staws in eligibleStaws)
                                {
                                    Console.WriteLine(staws);
                                }
                            }

                            Console.WriteLine("\nEnter = Exit\n");

                            Console.WriteLine($"\n\t\t\t\tPouch : {Program.Player.Money_Bag} gold");
                            try
                            {
                                Console.Write("What would you like to buy(ID)?: ");
                                int ID_Item = Convert.ToInt32(Console.ReadLine());
                                var Search_List_Buy = Item_Manager.Search_Weapons_Item(ID_Item);

                                if (Program.Player.Class_Character == "Mag" && Search_List_Buy.Name_Item.ToLower().EndsWith("staw") || Program.Player.Class_Character == "Archer" && Search_List_Buy.Name_Item.ToLower().EndsWith("bow") || Program.Player.Class_Character == "Warrior" && Search_List_Buy.Name_Item.ToLower().EndsWith("sword"))
                                {
                                    if (Program.Player.Money_Bag >= Search_List_Buy.Price_Item && Search_List_Buy.Lvl_Item <= Program.Player.Lvl_Character)
                                    {
                                        Item_Manager.Add_Weapons(ID_Item);
                                        Program.Player.Money_Bag -= Search_List_Buy.Price_Item;
                                    }
                                    else
                                    {
                                        Console.WriteLine("You can't afford it, poor thing, or it's too small lvl");
                                        Console.ReadLine();
                                        goto case "1";
                                    }
                                }
                                else
                                {
                                    Console.Write("This item is not for your profession");
                                    Console.ReadLine();
                                    goto case "1";
                                }
                            }
                            catch (FormatException)
                            {
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine();
                            NPC.Smithy_Blacksmith("talk");
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            return;
                        }

                    default:
                        {

                        }
                        break;
                }
            }
        }

        public static void Visit_Armorer()
        {
            while (true)
            {
                Console.Clear();
                NPC.Armorers_Workshop("welcome");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();

                            var eligibleArmors = Item_Manager.Armors_items
                                .Where(item => Program.Player.Lvl_Character >= item.Lvl_Item)
                                .Select(item => $"ID: {item.ID_Item}, Name: {item.Name_Item}, Info: {item.Info_Item}, Price: {item.Price_Item} gold, Request Lvl: {item.Lvl_Item}");
                            foreach (var armor in eligibleArmors)
                            {
                                Console.WriteLine(armor);
                            }

                            Console.WriteLine("\nEnter = Exit\n");
                            Console.WriteLine($"\n\t\t\t\tPouch : {Program.Player.Money_Bag} gold");
                            try
                            {
                                Console.Write("What would you like to buy(ID)?: ");
                                int ID_Item = Convert.ToInt32(Console.ReadLine());
                                Armors_Items Search_List_Buy = Item_Manager.Search_Armors_Item(ID_Item);

                                if (Search_List_Buy != null && Program.Player.Money_Bag >= Search_List_Buy.Price_Item && Search_List_Buy.Lvl_Item <= Program.Player.Lvl_Character)
                                {
                                    Item_Manager.Add_Armors(ID_Item);
                                    Program.Player.Money_Bag -= Search_List_Buy.Price_Item;
                                }
                                else
                                {
                                    Console.WriteLine("You can't afford it, poor thing, or it's too small lvl");
                                    Console.ReadLine();
                                    goto case "1";
                                }
                            }
                            catch (FormatException)
                            {

                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine();
                            NPC.Armorers_Workshop("talk");
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            return;
                        }

                    default:
                        {

                        }
                        break;
                }
            }
        }

        public static void Visit_Adventurers_Guild()
        {
            while (true)
            {
                Console.Clear();
                NPC.Adventurers_Guild("welcome");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.Write(
                                "[1] 1 Star\n" +
                                "[2] 2 Stars\n" +
                                "[3] 3 Stars\n" +
                                "[4] 4 Stars\n" +
                                "[5] 5 Stars\n" +
                                "\n[0] Exit");

                            Console.Write("What tasks do you want to see?: ");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    {
                                        Console.Clear();
                                        Tasks_Manager.View_Task(1);
                                        Console.WriteLine("\n[0] - Exit\n");
                                        Console.Write("Enter the ID of the job you would like to accept: ");
                                        int Task_iD = Convert.ToInt32(Console.ReadLine());
                                        if (Task_iD == 0)
                                        {
                                            break;
                                        }
                                        Tasks Chosen_Task = Tasks_Manager.Search_Task(Task_iD);
                                        Tasks Task_Character = Tasks_Manager.Search_Task_Character(Task_iD);
                                        if (Chosen_Task != null && Task_Character == null && Chosen_Task.Stars_Task == 1)
                                        {
                                            Program.Player.Tasks_Character.Add(Chosen_Task);
                                            Console.WriteLine("The task has been accepted, have fun hunting ^_^");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is no such task");
                                            Console.ReadLine();
                                            goto case "1";
                                        }
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.Clear();
                                        Tasks_Manager.View_Task(2);
                                        Console.Write("Enter the ID of the job you would like to accept: ");
                                        int Task_iD = Convert.ToInt32(Console.ReadLine());
                                        if (Task_iD == 0)
                                        {
                                            break;
                                        }
                                        Tasks Chosen_Task = Tasks_Manager.Search_Task(Task_iD);
                                        Tasks Task_Character = Tasks_Manager.Search_Task_Character(Task_iD);
                                        if (Chosen_Task != null && Task_Character == null && Chosen_Task.Stars_Task == 2)
                                        {
                                            Program.Player.Tasks_Character.Add(Chosen_Task);
                                            Console.WriteLine("The task has been accepted, have fun hunting ^_^");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is no such task");
                                            Console.ReadLine();
                                            goto case "1";
                                        }
                                    }
                                    break;

                                case "3":
                                    {
                                        Console.Clear();
                                        Tasks_Manager.View_Task(3);
                                        Console.Write("Enter the ID of the job you would like to accept: ");
                                        int Task_iD = Convert.ToInt32(Console.ReadLine());
                                        if (Task_iD == 0)
                                        {
                                            break;
                                        }
                                        Tasks Chosen_Task = Tasks_Manager.Search_Task(Task_iD);
                                        Tasks Task_Character = Tasks_Manager.Search_Task_Character(Task_iD);
                                        if (Chosen_Task != null && Task_Character == null && Chosen_Task.Stars_Task == 3)
                                        {
                                            Program.Player.Tasks_Character.Add(Chosen_Task);
                                            Console.WriteLine("The task has been accepted, have fun hunting ^_^");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is no such task");
                                            Console.ReadLine();
                                            goto case "1";
                                        }
                                    }
                                    break;

                                case "4":
                                    {
                                        Console.Clear();
                                        Tasks_Manager.View_Task(4);
                                        Console.Write("Enter the ID of the job you would like to accept: ");
                                        int Task_iD = Convert.ToInt32(Console.ReadLine());
                                        if (Task_iD == 0)
                                        {
                                            break;
                                        }
                                        Tasks Chosen_Task = Tasks_Manager.Search_Task(Task_iD);
                                        Tasks Task_Character = Tasks_Manager.Search_Task_Character(Task_iD);
                                        if (Chosen_Task != null && Task_Character == null && Chosen_Task.Stars_Task == 4)
                                        {
                                            Program.Player.Tasks_Character.Add(Chosen_Task);
                                            Console.WriteLine("The task has been accepted, have fun hunting ^_^");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is no such task");
                                            Console.ReadLine();
                                            goto case "1";
                                        }
                                    }
                                    break;

                                case "5":
                                    {
                                        Console.Clear();
                                        Tasks_Manager.View_Task(5);
                                        Console.Write("Enter the ID of the job you would like to accept: ");
                                        int Task_iD = Convert.ToInt32(Console.ReadLine());
                                        if (Task_iD == 0)
                                        {
                                            break;
                                        }
                                        Tasks Chosen_Task = Tasks_Manager.Search_Task(Task_iD);
                                        Tasks Task_Character = Tasks_Manager.Search_Task_Character(Task_iD);
                                        if (Chosen_Task != null && Task_Character == null && Chosen_Task.Stars_Task == 5)
                                        {
                                            Program.Player.Tasks_Character.Add(Chosen_Task);
                                            Console.WriteLine("The task has been accepted, have fun hunting ^_^");
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            Console.WriteLine("There is no such task");
                                            Console.ReadLine();
                                            goto case "1";
                                        }
                                    }
                                    break;

                                case "0":
                                    {
                                        break;
                                    }

                                default:
                                    {
                                        Console.Clear();
                                    }
                                    break;
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Tasks_Manager.View_Task_Character();
                            Console.WriteLine("\n[0] Exit\n");
                            Console.Write("Enter the ID of the task you would like to submit: ");
                            try
                            {
                                int Task_iD = Convert.ToInt32(Console.ReadLine());
                                if (Task_iD == 0)
                                {
                                    break;
                                }
                                Tasks Chosen_Task = Tasks_Manager.Search_Task(Task_iD);
                                Tasks Task_Character = Tasks_Manager.Search_Task_Character(Task_iD);
                                if (Chosen_Task != null && Task_Character != null)
                                {
                                    if (Task_Character.Status_Requirements_Task == Task_Character.Requirements_Task)
                                    {
                                        Program.Player.Money_Bag += Task_Character.Reward_Task;
                                        Console.Write("You completed this task and received {0} gold", Task_Character.Reward_Task);
                                        Program.Player.Tasks_Character.Remove(Task_Character);
                                        Console.ReadLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("The task has not been completed, there is no money to drink hahaha");
                                        Console.ReadLine();
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("There is no such task");
                                    Console.ReadLine();
                                    goto case "2";
                                }
                            }
                            catch
                            {
                                Console.WriteLine("Bad ID");
                                Thread.Sleep(1000);
                                goto case "2";
                            }

                        }
                        break;

                    case "3":
                        {
                        case2:
                            Console.Clear();

                            foreach (var Monsters_Item in Item_Manager.Monsters_items)
                            {
                                if (Monsters_Item.ID_Item <= 13)
                                {
                                    Console.WriteLine($"ID: {Monsters_Item.ID_Item}, Nazwa: {Monsters_Item.Name_Item}, Info: {Monsters_Item.Info_Item}, Cena: {Monsters_Item.Price_Item} golda");
                                }
                            }
                            Console.WriteLine("\n[1] Yes\n[2] No\n");
                            Console.Write("Do you want to see the other side of the purchased items?: ");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    {
                                        Console.Clear();
                                        foreach (var Monsters_Item in Item_Manager.Monsters_items)
                                        {
                                            if (Monsters_Item.ID_Item >= 14)
                                            {
                                                Console.WriteLine($"ID: {Monsters_Item.ID_Item}, Nazwa: {Monsters_Item.Name_Item}, Info: {Monsters_Item.Info_Item}, Cena: {Monsters_Item.Price_Item} golda");
                                            }
                                        }
                                        Console.WriteLine("\nYour Eq: \n");
                                        foreach (var Monsters_Characters_Eq in Program.Player.Monsters_Character)
                                        {
                                            Console.WriteLine($"ID: {Monsters_Characters_Eq.ID_Item}, Nazwa: {Monsters_Characters_Eq.Name_Item}, Ilość: {Monsters_Characters_Eq.Quantity_Item}, Info: {Monsters_Characters_Eq.Info_Item}");
                                        }
                                    }
                                    break;

                                case "2":
                                    {
                                        Console.Clear();
                                        foreach (var Monsters_Item in Item_Manager.Monsters_items)
                                        {
                                            if (Monsters_Item.ID_Item <= 13)
                                            {
                                                Console.WriteLine($"ID: {Monsters_Item.ID_Item}, Nazwa: {Monsters_Item.Name_Item}, Info: {Monsters_Item.Info_Item}, Cena: {Monsters_Item.Price_Item} golda");
                                            }
                                        }
                                        Console.WriteLine("\nYour Eq: \n");
                                        foreach (var Monsters_Characters_Eq in Program.Player.Monsters_Character)
                                        {
                                            Console.WriteLine($"ID: {Monsters_Characters_Eq.ID_Item}, Nazwa: {Monsters_Characters_Eq.Name_Item}, Ilość: {Monsters_Characters_Eq.Quantity_Item}, Info: {Monsters_Characters_Eq.Info_Item}");
                                        }
                                    }
                                    break;

                                default:
                                    {
                                        goto case2;
                                    }
                            }
                            Console.WriteLine("\nEnter = Exit");

                            Console.WriteLine($"\t\t\t\tPouch : {Program.Player.Money_Bag} gold\n");
                            try
                            {
                                Console.Write("What would you like to sell?(ID)?: ");
                                int ID_Item = Convert.ToInt32(Console.ReadLine());
                                Monsters_Items Search_List_Sell = Item_Manager.Search_Monsters_Item(ID_Item);

                                if (Search_List_Sell != null)
                                {
                                    Monsters_Items Search_item_Eq = Program.Player.Monsters_Character.FirstOrDefault(Item => Item.ID_Item == ID_Item);

                                    if (Search_item_Eq != null && Search_item_Eq.Quantity_Item >= 1)
                                    {
                                        Console.Write("How much do you want to sell {0} ?:", Search_item_Eq.Name_Item);
                                        int HowMany = Convert.ToInt32(Console.ReadLine());
                                        if (HowMany <= Search_item_Eq.Quantity_Item)
                                        {
                                            Search_item_Eq.Quantity_Item -= HowMany;
                                            int HowManyPrice = HowMany * Search_item_Eq.Price_Item;
                                            Program.Player.Money_Bag += HowManyPrice;
                                            Console.WriteLine("You got {0} gold", HowMany * Search_item_Eq.Price_Item);
                                            Thread.Sleep(2000);
                                            if (Search_item_Eq.Quantity_Item == 0)
                                            {
                                                Program.Player.Monsters_Character.Remove(Search_item_Eq);
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("You don't have that much {0}", Search_item_Eq.Name_Item);
                                            Thread.Sleep(2000);
                                            goto case2;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You don't have such an item");
                                        Thread.Sleep(1500);
                                        goto case2;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have such an item");
                                    Thread.Sleep(1500);
                                    goto case2;
                                }
                            }
                            catch (FormatException)
                            {
                            }
                        }
                        break;

                    case "4":
                        {
                            Console.WriteLine();
                            NPC.Adventurers_Guild("talk");
                        }
                        break;

                    case "5":
                        {
                            return;
                        }

                    default:
                        {

                        }
                        break;
                }
            }
        }

        public static void Visit_Drug_House()
        {
            while (true)
            {
                Console.Clear();
                NPC.Forest_Elder_Axsi("welcome");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();

                            foreach (var Elder_Items in Item_Manager.Utility_items)
                            {
                                Console.WriteLine($"ID: {Elder_Items.ID_Item}, Name: {Elder_Items.Name_Item}, Info: {Elder_Items.Info_Item}, Price: {Elder_Items.Price_Item} gold");
                            }
                            Console.WriteLine("\nEnter = Exit\n");
                            Console.WriteLine($"\n\t\t\t\tPouch : {Program.Player.Money_Bag} gold");
                            try
                            {
                                Console.Write("What would you like to buy(ID)?: ");
                                int ID_Item = Convert.ToInt32(Console.ReadLine());
                                Utitlity_Items Search_List_Buy = Item_Manager.Search_Utitlity_Item(ID_Item);
                                if (Search_List_Buy != null && Program.Player.Money_Bag >= Search_List_Buy.Price_Item)
                                {
                                    Item_Manager.Add_Utitlity(ID_Item);
                                    Program.Player.Money_Bag -= Search_List_Buy.Price_Item;
                                }
                                else
                                {
                                    Console.WriteLine("You can't afford it, poor thing/Bad choice");
                                    Console.ReadLine();
                                    goto case "1";
                                }
                            }
                            catch (FormatException)
                            {
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine();
                            NPC.Forest_Elder_Axsi("talk");
                        }
                        break;

                    case "3":
                        {
                            return;
                        }

                    default:
                        {

                        }
                        break;
                }
            }
        }

        public static void Oaza_Location()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("What a beautiful and peaceful place");
                Console.WriteLine("[1] This water sparkles strangely(Go into it)\n[2] Get out of here\n");
                Console.Write("What would you like to do: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Write("You entered the water, you feel your fatigue disappear and your wounds heal");
                            Program.Player.HP_Character = Program.Player.MaxHP_Character;
                            Program.Player.MP_Character = Program.Player.MaxMP_Character;
                            Console.ReadLine();
                        }
                        break;

                    case "2":
                        {
                            return;
                        }

                    default:
                        {
                        }
                        break;
                }
            }
        }

        public static void Cave_Location()
        {
            int Your_Postion_Cave = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hmm, it's a bit too quiet here, huh, I see some caves\n");
                Console.WriteLine("[1] You want to go into the cave?\n[2] Get out of here\n");
                Console.Write("What would you like to do: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("\nYou hear something, it's the enemy!\n");
                            Thread.Sleep(1000);
                            Mechanic_system.Combat_System();
                            if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                            {
                                return;
                            }
                            else
                            {
                                Your_Postion_Cave++;
                            }

                            Console.WriteLine("\n[1] You want to go deeper into the cave?\n[2] Get out of here\n");
                            Console.Write("What would you like to do(1-2): ");

                            if (Console.ReadLine() == "1")
                            {
                                if (Your_Postion_Cave == 5)
                                {
                                    break;
                                }
                                goto case "1";
                            }
                            else if (Console.ReadLine() == "2")
                            {
                                return;
                            }
                        }
                        break;

                    case "2":
                        {
                            return;
                        }

                    default:
                        {
                            continue;
                        }
                }

                if (Your_Postion_Cave == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tYou see a chest full of treasures in the distance!\n");
                    Console.WriteLine("\t\t\tYou earned 300 gold and 2 Potion of Healing\n");
                    Program.Player.Money_Bag += 300;
                    Console.Write("\t\t\t");
                    Item_Manager.Add_Utitlity(1);
                    Console.Write("\t\t\t");
                    Item_Manager.Add_Utitlity(1);
                    Console.WriteLine("\nYou leave the cave");
                    Console.ReadLine();
                    return;
                }
            }
        }

        public static void Cave_Behemot_Location()
        {
            int Your_Postion_Cave = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You see the Behemoth Caves (Suddenly there were black clouds and a storm came)\n");
                Console.WriteLine("[1] Do you want to enter the cave?\n[2] Get out of here\n");
                Console.Write("What would you like to do: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("\nYou hear something, it's the enemy!\n");
                            Thread.Sleep(1000);
                            Mechanic_system.Combat_System();
                            if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                            {
                                return;
                            }
                            else
                            {
                                Your_Postion_Cave++;
                            }

                            Console.WriteLine("\n[1] You want to go deeper into the cave?\n[2] Get out of here\n");
                            Console.Write("What would you like to do: ");

                            if (Console.ReadLine() == "1")
                            {
                                if (Your_Postion_Cave == 5)
                                {
                                    break;
                                }
                                goto case "1";
                            }
                            else if (Console.ReadLine() == "2")
                            {
                                return;
                            }
                        }
                        break;

                    case "2":
                        {
                            return;
                        }

                    default:
                        {
                            continue;
                        }
                }

                if (Your_Postion_Cave == 5)
                {
                    Console.Clear();
                    while (Your_Postion_Cave == 5)
                    {
                        Console.WriteLine("\n[1]You see a powerful creature in the distance, is it Boss?(Keep going)\n[2] Get out of here\n");

                        Console.Write("What would you like to do: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nYou hear something, it's the enemy!\n");
                                    for (int i_cave = 0; i_cave < 1; i_cave++)
                                    {
                                        Mechanic_system.Attack_mob = new Behemot();
                                        Mechanic_system.Combat_System();


                                        if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                                        {
                                            return;
                                        }
                                        else
                                        {
                                            Your_Postion_Cave++;
                                        }
                                        Console.Clear();
                                    }
                                }
                                break;

                            case "2":
                                {
                                    return;
                                }

                            default:
                                {
                                    continue;
                                }
                        }
                    }
                }

                if (Your_Postion_Cave == 6)
                {
                    Mechanic_system.Attack_mob = null;
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tYou see a chest full of treasures in the distance!\n");
                    Console.WriteLine("\t\t\tYou earned 500 gold\n");
                    Program.Player.Money_Bag += 500;
                    Console.WriteLine("\nYou leave the cave");
                    Console.ReadLine();
                    return;
                }
            }
        }

        public static void Cave_Belziego_Location()
        {
            int Your_Postion_Cave = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You see the Caves of Belzi (Suddenly, red clouds appeared and there was bloody rain)\n");
                Console.WriteLine("[1] Do you want to enter the cave?(Enter it)\n[2] Get out of here\n");
                Console.Write("What would you like to do: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("\nYou hear something, it's the enemy!\n");
                            Thread.Sleep(1000);
                            Mechanic_system.Combat_System();
                            if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                            {
                                return;
                            }
                            else
                            {
                                Your_Postion_Cave++;
                            }

                            Console.WriteLine("\n[1] You want to go deeper into the cave?\n[2] Get out of here\n");
                            Console.Write("What would you like to do: ");

                            if (Console.ReadLine() == "1")
                            {
                                if (Your_Postion_Cave == 5)
                                {
                                    Console.Clear();
                                    break;
                                }
                                goto case "1";
                            }
                            else if (Console.ReadLine() == "2")
                            {
                                return;
                            }
                        }
                        break;

                    case "2":
                        {
                            Your_Postion_Cave--;
                            return;
                        }

                    default:
                        {
                            continue;
                        }
                }

                if (Your_Postion_Cave == 5)
                {
                    while (Your_Postion_Cave == 5)
                    {
                        Console.WriteLine("\n[1] You see a powerful creature in the distance, is it Boss?(Keep going)\n[2] Get out of here\n");

                        Console.Write("What would you like to do: ");

                        switch (Console.ReadLine())
                        {
                            case "1":
                                {
                                    Console.Clear();
                                    Console.WriteLine("\nYou hear something, it's the enemy!\n");
                                    for (int i_cave = 0; i_cave < 1; i_cave++)
                                    {
                                        Mechanic_system.Attack_mob = new Beelzebub();
                                        Mechanic_system.Combat_System();

                                        if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                                        {
                                            return;
                                        }
                                        else
                                        {
                                            Your_Postion_Cave++;
                                        }
                                        Console.Clear();
                                    }

                                }
                                break;

                            case "2":
                                {
                                    return;
                                }

                            default:
                                {
                                    continue;
                                }
                        }
                    }
                }

                if (Your_Postion_Cave == 6)
                {
                    Mechanic_system.Attack_mob = null;
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tYou saw a chest full of treasures in the distance!\n");
                    Console.WriteLine("\t\t\tYou earned 100 gold and 5 Potion of Healing\n");
                    Program.Player.Money_Bag += 500;
                    Console.Write("\t\t\t");
                    Item_Manager.Add_Utitlity(1);
                    Item_Manager.Add_Utitlity(1);
                    Item_Manager.Add_Utitlity(1);
                    Item_Manager.Add_Utitlity(1);
                    Item_Manager.Add_Utitlity(1);
                    Console.WriteLine("\nYou leave the cave");
                    Console.ReadLine();
                    return;
                }
            }
        }

        public static void Village_Goblin()
        {
            int Your_Postion_Cave = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("You see a Village, are there people??\n");
                Console.WriteLine("[1] Do you want to enter the Village?(Enter it)\n[2] Leave here\n");
                Console.Write("What would you like to do: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            if (Your_Postion_Cave <= 3)
                            {
                                Console.Clear();
                                Console.WriteLine("\nYou hear something, it's the enemy!\n");
                                Thread.Sleep(1000);
                                Mechanic_system.Attack_mob = new Goblin();
                                Mechanic_system.Combat_System();
                                if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Your_Postion_Cave++;
                                }
                            }
                            if (Your_Postion_Cave > 3 && Your_Postion_Cave <= 5)
                            {
                                Console.Clear();
                                Console.WriteLine("\nYou hear something, it's the enemy!\n");
                                Thread.Sleep(1000);
                                Mechanic_system.Attack_mob = new Goblin_Rider();
                                Mechanic_system.Combat_System();
                                if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                                {
                                    return;
                                }
                                else
                                {
                                    Your_Postion_Cave++;
                                }
                            }
                            Console.WriteLine("\n[1] You want to go deeper into the Village?\n[2] Get out of here\n");
                            Console.Write("What would you like to do: ");

                            if (Console.ReadLine() == "1")
                            {
                                if (Your_Postion_Cave == 6)
                                {
                                    Console.Clear();
                                    break;
                                }
                                goto case "1";
                            }
                            else if (Console.ReadLine() == "2")
                            {
                                return;
                            }
                        }
                        break;

                    case "2":
                        {
                            Your_Postion_Cave--;
                            return;
                        }

                    default:
                        {
                            continue;
                        }
                }
                if (Your_Postion_Cave == 6)
                {
                    Console.WriteLine("\n[1] Do you want to go deeper into the Village?(Go further)\n[2] Leave here\n");
                    Console.Write("What would you like to do(1-2): ");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            {
                                Console.Clear();
                                Console.WriteLine("\nnYou hear something, it's the enemy!\n");
                                for (int i_cave = 0; i_cave < 1; i_cave++)
                                {
                                    Mechanic_system.Attack_mob = new Goblin_King();
                                    Mechanic_system.Combat_System();

                                    if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                                    {
                                        return;
                                    }
                                    else
                                    {
                                        Your_Postion_Cave++;
                                    }
                                    Console.Clear();
                                }
                            }
                            break;

                        case "2":
                            {
                                return;
                            }

                        default:
                            {
                                continue;
                            }
                    }
                }
                if (Your_Postion_Cave == 7)
                {
                    Mechanic_system.Attack_mob = null;
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tYou saw a chest full of treasures in the distance!\n");
                    Console.WriteLine("\t\t\tYou earned 200 gold and 3 Potion\n");
                    Program.Player.Money_Bag += 500;
                    Console.Write("\t\t\t");
                    Item_Manager.Add_Utitlity(4);
                    Console.Write("\t\t\t");
                    Item_Manager.Add_Utitlity(10);
                    Console.Write("\t\t\t");
                    Item_Manager.Add_Utitlity(12);
                    Console.WriteLine("\nYou leave the village");
                    Console.ReadLine();
                    return;
                }
            }
        }

        public static void Wolves_Lair()
        {
            int Your_Postion_Lair = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hmm, it's too quiet here, what's that strange noise, are those wolves??\n");
                Console.WriteLine("[1] Do you want to enter the cave?\n[2] Get out of here\n");
                Console.Write("What would you like to do: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("\nYou hear something, it's the enemy!\n");
                            Thread.Sleep(1000);
                            Mechanic_system.Combat_System();
                            if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                            {
                                return;
                            }
                            else
                            {
                                Your_Postion_Lair++;
                            }

                            Console.WriteLine("\n[1] You want to go deeper into the cave?\n[2] Get out of here\n");
                            Console.Write("What would you like to do: ");

                            if (Console.ReadLine() == "1")
                            {
                                if (Your_Postion_Lair == 5)
                                {
                                    break;
                                }
                                goto case "1";
                            }
                            else if (Console.ReadLine() == "2")
                            {
                                return;
                            }
                        }
                        break;

                    case "2":
                        {
                            return;
                        }

                    default:
                        {
                            continue;
                        }
                }

                if (Your_Postion_Lair == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\t\t\tYou saw a chest full of treasures in the distance!\n");
                    Console.WriteLine("\t\t\tYou earned 100 golda\n");
                    Program.Player.Money_Bag += 100;
                    Console.WriteLine("\nYou leave the cave");
                    Console.ReadLine();
                    return;
                }
            }
        }

        public static void Pig_Glade()
        {
            while (true)
            {
                Console.WriteLine("You see some strange creatures in the distance, they look like people, but they are ugly, they are probably pigs?");
                Console.WriteLine("[1] Yes\n [2] No\n");
                Console.WriteLine("You want to attack them?:");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            int Pig_count = 5;
                            Console.Clear();
                            Console.WriteLine("\n[*chrum chrum] You hear something, it's a pig!\n");
                            Thread.Sleep(1000);

                            Mechanic_system.Combat_System();

                            if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
                            {
                                return;
                            }

                            Console.WriteLine("[1] Yes\n[2] No\n");
                            Console.Write("You want to attack another one?:");

                            if (Console.ReadLine() == "1" && Pig_count > 0)
                            {
                                Pig_count--;
                                goto case "1";
                            }
                            else if (Pig_count == 0)
                            {
                                Console.WriteLine("You have already killed all the pigs, you murderer!!!");
                            }
                            else if (Console.ReadLine() == "2")
                            {
                                return;
                            }
                        }
                        break;

                    case "2":
                        {
                            return;
                        }

                    default:
                        {

                        }
                        break;
                }
            }
        }
    }
}