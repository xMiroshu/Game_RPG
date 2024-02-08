using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Game_RPG.PlayerClass;
using Game_RPG.StructureClass;

namespace Game_RPG
{
    class Mechanic_system
    {
        public static Mob_Model Attack_mob
        {
            get; set;
        }

        public static void Character_Create()
        {
            while (true)
            {
                Console.Write("What is your name?: ");
                string Name_Character = Console.ReadLine();
                // Sprawdź czy użytkownik wprowadził jakiekolwiek dane
                if (Name_Character == "")
                {
                    Console.WriteLine("You must provide a name!");
                    continue; // Kontynuuj pętlę od początku
                }
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(
                    "****************************************\n" +
                    "\n" +
                    "[1] Mag\n" +
                    "[2] Warrior\n" +
                    "[3] Archer\n" +
                    "\n" +
                    "****************************************\n"
                    );
                while (true)
                {
                    Console.Write("What class do you want to choose(1-3)?: ");
                    string Class_characters = Console.ReadLine();
                    if (Class_characters == "1")
                    {
                                                        //Name, Lvl, Exp, Class, Gold, Str, Int, Dex, Stam, HP, MP
                        Program.Player = new Hero_Model(Name_Character, 1, 0, "Mag", 0, 5, 15, 5, 5, 25, 25, 150, 150); 
                        Skill_Model Skill_Add = Skill_List.Search_Magic_Skill(0);
                        Program.Player.My_Skill_List.Add(Skill_Add);
                        return;
                    }
                    else if (Class_characters == "2")
                    {
                        Program.Player = new Hero_Model(Name_Character, 1, 0, "Warrior", 0, 15, 5, 10, 20, 100, 100, 50, 50);
                        return;
                    }
                    else if (Class_characters == "3")
                    {
                        Program.Player = new Hero_Model(Name_Character, 1, 0, "Archer", 0, 10, 5, 15, 10, 50, 50, 50, 50);
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Wrong choice, choose again");
                    }
                }
            }
        } // Tworzenie postaci

        public static bool EscapeOrNot()
        {
            Random random = new();
            int escapeOrNot = random.Next(2);
            if (escapeOrNot == 0)
            {
                Mechanic_system.Attack_mob = null;
                return true;
            }
            else
            {
                return false;
            }
        } //Szansa na ucieczke

        public static Mob_Model AttackMob_Random()
        {
            Locations_Model MobLocation = Interaction_Locationst.Locations.FirstOrDefault(locat => locat.X_Map == Program.X_Position_Player && locat.Y_Map == Program.Y_Position_Player);

            if (MobLocation.Name_Map == "Pig Glade")
            {
                return new Pig();
            }

            else if (MobLocation.Name_Map == "Beelzebub dungeons")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                switch (attackMob_Random)
                {
                    case 0:
                        {
                            return new Zombie();
                        }
                    case 1:
                        {
                            return new Zombie();
                        }
                    case 2:
                        {
                            return new Wolf();
                        }
                    case 3:
                        {
                            return new Zombie();
                        }
                    case 4:
                        {
                            return new Wolf();
                        }
                    default:
                        throw new Exception("Monster draw error.");
                }
            }

            else if (MobLocation.Name_Map == "West Forest")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Slime(),
                    1 => new Slime(),
                    2 => new Goblin(),
                    3 => new Troll(),
                    4 => new Slime(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "Mysterious Cave")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Big_Spider(),
                    1 => new Troll(),
                    2 => new Big_Spider(),
                    3 => new Big_Spider(),
                    4 => new Slime(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "Goblin Village")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Goblin(),
                    1 => new Goblin_Rider(),
                    2 => new Goblin(),
                    3 => new Goblin_Rider(),
                    4 => new Goblin(),
                    5 => new Goblin(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "North Forest")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Slime(),
                    1 => new Slime(),
                    2 => new Goblin(),
                    3 => new Troll(),
                    4 => new Slime(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "Southern Forest")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Slime(),
                    1 => new Slime(),
                    2 => new Goblin(),
                    3 => new Troll(),
                    4 => new Slime(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "Behemot Cave")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Troll(),
                    1 => new Big_Spider(),
                    2 => new Zombie(),
                    3 => new Big_Spider(),
                    4 => new Slime(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "East Forest")
            {
                Random random = new();
                int attackMob_Random = random.Next(5);

                return attackMob_Random switch
                {
                    0 => new Slime(),
                    1 => new Slime(),
                    2 => new Goblin(),
                    3 => new Troll(),
                    4 => new Slime(),
                    _ => throw new Exception("Monster draw error."),
                };
            }

