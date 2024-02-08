using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using Game_RPG.StructureClass;


namespace Game_RPG.PlayerClass
{
    public class Hero_Model
    {
        //listy
        public List<Skill_Model> My_Skill_List { get; set; } = new();
        public List<Weapons_Items> Weapons_Character { get; set; } = new();
        public List<Armors_Items> Armors_Character { get; set; } = new();
        public List<Utitlity_Items> Utitlity_Character { get; set; } = new();
        public List<Monsters_Items> Monsters_Character { get; set; } = new();
        public List<Tasks> Tasks_Character { get; set; } = new();

        //zmienne
        public string Name_Character;
        public int Lvl_Character;
        public int Exp_Character;
        public string Class_Character;
        public int Money_Bag;

        public int Strength_Character;
        public int Intelligence_Character;
        public int Dexterity_Character;
        public int Stamina_Character;
        public int HP_Character;
        public int MP_Character;
        public int MaxHP_Character;
        public int MaxMP_Character;

        public int Defence_Character;
        public int Attack_Character;

        public Weapons_Items Weapon_Character;
        public Armors_Items Helmet_Character;
        public Armors_Items ChestPlate_Character;
        public Armors_Items Legging_Character;
        public Armors_Items Boots_Character;

        //konstruktorek
        public Hero_Model(string Name_character, int Lvl_character, int Exp_character, string Class_character, int Money_bag, int Strength_character, int Intelligence_character, int Dexterity_character, int Stamina_character, int HP_character, int MaxHP_character, int MP_character, int MaxMP_character)
        {
            Name_Character = Name_character;
            Lvl_Character = Lvl_character;
            Exp_Character = Exp_character;
            Class_Character = Class_character;
            Money_Bag = Money_bag;

            Strength_Character = Strength_character;
            Intelligence_Character = Intelligence_character;
            Dexterity_Character = Dexterity_character;
            Stamina_Character = Stamina_character;
            HP_Character = HP_character;
            MP_Character = MP_character;
            MaxHP_Character = MaxHP_character;
            MaxMP_Character = MaxMP_character;
            Defence_Character = 0;
            Attack_Character = Strength_character / 2;
        }
        //Karta postaci
        public void View_Card()
        {
            Console.Clear();
            Console.Write(
                $"Informacje\n\n" +
                $"\tName: {Name_Character}\n" +
                $"\tLvl: {Lvl_Character}\n" +
                $"\tAmount of exp: {Exp_Character}\n" +
                $"\tClass: {Class_Character}\n" +
                $"\tWallet: {Money_Bag} gold\n" +
                $"\n" +
                $"Stats\n\n" +
                $"\tHP: {HP_Character}/{MaxHP_Character}\n" +
                $"\tMP: {MP_Character}/{MaxMP_Character}\n" +
                $"\tAttack: {Attack_Character}\n" +
                $"\tDefense: {Defence_Character}\n" +
                $"\tStrength: {Strength_Character}\n" +
                $"\tIntelligence: {Intelligence_Character}\n" +
                $"\tDexterity: {Dexterity_Character}\n" +
                $"\tStamin: {Stamina_Character}\n" +
                $"\n\n\n");

            Console.WriteLine("Your eq: \n");

            if (Weapon_Character != null)
            {
                Console.WriteLine($"{Weapon_Character.Name_Item} - {Weapon_Character.Info_Item}\n");
            }

            if (Helmet_Character != null)
            {
                Console.WriteLine($"{Helmet_Character.Name_Item} - {Helmet_Character.Info_Item}\n");
            }

            if (ChestPlate_Character != null)
            {
                Console.WriteLine($"{ChestPlate_Character.Name_Item} - {ChestPlate_Character.Info_Item}\n");
            }

            if (Legging_Character != null)
            {
                Console.WriteLine($"{Legging_Character.Name_Item} - {Legging_Character.Info_Item}\n");
            }

            if (Boots_Character != null)
            {
                Console.WriteLine($"{Boots_Character.Name_Item} - {Boots_Character.Info_Item}\n");
            }

            Console.WriteLine("Skills:\n");

            foreach (var My_Skill_list in My_Skill_List)
            {
                Console.WriteLine($"ID: {My_Skill_list.ID_Skill} Name: {My_Skill_list.Name_Skill} Mana: {My_Skill_list.Cost_Skill} Damage: {My_Skill_list.Damage_Skill} ");
            }

            Console.WriteLine("\nQuesty");

            foreach (var My_Task in Tasks_Character)
            {
                Console.WriteLine($"ID: {My_Task.ID_Task} Name: {My_Task.Name_Task} Requirements: {My_Task.Status_Requirements_Task}/{My_Task.Requirements_Task} Reward: {My_Task.Reward_Task} gold");
            }

            Console.ReadLine();
            Console.Clear();
        }

