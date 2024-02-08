using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Game_RPG.StructureClass
{
    class Locations_Model
    {
        public int X_Map;
        public int Y_Map;
        public string Name_Map;
        public bool Mobs_Map;
    }

    class Interaction_Locationst
    {
        public static List<Locations_Model> Locations { get; private set; } = new()
        {
            //-10  -9  -8  -7  -6  -5  -4  -3  -2  -1   Y_Map   1   2   3   4   5   6   7   8   9   10
            //  6   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   6
            //  5   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   5
            //  4   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   4
            //  3   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   3
            //  2   *   *   *   *   *   *   *   *   *  GV   *   *   *   *   *   *   *   *   *   2
            //  1   *   *   *   *   *   *   *   *  BD  NF  BC  WL   *   *   *   *   *   *   *   1
            // -X_Map   *   *   *   *   *   *   *   *  WF  HH  EF   *   *   *   *   *   *   *   *   X_Map
            // -1   *   *   *   *   *   *   *  PG  MC  SF  OO   *   *   *   *   *   *   *   *  -1
            // -2   *   *   *   *   *   *   *   *   *  FE   *   *   *   *   *   *   *   *   *  -2
            // -3   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *  -3
            // -4   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *  -4
            // -5   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *  -5
            // -6   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *   *  -6
            //-10  -9  -8  -7  -6  -5  -4  -3  -2  -1   Y_Map   1   2   3   4   5   6   7   8   9   10

            //X_Map=-2
            new Locations_Model { X_Map = -2, Y_Map = -1, Name_Map = "Pig Glade", Mobs_Map = true },//Polana

            //X_Map=-1
            new Locations_Model { X_Map = -1, Y_Map = 1, Name_Map = "Beelzebub dungeons", Mobs_Map = false },
            new Locations_Model { X_Map = -1, Y_Map = 0, Name_Map = "West Forest", Mobs_Map = true },
            new Locations_Model { X_Map = -1, Y_Map = -1, Name_Map = "Mysterious Cave", Mobs_Map = false },

            //X_Map=0
            new Locations_Model { X_Map = 0, Y_Map = 2, Name_Map = "Goblin Village", Mobs_Map = true },
            new Locations_Model { X_Map = 0, Y_Map = 1, Name_Map = "North Forest", Mobs_Map = true },
            new Locations_Model { X_Map = 0, Y_Map = 0, Name_Map = "Home", Mobs_Map = false },
            new Locations_Model { X_Map = 0, Y_Map = -1, Name_Map = "Southern Forest", Mobs_Map = true },
            new Locations_Model { X_Map = 0, Y_Map = -2, Name_Map = "Forest Elder", Mobs_Map = false },

            //X_Map=1
            new Locations_Model {X_Map = 1, Y_Map = 1, Name_Map = "Behemot Cave", Mobs_Map = false },
            new Locations_Model {X_Map = 1, Y_Map = 0, Name_Map = "East Forest", Mobs_Map = true },
            new Locations_Model {X_Map = 1, Y_Map = -1, Name_Map = "Oasis", Mobs_Map = false },

            //X_Map=2
            new Locations_Model { X_Map = 2, Y_Map = 1, Name_Map = "Wolves' Lair", Mobs_Map = true }, //leże
        };
        public static void Map_Views()
        {
            Console.Write("                                    " + Search_Locations_Name());
            Console.WriteLine();
            Console.WriteLine("           -5  -4  -3  -2  -1   Y   1   2   3   4    ");
            Console.WriteLine("            2   *   *   *   *  GV   *   *   *   *   2");
            Console.WriteLine("            1   *   *   *  BD  NF  BC  WL   *   *   1");
            Console.WriteLine("           -X   *   *   *  WF  HH  EF   *   *   *   X");
            Console.WriteLine("           -1   *   *  PG  MC  SF  OO   *   *   *  -1");
            Console.WriteLine("           -2   *   *   *   *  FE   *   *   *   *  -2");
            Console.WriteLine("           -5  -4  -3  -2  -1   Y   1   2   3   4    ");
            Console.WriteLine();
            Console.WriteLine();
        }
        public static bool Search_Locations(int X_Map, int Y_Map)
        {
            var Y_Mapour_Locations = Locations.FirstOrDefault(location => location.X_Map == X_Map && location.Y_Map == Y_Map);
            if (Y_Mapour_Locations != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Locations_Model Get_Location_Details(int X_Map, int Y_Map)
        {
            var Get_Location_details = Locations.FirstOrDefault(location => location.X_Map == X_Map && location.Y_Map == Y_Map);
            if (Get_Location_details != null)
            {
                return Get_Location_details;
            }
            else
            {
                return Get_Location_details;
            }
        }

        public static string Search_Locations_Name()
        {
            var Your_GLocations = Locations.FirstOrDefault(location => location.X_Map == Program.X_Position_Player && location.Y_Map == Program.Y_Position_Player);
            if (Your_GLocations != null)
            {
                return $"X_Map: {Your_GLocations.X_Map} Y_Map: {Your_GLocations.Y_Map} [{Your_GLocations.Name_Map}]";
            }
            else
            {
                return "Location without a name";
            }
        }

        public static void Choose_Way() //Lista możliwY_Mapch dróg
        {
            Map_Views();

            Console.Write("*Show [Menu] Class\n");
            if (Search_Locations(Program.X_Position_Player, Program.Y_Position_Player + 1))
            {
                Console.Write("*Go to The [Up]\n");
            }

            if (Search_Locations(Program.X_Position_Player, Program.Y_Position_Player - 1))
            {
                Console.Write("*Go to The [Down]\n");
            }

            if (Search_Locations(Program.X_Position_Player - 1, Program.Y_Position_Player))
            {
                Console.Write("*Go to The [Left]\n");
            }

            if (Search_Locations(Program.X_Position_Player + 1, Program.Y_Position_Player))
            {
                Console.Write("*Go to The [Right]\n");
            }

            if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 0)
            {
                Console.Write("*Go to The [City]\n");
            }
            Console.WriteLine();
            Console.Write("What would You like to do(Left/Up): ");
        }

        public static void Location_Manager(string Choose_Way_Text)
        {
            if (!Search_Locations(Program.X_Position_Player - 1, Program.Y_Position_Player) && Choose_Way_Text == "left")
            {
                Console.WriteLine("There is no such way Left");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            }

            else if (!Search_Locations(Program.X_Position_Player, Program.Y_Position_Player - 1) && Choose_Way_Text == "down")
            {
                Console.WriteLine("There is no such way Down");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            }

            else if (!Search_Locations(Program.X_Position_Player, Program.Y_Position_Player + 1) && Choose_Way_Text == "up")
            {
                Console.WriteLine("There is no such way Up");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            }

            else if (!Search_Locations(Program.X_Position_Player + 1, Program.Y_Position_Player) && Choose_Way_Text == "right")
            {
                Console.WriteLine("There is no such way Right");
                Thread.Sleep(1500);
                Console.Clear();
                return;
            }

            if (Choose_Way_Text == "left")
            {
                Program.X_Position_Player--;
            }

            else if (Choose_Way_Text == "right")
            {
                Program.X_Position_Player++;
            }

            else if (Choose_Way_Text == "up")
            {
                Program.Y_Position_Player++;
            }

            else if (Choose_Way_Text == "down")
            {
                Program.Y_Position_Player--;
            }

            Console.Clear();
            Console.WriteLine();
            var Map_Now = Locations.FirstOrDefault(location => Program.X_Position_Player == location.X_Map && Program.Y_Position_Player == location.Y_Map);

            if (Map_Now.Mobs_Map == true) //atakowania na mapach z mob = true
            {
                Mechanic_system.Combat_System();
            }
            if (Program.X_Position_Player == 1 && Program.Y_Position_Player == -1)
            {
                Structure_Manager.Oaza_Location();
            }
            else if (Program.X_Position_Player == -1 && Program.Y_Position_Player == -1)
            {
                Structure_Manager.Cave_Location();
            }
            else if (Program.X_Position_Player == 1 && Program.Y_Position_Player == 1)
            {
                Structure_Manager.Cave_Behemot_Location();
            }
            else if (Program.X_Position_Player == -1 && Program.Y_Position_Player == 1)
            {
                Structure_Manager.Cave_Belziego_Location();
            }
            else if (Program.X_Position_Player == 0 && Program.Y_Position_Player == -2)
            {
                Structure_Manager.Visit_Drug_House();
            }
            else if (Program.X_Position_Player == -2 && Program.Y_Position_Player == -1)
            {
                Structure_Manager.Pig_Glade();
            }
            else if (Program.X_Position_Player == 2 && Program.Y_Position_Player == 1)
            {
                Structure_Manager.Wolves_Lair();
            }
            else if (Program.X_Position_Player == 0 && Program.Y_Position_Player == 2)
            {
                Structure_Manager.Village_Goblin();
            }
        }
    }
}