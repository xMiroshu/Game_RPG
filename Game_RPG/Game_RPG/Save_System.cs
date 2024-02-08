using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Game_RPG.PlayerClass;
using Game_RPG.StructureClass;
using Newtonsoft.Json;

namespace Game_RPG
{
    [Serializable]
    public class SaveData
    {
        public Hero_Model Player
        {
            get; set;
        }
        public List<Skill_Model> My_Skill_List { get; set; } = new List<Skill_Model>();
        public List<Weapons_Items> Weapons_Character { get; set; } = new List<Weapons_Items>();
        public List<Armors_Items> Armors_Character { get; set; } = new List<Armors_Items>();
        public List<Utitlity_Items> Utitlity_Character { get; set; } = new List<Utitlity_Items>();
        public List<Monsters_Items> Monsters_Character { get; set; } = new List<Monsters_Items>();
        public List<Tasks> Tasks_Character { get; set; } = new List<Tasks>();

        public string Name_Character
        {
            get; set;
        }
        public int Lvl_Character
        {
            get; set;
        }
        public int Exp_Character
        {
            get; set;
        }
        public string Class_Character
        {
            get; set;
        }
        public int Money_Bag
        {
            get; set;
        }

        public int Strength_Character
        {
            get; set;
        }
        public int Intelligence_Character
        {
            get; set;
        }
        public int Dexterity_Character
        {
            get; set;
        }
        public int Stamina_Character
        {
            get; set;
        }
        public int HP_Character
        {
            get; set;
        }
        public int MP_Character
        {
            get; set;
        }
        public int MaxHP_Character
        {
            get; set;
        }
        public int MaxMP_Character
        {
            get; set;
        }

        public int Defence_Character
        {
            get; set;
        }
        public int Attack_Character
        {
            get; set;
        }

        public Weapons_Items Weapon_Character
        {
            get; set;
        }
        public Armors_Items Helmet_Character
        {
            get; set;
        }
        public Armors_Items ChestPlate_Character
        {
            get; set;
        }
        public Armors_Items Legging_Character
        {
            get; set;
        }
        public Armors_Items Boots_Character
        {
            get; set;
        }

        public int X_Position_Player
        {
            get; set;
        }
        public int Y_Position_Player
        {
            get; set;
        }
    }

    public static class SaveSystem
    {
        public static void SaveGame(string savePath, Hero_Model player)
        {
            SaveData data = new()
            {
                Player = player,
                My_Skill_List = player.My_Skill_List,
                Weapons_Character = player.Weapons_Character,
                Armors_Character = player.Armors_Character,
                Utitlity_Character = player.Utitlity_Character,
                Monsters_Character = player.Monsters_Character,
                Tasks_Character = player.Tasks_Character,
                Name_Character = player.Name_Character,
                Lvl_Character = player.Lvl_Character,
                Exp_Character = player.Exp_Character,
                Class_Character = player.Class_Character,
                Money_Bag = player.Money_Bag,
                Strength_Character = player.Strength_Character,
                Intelligence_Character = player.Intelligence_Character,
                Dexterity_Character = player.Dexterity_Character,
                Stamina_Character = player.Stamina_Character,
                HP_Character = player.HP_Character,
                MP_Character = player.MP_Character,
                MaxHP_Character = player.MaxHP_Character,
                MaxMP_Character = player.MaxMP_Character,
                Defence_Character = player.Defence_Character,
                Attack_Character = player.Attack_Character,
                Weapon_Character = player.Weapon_Character,
                Helmet_Character = player.Helmet_Character,
                ChestPlate_Character = player.ChestPlate_Character,
                Legging_Character = player.Legging_Character,
                Boots_Character = player.Boots_Character,
                X_Position_Player = Program.X_Position_Player,
                Y_Position_Player = Program.Y_Position_Player
            };

            string jsonData = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(savePath, jsonData);
        }

        public static Hero_Model LoadGame(string savePath)
        {
            if (File.Exists(savePath))
            {
                string jsonData = File.ReadAllText(savePath);
                SaveData loadedData = JsonConvert.DeserializeObject<SaveData>(jsonData);

                Hero_Model loadedPlayer = new(
                    loadedData.Name_Character,
                    loadedData.Lvl_Character,
                    loadedData.Exp_Character,
                    loadedData.Class_Character,
                    loadedData.Money_Bag,
                    loadedData.Strength_Character,
                    loadedData.Intelligence_Character,
                    loadedData.Dexterity_Character,
                    loadedData.Stamina_Character,
                    loadedData.HP_Character,
                    loadedData.MaxHP_Character,
                    loadedData.MP_Character,
                    loadedData.MaxMP_Character
                )
                {
                    My_Skill_List = loadedData.My_Skill_List,
                    Weapons_Character = loadedData.Weapons_Character,
                    Armors_Character = loadedData.Armors_Character,
                    Utitlity_Character = loadedData.Utitlity_Character,
                    Monsters_Character = loadedData.Monsters_Character,
                    Tasks_Character = loadedData.Tasks_Character,
                    Defence_Character = loadedData.Defence_Character,
                    Attack_Character = loadedData.Attack_Character,
                    Weapon_Character = loadedData.Weapon_Character,
                    Helmet_Character = loadedData.Helmet_Character,
                    ChestPlate_Character = loadedData.ChestPlate_Character,
                    Legging_Character = loadedData.Legging_Character,
                    Boots_Character = loadedData.Boots_Character,
                };

                Program.X_Position_Player = loadedData.X_Position_Player;
                Program.Y_Position_Player = loadedData.Y_Position_Player;

                return loadedPlayer;
            }
            else
            {
                return null;
            }
        }
    }
}