        public void ShowSkill()
        {
            Console.WriteLine("\nSkills");
            foreach (var My_Skill_list in My_Skill_List)
            {
                Console.WriteLine($"ID: {My_Skill_list.ID_Skill} Name: {My_Skill_list.Name_Skill} Mana: {My_Skill_list.Cost_Skill} Damage: {My_Skill_list.Damage_Skill} ");
            }
        }

        public void ShowTask()
        {
            Console.WriteLine("\nQuests");
            foreach (var My_Task in Tasks_Character)
            {
                Console.WriteLine($"ID: {My_Task.ID_Task} Name: {My_Task.Name_Task} Requirements: {My_Task.Status_Requirements_Task}/{My_Task.Requirements_Task} Reward: {My_Task.Reward_Task} gold");
            }
        }

        //Eq gracza
        public void Eq_Player()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("[1] - Utitlity\n[2] - Monsters\n[3] - Weapons\n[4] - Armors\n[5] - Wyjśćie");
                Console.Write("What do you want to see?: ");
                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            bool isValidInput = false;
                            do
                            {



                                Console.Clear();
                                Console.WriteLine("Utitlity:");

                                foreach (var Show_Items in Utitlity_Character)
                                {
                                    Console.WriteLine($"ID: {Show_Items.ID_Item}, Nazwa: {Show_Items.Name_Item}, Ilość: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                                }

                                Console.Write("[1] - Yes\n[2] - No\n");
                                Console.Write("Would you like to use any item?: ");
                                string userInput = Console.ReadLine();

                                if (userInput == "1")
                                {

                                    int ID_itemUse;

                                    Console.Write("Enter ID: ");
                                    string input = Console.ReadLine();

                                    if (int.TryParse(input, out ID_itemUse))
                                    {
                                        isValidInput = true;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    if (Program.Player.Utitlity_Character.FirstOrDefault(SearchUtitlity => SearchUtitlity.ID_Item == ID_itemUse) != null)
                                    {
                                        Program.Player.UseItem(ID_itemUse); //zrobic tą metode
                                    }
                                    else
                                    {
                                        Console.WriteLine("There is no such item with id in your eq");
                                        Thread.Sleep(1500);
                                    }

                                }
                                else if (userInput == "2")
                                {
                                    Console.Write("Exit");
                                    Thread.Sleep(1000);
                                    break;
                                }

                            } while (!isValidInput);
                        }
                        break;

                    case "2":
                        {
                            Console.WriteLine("Monsters:");
                            foreach (var Show_Items in Monsters_Character)
                            {
                                Console.WriteLine($"ID: {Show_Items.ID_Item}, Nazwa: {Show_Items.Name_Item}, Ilość: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                            }
                            Console.Write("[Kliknij enter aby wyjść]");
                            Console.ReadLine();
                        }
                        break;

                    case "3":
                        {
                            bool isValidInput = false;
                            while (!isValidInput)
                            {
                                Console.Clear();
                                Console.WriteLine("Weapons:");
                                foreach (var Show_Items in Weapons_Character)
                                {
                                    Console.WriteLine($"ID: {Show_Items.ID_Item}, Name: {Show_Items.Name_Item}, Quantity: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                                }
                                Console.WriteLine("\n[1]Yes\n[2]No\n");
                                Console.Write("Do you want to set something up?: ");
                                string userInput = Console.ReadLine();

                                if (userInput == "1")
                                {

                                    Console.Clear();

                                    Console.WriteLine("Weapons:");
                                    foreach (var Show_Items in Weapons_Character)
                                    {
                                        Console.WriteLine($"ID: {Show_Items.ID_Item}, Name: {Show_Items.Name_Item}, Quantity: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    Console.WriteLine($"\nYou now - {Weapon_Character.Name_Item} - {Weapon_Character.Info_Item}\n");
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    int ID_Weapons_Character;

                                    Console.WriteLine();
                                    Console.Write("Enter the ID of the item you want to establish: ");
                                    string input = Console.ReadLine();

                                    if (int.TryParse(input, out ID_Weapons_Character))
                                    {
                                        isValidInput = true;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    if (Program.Player.Weapons_Character.FirstOrDefault(weapon => weapon.ID_Item == ID_Weapons_Character) != null)
                                    {
                                        if (Program.Player.Weapon_Character != null)
                                        {
                                            Program.Player.Attack_Character -= Program.Player.Weapon_Character.Attack_Item;
                                            Weapons_Character.Add(Item_Manager.Weapons_items.FirstOrDefault(weapon => weapon.ID_Item == Weapon_Character.ID_Item));

                                            Program.Player.Weapon_Character = Program.Player.Weapons_Character.FirstOrDefault(weapon => weapon.ID_Item == ID_Weapons_Character);
                                            Weapons_Character.Remove(Program.Player.Weapons_Character.FirstOrDefault(weapon => weapon.ID_Item == ID_Weapons_Character));

                                            Program.Player.Attack_Character += Program.Player.Weapon_Character.Attack_Item;

                                        }

                                        else if (Program.Player.Weapon_Character == null)
                                        {
                                            Program.Player.Weapon_Character = Program.Player.Weapons_Character.FirstOrDefault(weapon => weapon.ID_Item == ID_Weapons_Character);
                                            Weapons_Character.Remove(Program.Player.Weapons_Character.FirstOrDefault(weapon => weapon.ID_Item == ID_Weapons_Character));

                                            Program.Player.Attack_Character += Program.Player.Weapon_Character.Attack_Item;
                                        }

                                        Console.WriteLine("You equipped the Weapon");
                                        Thread.Sleep(1000);
                                        break;
                                    }
                                }

                                else if (userInput == "2")
                                {
                                    Console.Write("Exit");
                                    break;
                                }
                            }
                        }
                        break;

                    case "4":
                        {
                            bool isValidInput = false;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Armors:");
                                foreach (var Show_Items in Armors_Character)
                                {
                                    Console.WriteLine($"ID: {Show_Items.ID_Item}, Name: {Show_Items.Name_Item}, Quantity: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                                }
                                Console.WriteLine("\n[1]Yes\n[2]No\n");
                                Console.Write("Do you want to wear something?: ");
                                string userInput = Console.ReadLine();

                                if (userInput == "1")
                                {
                                    Console.Clear();
                                    Console.WriteLine("Armors:");
                                    foreach (var Show_Items in Armors_Character)
                                    {
                                        Console.WriteLine($"ID: {Show_Items.ID_Item}, Name: {Show_Items.Name_Item}, Quantity: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                                    }
                                    Console.WriteLine();
                                    Console.WriteLine("----------------------------------------------------------------------");

                                    if (Helmet_Character != null)
                                    {
                                        Console.WriteLine($"You now - {Helmet_Character.Name_Item} - {Helmet_Character.Info_Item}\n");
                                    }

                                    if (ChestPlate_Character != null)
                                    {
                                        Console.WriteLine($"You now - {ChestPlate_Character.Name_Item} - {ChestPlate_Character.Info_Item}\n");
                                    }

                                    if (Legging_Character != null)
                                    {
                                        Console.WriteLine($"You now - {Legging_Character.Name_Item} - {Legging_Character.Info_Item}\n");
                                    }

                                    if (Boots_Character != null)
                                    {
                                        Console.WriteLine($"You now - {Boots_Character.Name_Item} - {Boots_Character.Info_Item}\n");
                                    }
                                    Console.WriteLine("----------------------------------------------------------------------");
                                    int ID_Armors_Character;
                                    Console.Write("Enter the ID of the item you want to create: ");
                                    string input = Console.ReadLine();

                                    if (int.TryParse(input, out ID_Armors_Character))
                                    {
                                        isValidInput = true;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                    Armors_Items Armor_Item = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                    if (Armor_Item != null)
                                    {
                                        if (Armor_Item.Name_Item.ToLower().Contains("helmet"))
                                        {
                                            if (Program.Player.Helmet_Character != null)
                                            {
                                                Program.Player.Defence_Character -= Armor_Item.Defense_Item;
                                                Armors_Character.Add(Item_Manager.Armors_items.FirstOrDefault(armor => armor.ID_Item == Helmet_Character.ID_Item));

                                                Program.Player.Helmet_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.Helmet_Character.Defense_Item;
                                            }

                                            else if (Program.Player.Helmet_Character == null)
                                            {
                                                Program.Player.Helmet_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.Helmet_Character.Defense_Item;
                                            }

                                            Console.WriteLine("You put on the Helmet");
                                            Thread.Sleep(2000);
                                        }

                                        else if (Armor_Item.Name_Item.ToLower().Contains("chestplate"))
                                        {
                                            if (Program.Player.ChestPlate_Character != null)
                                            {
                                                Program.Player.Defence_Character -= Armor_Item.Defense_Item;
                                                Armors_Character.Add(Item_Manager.Armors_items.FirstOrDefault(armor => armor.ID_Item == ChestPlate_Character.ID_Item));

                                                Program.Player.ChestPlate_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.ChestPlate_Character.Defense_Item;
                                            }

                                            else if (Program.Player.ChestPlate_Character == null)
                                            {
                                                Program.Player.ChestPlate_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.ChestPlate_Character.Defense_Item;
                                            }

                                            Console.WriteLine("You put on the ChestPlate");
                                            Thread.Sleep(1000);
                                        }

                                        else if (Armor_Item.Name_Item.ToLower().Contains("legging"))
                                        {
                                            if (Program.Player.Legging_Character != null)
                                            {
                                                Program.Player.Defence_Character -= Armor_Item.Defense_Item;
                                                Armors_Character.Add(Item_Manager.Armors_items.FirstOrDefault(armor => armor.ID_Item == Legging_Character.ID_Item));

                                                Program.Player.Legging_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.Legging_Character.Defense_Item;
                                            }

                                            else if (Program.Player.Legging_Character == null)
                                            {
                                                Program.Player.Legging_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.Legging_Character.Defense_Item;
                                            }

                                            Console.WriteLine("You put on pants");
                                            Thread.Sleep(1000);
                                        }

                                        else if (Armor_Item.Name_Item.ToLower().Contains("boots"))
                                        {
                                            if (Program.Player.Boots_Character != null)
                                            {
                                                Program.Player.Defence_Character -= Armor_Item.Defense_Item;
                                                Armors_Character.Add(Item_Manager.Armors_items.FirstOrDefault(armor => armor.ID_Item == Boots_Character.ID_Item));

                                                Program.Player.Boots_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.Boots_Character.Defense_Item;
                                            }

                                            else if (Program.Player.Boots_Character == null)
                                            {
                                                Program.Player.Boots_Character = Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character);
                                                Armors_Character.Remove(Program.Player.Armors_Character.FirstOrDefault(armor => armor.ID_Item == ID_Armors_Character));

                                                Program.Player.Defence_Character += Program.Player.Boots_Character.Defense_Item;
                                            }

                                            Console.WriteLine("You put on your Shoes");
                                            Thread.Sleep(1000);
                                        }

                                        else
                                        {
                                            Console.Write("Exit");
                                            Thread.Sleep(1000);
                                            break;
                                        }
                                    }
                                }

                                else if (userInput == "2")
                                {
                                    Console.Write("Exit");
                                    break;
                                }

                            } while (!isValidInput);
                        }
                        break;

                    case "5":
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

        public void Lvl_Up()
        {
            Console.Write(
                "You've reached a new level!\n\n" +
                "Your statistics have increased and HP and MP have been restored :\n\n" +
                "Strength +1\n" +
                "Intelligence +1\n" +
                "Dexterity +1\n" +
                "Stamin +1\n" +
                "Life +10\n" +
                "Mana +5\n\n" +
                "Click enter to continue\n\n");

            if (Lvl_Character <= 5)
            {
                Lvl_Character += 1;
                Exp_Character -= 5;

            }

            else if (Lvl_Character > 5 && Lvl_Character <= 10)
            {
                Lvl_Character += 1;
                Exp_Character -= 10;

            }

            else if (Lvl_Character > 10 && Lvl_Character <= 20)
            {
                Lvl_Character += 1;
                Exp_Character -= 20;
            }

            else if (Lvl_Character > 20 && Lvl_Character <= 30)
            {
                Lvl_Character += 1;
                Exp_Character -= 40;
            }

            Strength_Character += 1;
            Intelligence_Character += 1;
            Dexterity_Character += 1;
            Stamina_Character += 1;
            HP_Character += 10;
            MaxHP_Character += 10;
            HP_Character = MaxHP_Character;
            MP_Character += 5;
            MaxMP_Character += 5;
            MP_Character = MaxMP_Character;
            Attack_Character++;

            if (Lvl_Character == 2)
            {
                Skill_Model Skill_Add = Skill_List.Search_Magic_Skill(0);
                My_Skill_List.Add(Skill_Add);
                Console.WriteLine($"NOWAY you have unlocked a new skill {Skill_Add.Name_Skill}");
            }

            if (Lvl_Character == 3)
            {
                Skill_Model Skill_Add = Skill_List.Search_Magic_Skill(1);
                My_Skill_List.Add(Skill_Add);
                Console.WriteLine($"NOWAY you have unlocked a new skill {Skill_Add.Name_Skill}");
            }

            if (Lvl_Character == 4)
            {
                Skill_Model Skill_Add = Skill_List.Search_Magic_Skill(2);
                My_Skill_List.Add(Skill_Add);
                Console.WriteLine($"NOWAY you have unlocked a new skill {Skill_Add.Name_Skill}");
            }

            if (Lvl_Character == 5)
            {
                Skill_Model Skill_Add = Skill_List.Search_Magic_Skill(3);
                My_Skill_List.Add(Skill_Add);
                Console.WriteLine($"NOWAY you have unlocked a new skill {Skill_Add.Name_Skill}");
            }

            if (Lvl_Character == 6)
            {
                Skill_Model Skill_Add = Skill_List.Search_Magic_Skill(4);
                My_Skill_List.Add(Skill_Add);
                Console.WriteLine($"NOWAY you have unlocked a new skill {Skill_Add.Name_Skill}");
            }
            Console.ReadLine();
            Console.Clear();
        }

        public bool UseItem(int ItemiD)
        {
            Utitlity_Items Utitlity_item = Utitlity_Character.FirstOrDefault(item => item.ID_Item == ItemiD);

            if (Utitlity_item != null && Utitlity_item.ID_Item >= 0 && Utitlity_item.ID_Item <= 3)
            {
                if (Utitlity_item.ID_Item == 0) //Small_Potion_of_Healing
                {
                    if (HP_Character == MaxHP_Character)
                    {
                        return false;
                    }
                    else if (HP_Character + 25 > MaxHP_Character)
                    {
                        HP_Character = MaxHP_Character;
                    }
                    else
                    {
                        HP_Character += 25;
                    }
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 1) //Potion_of_Healing
                {
                    if (HP_Character == MaxHP_Character)
                    {
                        return false;
                    }
                    else if (HP_Character + 50 > MaxHP_Character)
                    {
                        HP_Character = MaxHP_Character;
                    }
                    else
                    {
                        HP_Character += 50;
                    }
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 2) // Small_Mana_Potion
                {
                    if (MP_Character == MaxMP_Character)
                    {
                        return false;
                    }
                    else if (MP_Character + 50 > MaxMP_Character)
                    {
                        MP_Character = MaxMP_Character;
                    }
                    else
                    {
                        MP_Character += 50;
                    }
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 3) // Mana_Potion
                {

                    if (MP_Character == MaxMP_Character)
                    {
                        return false;
                    }
                    else if (MP_Character + 50 > MaxMP_Character)
                    {
                        MP_Character = MaxMP_Character;
                    }
                    else
                    {
                        MP_Character += 50;
                    }
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }
                Console.WriteLine($"You use an item: {Utitlity_item.Name_Item}");
                Thread.Sleep(2000);
                return true;
            }

            else if (Utitlity_item != null && Utitlity_item.ID_Item >= 4 && Utitlity_item.ID_Item <= 15)
            {
                if (Utitlity_item.ID_Item == 4) // Strength_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Strength_Character += 2;
                        Attack_Character += 1;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Strength_Character += 2;
                        Attack_Character += 1;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 5) // Large_Strength_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Strength_Character += 5;
                        Attack_Character += 3;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Strength_Character += 5;
                        Attack_Character += 3;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 6) // Intelligency_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Intelligence_Character += 2;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Intelligence_Character += 2;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 7) // Large_Intelligency_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Intelligence_Character += 5;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Intelligence_Character += 5;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 8) // Dexterity_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Dexterity_Character += 2;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Dexterity_Character += 2;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 9) // Large_Dexterity_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Dexterity_Character += 5;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Dexterity_Character += 5;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 10) // Stamina_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Stamina_Character += 2;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Stamina_Character += 2;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 11) // Large_Stamina_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        Stamina_Character += 5;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        Stamina_Character += 5;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 12) // HP_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        HP_Character += 10;
                        MaxHP_Character += 10;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        HP_Character += 10;
                        MaxHP_Character += 10;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 13) // Large_HP_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        HP_Character += 20;
                        MaxHP_Character += 20;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        HP_Character += 20;
                        MaxHP_Character += 20;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 14) // MP_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        MP_Character += 10;
                        MaxMP_Character += 10;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        MP_Character += 10;
                        MaxMP_Character += 10;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }

                else if (Utitlity_item.ID_Item == 15) // Large_MP_Potion
                {
                    if (Utitlity_item.Quantity_Item > 1)
                    {
                        MP_Character += 20;
                        MaxMP_Character += 20;
                        Utitlity_item.Quantity_Item--;
                    }
                    else
                    {
                        MP_Character += 20;
                        MaxMP_Character += 20;
                        Utitlity_Character.Remove(Utitlity_item);
                    }
                }
                Console.WriteLine($"You use an item: {Utitlity_item.Name_Item}");
                Thread.Sleep(2000);
                return true;
            }

            else if (Utitlity_item != null && Utitlity_item.ID_Item >= 16 && Utitlity_item.ID_Item <= 17)
            {
                if (Utitlity_item.ID_Item == 16) // Teleport_Stone
                {

                }

                else if (Utitlity_item.ID_Item == 17) // Picklock
                {

                }
                Console.WriteLine($"You use an item: {Utitlity_item.Name_Item}");
                Thread.Sleep(2000);
                return true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine("You don't have the item specified ID.");
                Thread.Sleep(1000);
                return false;
            }
        }
    }
}