            else if (MobLocation.Name_Map == "Wolves' Lair")
            {
                return new Wolf();
            }

            return new Slime();
        } //Losowanie co ciebie zaatakuje

        public static void Combat_System()
        {
            do
            {
                if(Attack_mob==null)
                {
                    Attack_mob = AttackMob_Random();
                }
                Attack_mob_Text(Attack_mob.Name_Mob);

                switch (Console.ReadLine())
                {
                        case "1":
                        {
                            Thread.Sleep(500);
                            Console.Clear();
                            if (Combat_System_Views())
                            {
                                if (Program.Player.Tasks_Character != null)
                                {
                                    foreach (Tasks YourTask in Program.Player.Tasks_Character)
                                    {
                                        if (YourTask.Name_Mob_Task == Attack_mob.Name_Mob && YourTask.Status_Requirements_Task < YourTask.Requirements_Task)
                                        {
                                            YourTask.Status_Requirements_Task += 1;
                                        }
                                    }
                                    Thread.Sleep(1000);
                                }

                                if (Program.Player.Lvl_Character <= 5 && Program.Player.Exp_Character >= 5)
                                {
                                    Program.Player.Lvl_Up();
                                }
                                else if (Program.Player.Lvl_Character > 5 && Program.Player.Lvl_Character <= 10 && Program.Player.Exp_Character >= 10)
                                {
                                    Program.Player.Lvl_Up();
                                }
                                else if (Program.Player.Lvl_Character > 10 && Program.Player.Lvl_Character <= 20 && Program.Player.Exp_Character >= 20)
                                {
                                    Program.Player.Lvl_Up();
                                }
                                else if (Program.Player.Lvl_Character > 20 && Program.Player.Exp_Character >= 40)
                                {
                                    Program.Player.Lvl_Up();
                                }
                            }
                            else
                            {
                                Program.X_Position_Player = 0;
                                Program.Y_Position_Player = 0;
                                Program.Player.HP_Character = Program.Player.MaxHP_Character;
                                Program.Player.MP_Character = Program.Player.MaxMP_Character;
                            }
                            Attack_mob = null;
                            return;
                        }
                        case "2":
                        {
                            bool escapeOrNot = Mechanic_system.EscapeOrNot();
                            if (escapeOrNot)
                            {
                                Console.WriteLine("You managed to escape");
                                Thread.Sleep(500);
                                Console.Clear();
                                return;
                            }
                            else
                            {
                                goto case "1";
                            }
                        }
                        default:
                        {
                            Console.WriteLine("No way!");
                            Thread.Sleep(500);
                            Console.Clear();
                            continue;
                        }
                }
            } while (true);
        } //Atak lub Ucieczka

