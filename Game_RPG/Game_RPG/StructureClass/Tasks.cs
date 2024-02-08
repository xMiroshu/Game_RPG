using System;
using System.Collections.Generic;
using System.Linq;

namespace Game_RPG.StructureClass
{
    public class Tasks
    {
        public int ID_Task;
        public string Name_Task;
        public string Info_Task;
        public int Status_Requirements_Task;
        public int Requirements_Task;
        public int Reward_Task;
        public int Stars_Task;
        public string Name_Mob_Task;
    }

    class Tasks_Manager
    {
        public static List<Tasks> Monsters_Tasks { get; set; } = new()
        {
            new Tasks {ID_Task = 1, Name_Task = "Get rid of the Goblins", Info_Task = "Kill 10 Goblins", Name_Mob_Task = "Goblin",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 50, Stars_Task = 1},
            new Tasks {ID_Task = 2, Name_Task = "Get rid of the Wolfs", Info_Task = "Kill 5 Wolfs",Name_Mob_Task = "Wolf", Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 65, Stars_Task = 2 },
            new Tasks {ID_Task = 3, Name_Task = "Get rid of the Slime's", Info_Task = "Kill 15 Slimes",Name_Mob_Task = "Slime", Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 30, Stars_Task = 1 },
            new Tasks {ID_Task = 4, Name_Task = "Get rid of the Troll", Info_Task = "Kill 5 Trolls", Name_Mob_Task = "Troll",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 50, Stars_Task = 3 },
            new Tasks {ID_Task = 5, Name_Task = "Get rid of the Zombie", Info_Task = "Kill 5 Zombies", Name_Mob_Task = "Zombie",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 45, Stars_Task = 2 },
            new Tasks {ID_Task = 6, Name_Task = "Get rid of the Big_Spider", Info_Task = "Kill 5 Big_Spider", Name_Mob_Task = "Big_Spider",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 60, Stars_Task = 2 },
            new Tasks {ID_Task = 7, Name_Task = "Get rid of the Behemot", Info_Task = "Kill 1 Behemot", Name_Mob_Task = "Behemot",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 160, Stars_Task = 5 },
            new Tasks {ID_Task = 8, Name_Task = "Get rid of the Goblin_King", Info_Task = "Kill 1 Goblin_King", Name_Mob_Task = "Goblin_King",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 150, Stars_Task = 4 },
            new Tasks {ID_Task = 9, Name_Task = "Get rid of the Beelzebub", Info_Task = "Kill 1 Beelzebub", Name_Mob_Task = "Beelzebub",Requirements_Task = 5 , Status_Requirements_Task = 0, Reward_Task = 140, Stars_Task = 5 },
        };

        public static void View_Task(int Stars_Task)
        {
            foreach (var Monsters_task in Monsters_Tasks)
            {
                if (Monsters_task.Stars_Task == Stars_Task)
                {
                    Console.WriteLine($"ID: {Monsters_task.ID_Task} Name: {Monsters_task.Name_Task} Info: {Monsters_task.Info_Task} Requirements:{Monsters_task.Requirements_Task} Reward: {Monsters_task.Reward_Task} Gold");
                }
            }
        }

        public static Tasks Search_Task(int ID_Task)
        {
            Tasks Search_Task = Monsters_Tasks.FirstOrDefault(task => task.ID_Task == ID_Task);

            return Search_Task;
        }

        public static Tasks Search_Task_Character(int ID_Task)
        {
            Tasks Search_Task = Program.Player.Tasks_Character.FirstOrDefault(task => task.ID_Task == ID_Task);

            return Search_Task;
        }

        public static void View_Task_Character()
        {
            foreach (var Monsters_task_Character in Program.Player.Tasks_Character)
            {
                Console.WriteLine($"ID: {Monsters_task_Character.ID_Task} Name: {Monsters_task_Character.Name_Task} Info: {Monsters_task_Character.Info_Task} Requirements:{Monsters_task_Character.Status_Requirements_Task}/{Monsters_task_Character.Requirements_Task} Reward: {Monsters_task_Character.Reward_Task} Gold");
            }
        }
    }
}