using System.Collections.Generic;
using System.Linq;


namespace Game_RPG.PlayerClass
{
    public class Skill_Model
    {
        public int ID_Skill;
        public string Name_Skill;
        public int Cost_Skill;
        public int Damage_Skill;
        public int Learning_Prerequisites_Skill;
        public string Description_Skill;
    }
    public static class Skill_List
    {

        private static List<Skill_Model> Magic_Skill { get; } = new()
        {
            //ID, Name, Cost, Damage, Requisites, Info
            new Skill_Model { ID_Skill = 0, Name_Skill = "Fire Ball",       Cost_Skill = 10, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "Water bullet ",   Cost_Skill = 10, Damage_Skill = 20, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 20 damage" },
            new Skill_Model { ID_Skill = 2, Name_Skill = "Lightning",       Cost_Skill = 20, Damage_Skill = 35, Learning_Prerequisites_Skill = 18, Description_Skill = "Deals 35 damage" },
            new Skill_Model { ID_Skill = 3, Name_Skill = "Ice Wall",        Cost_Skill = 15, Damage_Skill = 30, Learning_Prerequisites_Skill = 15, Description_Skill = "Protect you and absorb to 30 damage" },
            new Skill_Model { ID_Skill = 4, Name_Skill = "Dark Curse",      Cost_Skill = 30, Damage_Skill = 5,  Learning_Prerequisites_Skill = 20, Description_Skill = "Reduces Dexteries enemy " },
            new Skill_Model { ID_Skill = 5, Name_Skill = "Ethereal Shot",   Cost_Skill = 20, Damage_Skill = 30, Learning_Prerequisites_Skill = 30, Description_Skill = "Deals 30 damage" },
            new Skill_Model { ID_Skill = 6, Name_Skill = "Healing",         Cost_Skill = 30, Damage_Skill = 35, Learning_Prerequisites_Skill = 25, Description_Skill = "Restores 35HP" },
            new Skill_Model { ID_Skill = 7, Name_Skill = "Shield",          Cost_Skill = 30, Damage_Skill = 50, Learning_Prerequisites_Skill = 35, Description_Skill = "Protect you and absorb to 50 damage" },
            new Skill_Model { ID_Skill = 8, Name_Skill = "Weakness",        Cost_Skill = 30, Damage_Skill = 5,  Learning_Prerequisites_Skill = 23, Description_Skill = "Reduces Strenght enemy " },
            new Skill_Model { ID_Skill = 9, Name_Skill = "Fire Shield",     Cost_Skill = 50, Damage_Skill = 50, Learning_Prerequisites_Skill = 45, Description_Skill = "Protect you and absorb to 50 damage and deals 25 damage" },
        };

        private static List<Skill_Model> Combat_Skill { get; } = new()
        {
            //ID, Name, Cost, Damage, Wymagania, Info
            new Skill_Model {ID_Skill = 0, Name_Skill = "Strong swing",             Cost_Skill = 5,  Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage"},
            new Skill_Model {ID_Skill = 1, Name_Skill = "A powerful blow ",         Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage"},
            new Skill_Model {ID_Skill = 2, Name_Skill = "Block and Fast Attack",    Cost_Skill = 5,  Damage_Skill = 20, Learning_Prerequisites_Skill = 15, Description_Skill = "Blocks the attack and Deals 20 damage"},
            new Skill_Model {ID_Skill = 3, Name_Skill = "Knocking down the weapon", Cost_Skill = 10, Damage_Skill = 30, Learning_Prerequisites_Skill = 15, Description_Skill = "Deals 30 damage and Reduces Strenght(-5) enemy"},
            new Skill_Model {ID_Skill = 4, Name_Skill = "Crushing Blow",            Cost_Skill = 25, Damage_Skill = 50, Learning_Prerequisites_Skill = 30, Description_Skill = "Deals 50 damage"},
            new Skill_Model {ID_Skill = 5, Name_Skill = "Jump Attack",              Cost_Skill = 10, Damage_Skill = 30, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 30 damage"},
            new Skill_Model {ID_Skill = 6, Name_Skill = "Master Kick",              Cost_Skill = 15, Damage_Skill = 40, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 40 damage"},
            new Skill_Model {ID_Skill = 7, Name_Skill = "Breaking Defense",         Cost_Skill = 20, Damage_Skill = 30, Learning_Prerequisites_Skill = 30, Description_Skill = "Ignore Defense and Deals 30 damage"},
        };

        public static Skill_Model Search_Magic_Skill(int ID_skill)
        {
            Skill_Model Search_Magic_skill = Magic_Skill.FirstOrDefault(skill => skill.ID_Skill == ID_skill);
            return Search_Magic_skill;
        }

        public static Skill_Model Search_Combat_Skill(int ID_skill)
        {
            Skill_Model Search_Combat_skill = Combat_Skill.FirstOrDefault(skill => skill.ID_Skill == ID_skill);
            return Search_Combat_skill;
        }
    }
}