        public static bool Combat_System_Views ()
        {
            bool Win_OR_Lost = false;
            Program.Game_Option = "Attack";

            while (Program.Game_Option == "Attack")
            {
                Console.Clear();

                Console.WriteLine("{0}\n \t[HP - {1}/{2}]\n \t[MP - {3}/{4}]\n\n\n\n", Attack_mob.Name_Mob, Attack_mob.HP_Mob, Attack_mob.MaxHP_Mob, Attack_mob.MP_Mob, Attack_mob.MaxMP_Mob);
                Console.WriteLine("{0} - Lvl: {1} EXP: {2}\n \t[HP - {3}/{4}]\n \t[MP - {5}/{6}]\n", Program.Player.Name_Character, Program.Player.Lvl_Character, Program.Player.Exp_Character, Program.Player.HP_Character, Program.Player.MaxHP_Character, Program.Player.MP_Character, Program.Player.MaxMP_Character);

                Console.WriteLine("[1] Attack");
                Console.WriteLine("[2] Skills");
                Console.WriteLine("[3] Eq");
                Console.WriteLine("[4] Escape(ADMIN_OPTION)\n");
                Console.Write("What do you want to do?: ");

                switch (Console.ReadLine())
                {
                        case "1":
                        {
                            if (Program.Player.Dexterity_Character > Attack_mob.Dexterity_Mob)
                            {
                                First_Attack_Player(ref Win_OR_Lost);
                                if (Attack_mob.HP_Mob > 0)
                                {
                                    First_Attack_Mob(ref Win_OR_Lost);
                                }
                            }
                            else if (Program.Player.Dexterity_Character < Attack_mob.Dexterity_Mob)
                            {
                                First_Attack_Mob(ref Win_OR_Lost);
                                if (Program.Player.HP_Character > 0)
                                {
                                    First_Attack_Player(ref Win_OR_Lost);
                                }
                            }
                            else if (Program.Player.Dexterity_Character == Attack_mob.Dexterity_Mob)
                            {
                                if (EscapeOrNot())
                                {
                                    First_Attack_Player(ref Win_OR_Lost);
                                    if (Attack_mob.HP_Mob > 0)
                                    {
                                        First_Attack_Mob(ref Win_OR_Lost);
                                    }
                                }
                                else
                                {
                                    First_Attack_Mob(ref Win_OR_Lost);
                                    if (Program.Player.HP_Character > 0)
                                    {
                                        First_Attack_Player(ref Win_OR_Lost);
                                    }
                                }
                            }
                            Thread.Sleep(1000);
                            Console.Clear();
                        }
                        break;

                        case "2":
                        {
                            Program.Player.ShowSkill();
                            try
                            {
                                Console.Write("Which Skill do you want to use??(ID): ");
                                int Skill_iD = Convert.ToInt32(Console.ReadLine());

                                Skill_Model Skill_Use = Program.Player.My_Skill_List.FirstOrDefault(Skill_Use_Now => Skill_Use_Now.ID_Skill == Skill_iD);
                                if (Skill_Use != null)
                                {
                                    if (Program.Player.MP_Character >= Skill_Use.Cost_Skill)
                                    {
                                        Console.WriteLine("You used a skill {0}!", Skill_Use.Name_Skill);
                                        Program.Player.MP_Character -= Skill_Use.Cost_Skill;
                                        if (Program.Player.Dexterity_Character > Attack_mob.Dexterity_Mob)
                                        {
                                            First_Attack_Player_Magic(Skill_Use.Damage_Skill,ref Win_OR_Lost);
                                            if (Attack_mob.HP_Mob > 0)
                                            {
                                                First_Attack_Mob(ref Win_OR_Lost);
                                            }
                                        }
                                        else if (Program.Player.Dexterity_Character < Attack_mob.Dexterity_Mob)
                                        {
                                            First_Attack_Mob(ref Win_OR_Lost);
                                            if (Program.Player.HP_Character > 0)
                                            {
                                                First_Attack_Player_Magic(Skill_Use.Damage_Skill, ref Win_OR_Lost);
                                            }
                                        }
                                        else if (Program.Player.Dexterity_Character == Attack_mob.Dexterity_Mob)
                                        {
                                            if (EscapeOrNot())
                                            {
                                                First_Attack_Player_Magic(Skill_Use.Damage_Skill, ref Win_OR_Lost);
                                                if (Attack_mob.HP_Mob > 0)
                                                {
                                                    First_Attack_Mob(ref Win_OR_Lost);
                                                }
                                            }
                                            else
                                            {
                                                First_Attack_Mob(ref Win_OR_Lost);
                                                if (Program.Player.HP_Character > 0)
                                                {
                                                    First_Attack_Player_Magic(Skill_Use.Damage_Skill, ref Win_OR_Lost);
                                                }
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("You don't have enough mana");
                                    }
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("There is no such skill");
                                    Thread.Sleep(1000);
                                }
                            }
                            catch
                            {
                                Console.Write("There is no such skill");
                                Thread.Sleep(1000);
                                break;
                            }
                        }
                        break;


                        case "3":
                        {
                            try
                            {

                                Console.Clear();
                                Console.WriteLine("Utitlity:");
                                foreach (var Show_Items in Program.Player.Utitlity_Character)
                                {
                                    Console.WriteLine($"ID: {Show_Items.ID_Item}, Name: {Show_Items.Name_Item}, Quantity: {Show_Items.Quantity_Item}, Info: {Show_Items.Info_Item}");
                                }
                                Console.Write("Enter the ID of the item you want to use (Enter = Exit): ");
                                int ID_eq = Convert.ToInt32(Console.ReadLine());
                                if (Program.Player.UseItem(ID_eq))
                                {
                                    First_Attack_Mob(ref Win_OR_Lost);
                                    Console.Clear();
                                }
                                else
                                {
                                    Console.WriteLine("You couldn't use the item");
                                    Console.ReadLine();
                                    goto case "3";
                                }
                            }
                            catch (FormatException)
                            {
                                Console.Clear();
                                Thread.Sleep(1000);
                                continue;
                            }
                        }
                        break;

                        case "4":
                        {
                            bool escapeOrNot = Mechanic_system.EscapeOrNot();
                            if (escapeOrNot)
                            {
                                Console.WriteLine("You managed to escape, but");
                                Console.WriteLine("You were defeated by {0} :(", Attack_mob.Name_Mob);
                                Console.ReadLine();
                                Console.Clear();
                                Program.Game_Option = "New_Game";
                                Win_OR_Lost = false;
                                return Win_OR_Lost;
                            }
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
            return Win_OR_Lost;
        } // Staty, wybór Atak/Eq/Umki

        public static void First_Attack_Player(ref bool Win_OR_Lost)
        {
            if((Program.Player.Attack_Character - Attack_mob.Defence_Mob) >=0)
            {
                Attack_mob.HP_Mob -= (Program.Player.Attack_Character - (Attack_mob.Defence_Mob/2));
                Console.WriteLine("\nYou dealt {0} damage", (Program.Player.Attack_Character - Attack_mob.Defence_Mob));
            }
            else
            {
                Console.WriteLine("\nYou took 0 damage");
            }

            if (Attack_mob.HP_Mob <= 0)
            {
                Console.WriteLine("\n\n\n\n\tYou defeated {0} !!!", Attack_mob.Name_Mob);
                Console.WriteLine("\tGet {0} EXP !!!", Attack_mob.Exp_Drop_Mob);
                Console.WriteLine("\tGet {0} Gold !!!", Attack_mob.Money_Drop_Mob);
                Program.Player.Exp_Character += Attack_mob.Exp_Drop_Mob;
                Program.Player.Money_Bag += Attack_mob.Money_Drop_Mob;
                Thread.Sleep(1000);
                Program.Game_Option = "New_Game";
                Win_OR_Lost = true;
            }
        }

        public static void First_Attack_Mob(ref bool Win_OR_Lost)
        {
            if((Attack_mob.Attack_Mob - Program.Player.Defence_Character) >= 0)
            {
                Program.Player.HP_Character -= (Attack_mob.Attack_Mob - (Program.Player.Defence_Character/2));
                Console.WriteLine("\nYou took {0} damage", (Attack_mob.Attack_Mob - Program.Player.Defence_Character));
            }
            else
            {
                Console.WriteLine("\nYou dealt 0 damage");
            }

            if (Program.Player.HP_Character <= 0)
            {
                Console.WriteLine("You were defeated by {0} :(", Attack_mob.Name_Mob);
                Console.ReadLine();
                Console.Clear();
                Program.Game_Option = "New_Game";
                Win_OR_Lost = false;
            }
        }

        public static void First_Attack_Player_Magic(int Magic_Attack, ref bool Win_OR_Lost)
        {
            Attack_mob.HP_Mob -= Magic_Attack;
            Console.WriteLine("\nYou have dealt {0} magic damage\n", Magic_Attack);
            if (Attack_mob.HP_Mob <= 0)
            {
                Console.WriteLine("\n\n\n\n\tYou defeated {0} !!!", Attack_mob.Name_Mob);
                Console.WriteLine("\tGet {0} EXP !!!", Attack_mob.Exp_Drop_Mob);
                Console.WriteLine("\tGet {0} Gold !!!", Attack_mob.Money_Drop_Mob);
                Program.Player.Exp_Character += Attack_mob.Exp_Drop_Mob;
                Program.Player.Money_Bag += Attack_mob.Money_Drop_Mob;
                Console.ReadLine();
                Program.Game_Option = "New_Game";
                Win_OR_Lost = true;
            }
        }

        public static void Attack_mob_Text(string Name_Mobs)
        {
            Console.WriteLine(
            "[1] Attack\n" +
            "[2] Escape(50/50)\n"
                             );
            Console.Write("{0} appeared, What would you like to do: ", Name_Mobs);
        }
    }
}
