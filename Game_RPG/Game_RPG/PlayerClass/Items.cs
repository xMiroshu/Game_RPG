using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Game_RPG.PlayerClass
{
    public enum ItemType
    {
        Weapon,
        Armor,
        Utitlity,
        Monster,
    }

    public enum ClassItem
    {
        Mag,
        Warrior,
        Archer,
    }

    public class Item
    {
        public int ID_Item;
        public string Name_Item;
        public int Quantity_Item;
        public string Info_Item;
        public int Price_Item;
        public ItemType Type_Item;
        public ClassItem Class_Item;
    }

    public class Utitlity_Items : Item //użytkowe
    {
        public int Properties_Item;

        public Utitlity_Items()
        {
            Type_Item = ItemType.Utitlity;
        }
    }

    public class Monsters_Items : Item //drop mobs
    {
        public Monsters_Items()
        {
            Type_Item = ItemType.Monster;
        }
    }

    public class Armors_Items : Item //Armors
    {
        public int Defense_Item;
        public int Attack_Item;
        public int Lvl_Item;

        public Armors_Items()
        {
            Type_Item = ItemType.Armor;
        }
    }

    public class Weapons_Items : Item //Weapons
    {
        public int Defense_Item;
        public int Attack_Item;
        public int Lvl_Item;

        public Weapons_Items()
        {
            Type_Item = ItemType.Weapon;
        }
    }

    public class Item_Manager
    {
        public static List<Utitlity_Items> Utility_items { get; private set; } = new()
        {
            new Utitlity_Items { ID_Item = 0, Name_Item = "Small_Potion_of_Healing", Quantity_Item = 1, Info_Item = "Restores 25HP", Properties_Item = 25, Price_Item = 15 },
            new Utitlity_Items { ID_Item = 1, Name_Item = "Potion_of_Healing", Quantity_Item = 1, Info_Item = "Restores 50HP", Properties_Item = 50, Price_Item = 25 },

            new Utitlity_Items { ID_Item = 2, Name_Item = "Small_Mana_Potion", Quantity_Item = 1, Info_Item = "Restores 25MP", Properties_Item = 25, Price_Item = 20 },
            new Utitlity_Items { ID_Item = 3, Name_Item = "Mana_Potion", Quantity_Item = 1, Info_Item = "Restores 50MP", Properties_Item = 25, Price_Item = 30 },

            new Utitlity_Items { ID_Item = 4, Name_Item = "Strength_Potion", Quantity_Item = 1, Info_Item = "Increasing Strength by +2", Properties_Item = 2, Price_Item = 100 },
            new Utitlity_Items { ID_Item = 5, Name_Item = "Large_Strength_Potion", Quantity_Item = 1, Info_Item = "Increasing Strength by +5", Properties_Item = 5, Price_Item = 200 },

            new Utitlity_Items { ID_Item = 6, Name_Item = "Intelligency_Potion", Quantity_Item = 1, Info_Item = "Increasing Intelligency by +2", Properties_Item = 2, Price_Item = 100 },
            new Utitlity_Items { ID_Item = 7, Name_Item = "Large_Intelligency_Potion", Quantity_Item = 1, Info_Item = "Increasing Intelligency by +5", Properties_Item = 5, Price_Item = 200 },

            new Utitlity_Items { ID_Item = 8, Name_Item = "Dexterity_Potion", Quantity_Item = 1, Info_Item = "Increasing Dexterity by +2", Properties_Item = 2, Price_Item = 100 },
            new Utitlity_Items { ID_Item = 9, Name_Item = "Large_Dexterity_Potion", Quantity_Item = 1, Info_Item = "Increasing Dexterity by +5", Properties_Item = 5, Price_Item = 200 },

            new Utitlity_Items { ID_Item = 10, Name_Item = "Stamina_Potion", Quantity_Item = 1, Info_Item = "Increasing Stamina by +2", Properties_Item = 2, Price_Item = 100 },
            new Utitlity_Items { ID_Item = 11, Name_Item = "Large_Stamina_Potion", Quantity_Item = 1, Info_Item = "Increasing Stamina by +5", Properties_Item = 5, Price_Item = 200 },

            new Utitlity_Items { ID_Item = 12, Name_Item = "HP_Potion", Quantity_Item = 1, Info_Item = "Increasing HP by +10", Properties_Item = 10, Price_Item = 150 },
            new Utitlity_Items { ID_Item = 13, Name_Item = "Large_HP_Potion", Quantity_Item = 1, Info_Item = "Increasing HP by +20", Properties_Item = 20, Price_Item = 300 },

            new Utitlity_Items { ID_Item = 14, Name_Item = "MP_Potion", Quantity_Item = 1, Info_Item = "Increasing MP by +10", Properties_Item = 10, Price_Item = 150 },
            new Utitlity_Items { ID_Item = 15, Name_Item = "Large_MP_Potion", Quantity_Item = 1, Info_Item = "Increasing MP by +20", Properties_Item = 20, Price_Item = 300 },

            new Utitlity_Items { ID_Item = 16, Name_Item = "Teleport_Stone", Quantity_Item = 1, Info_Item = "Teleport you to choose locations", Properties_Item = 0, Price_Item = 50 },
            new Utitlity_Items { ID_Item = 17, Name_Item = "Picklock", Quantity_Item = 1, Info_Item = "Increases the chance of opening a locked chest +50% ", Properties_Item = 0, Price_Item = 50 },
        };

        public static List<Monsters_Items> Monsters_items { get; private set; } = new()
        {
            new Monsters_Items { ID_Item = 0,  Name_Item = "Goblin_Ear", Quantity_Item = 1, Info_Item = "Cute Goblin Ear", Price_Item = 1 },
            new Monsters_Items { ID_Item = 1,  Name_Item = "Goblin_Bone", Quantity_Item = 1, Info_Item = "Nice Goblin Bone", Price_Item = 1 },
            new Monsters_Items { ID_Item = 2,  Name_Item = "Goblin_Meat", Quantity_Item = 1, Info_Item = "Tasty Goblin Meat", Price_Item = 3 },
            new Monsters_Items { ID_Item = 3,  Name_Item = "Goblin_Essence", Quantity_Item = 1, Info_Item = "Goblin_Essence", Price_Item = 3 },
            new Monsters_Items { ID_Item = 4,  Name_Item = "Goblin_Crystal", Quantity_Item = 1, Info_Item = "Goblin_Crystal", Price_Item = 5 },

            new Monsters_Items { ID_Item = 5,  Name_Item = "Wolf_Ear", Quantity_Item = 1, Info_Item = "Cute Wolf Ear", Price_Item = 2 },
            new Monsters_Items { ID_Item = 6,  Name_Item = "Wolf_Bone", Quantity_Item = 1, Info_Item = "Nice Wolf Bone", Price_Item = 2 },
            new Monsters_Items { ID_Item = 7,  Name_Item = "Wolf_Meat", Quantity_Item = 1, Info_Item = "Tasty Wolf Meat", Price_Item = 6 },
            new Monsters_Items { ID_Item = 8,  Name_Item = "Wolf_Essence", Quantity_Item = 1, Info_Item = "Wolf_Essence", Price_Item = 6 },
            new Monsters_Items { ID_Item = 9,  Name_Item = "Wolf_Crystal", Quantity_Item = 1, Info_Item = "Wolf_Crystal", Price_Item = 10 },

            new Monsters_Items { ID_Item = 10,  Name_Item = "Slime_Essence", Quantity_Item = 1, Info_Item = "Slime_Essence", Price_Item = 3 },
            new Monsters_Items { ID_Item = 11,  Name_Item = "Slime_Core", Quantity_Item = 1, Info_Item = "Slime_Core", Price_Item = 8 },
            new Monsters_Items { ID_Item = 12, Name_Item = "Slime_Crystal", Quantity_Item = 1, Info_Item = "Slime_Crystal", Price_Item = 5 },
            new Monsters_Items { ID_Item = 13, Name_Item = "Slime_Fragment", Quantity_Item = 1, Info_Item = "Slime_Fragment", Price_Item = 1 },

            new Monsters_Items { ID_Item = 14, Name_Item = "Beelzebub_Heart", Quantity_Item = 1, Info_Item = "Beelzebub_Heart", Price_Item = 25 },
            new Monsters_Items { ID_Item = 15, Name_Item = "Beelzebub_Leather", Quantity_Item = 1, Info_Item = "Beelzebub_Leather", Price_Item = 40 },
            new Monsters_Items { ID_Item = 16, Name_Item = "Beelzebub_Meat", Quantity_Item = 1, Info_Item = "Beelzebub_Meat", Price_Item = 25 },
            new Monsters_Items { ID_Item = 17, Name_Item = "Beelzebub_Eye", Quantity_Item = 1, Info_Item = "Beelzebub_Eye", Price_Item = 30 },
            new Monsters_Items { ID_Item = 18, Name_Item = "Beelzebub_Toth", Quantity_Item = 1, Info_Item = "Beelzebub_Toth", Price_Item = 30 },
            new Monsters_Items { ID_Item = 19, Name_Item = "Beelzebub_Crystal", Quantity_Item = 1, Info_Item = "Beelzebub_Crystal", Price_Item = 50 },

            new Monsters_Items { ID_Item = 20, Name_Item = "Behemot_Heart", Quantity_Item = 1, Info_Item = "Behemot_Heart", Price_Item = 25 },
            new Monsters_Items { ID_Item = 21, Name_Item = "Behemot_Leather", Quantity_Item = 1, Info_Item = "Behemot_Leather", Price_Item = 40 },
            new Monsters_Items { ID_Item = 22, Name_Item = "Behemot_Meat", Quantity_Item = 1, Info_Item = "Behemot_Meat", Price_Item = 25 },
            new Monsters_Items { ID_Item = 23, Name_Item = "Behemot_Eye", Quantity_Item = 1, Info_Item = "Behemot_Eye", Price_Item = 30 },
            new Monsters_Items { ID_Item = 24, Name_Item = "Behemot_Toth", Quantity_Item = 1, Info_Item = "Behemot_Toth", Price_Item = 30 },
            new Monsters_Items { ID_Item = 25, Name_Item = "Behemot_Crystal", Quantity_Item = 1, Info_Item = "Behemot_Crystal", Price_Item = 50 },

            new Monsters_Items { ID_Item = 26, Name_Item = "Pig_Meat", Quantity_Item = 1, Info_Item = "Pig_Meat", Price_Item = 5 },
            new Monsters_Items { ID_Item = 27, Name_Item = "Pig_Leather", Quantity_Item = 1, Info_Item = "Pig_Leather", Price_Item = 5 },

            new Monsters_Items { ID_Item = 28, Name_Item = "Zombie_Meat", Quantity_Item = 1, Info_Item = "Zombie_Meat", Price_Item = 3 },
            new Monsters_Items { ID_Item = 29, Name_Item = "Zombie_Crystal", Quantity_Item = 1, Info_Item = "Zombie_Crystal", Price_Item = 5 },
            new Monsters_Items { ID_Item = 30, Name_Item = "Zombie_Essence", Quantity_Item = 1, Info_Item = "Zombie_Essence", Price_Item = 3 },

            new Monsters_Items { ID_Item = 31, Name_Item = "BigSpider_Meat", Quantity_Item = 1, Info_Item = "BigSpider_Meat", Price_Item = 5 },
            new Monsters_Items { ID_Item = 32, Name_Item = "BigSpider_Eye", Quantity_Item = 1, Info_Item = "BigSpider_Eye", Price_Item = 10 },
            new Monsters_Items { ID_Item = 33, Name_Item = "BigSpider_String", Quantity_Item = 1, Info_Item = "BigSpider_String", Price_Item = 8 },
            new Monsters_Items { ID_Item = 34, Name_Item = "BigSpider_Crystal", Quantity_Item = 1, Info_Item = "BigSpider_Crystal", Price_Item = 10 },
            new Monsters_Items { ID_Item = 35, Name_Item = "BigSpider_Essence", Quantity_Item = 1, Info_Item = "BigSpider_Essence", Price_Item = 6 },

            new Monsters_Items { ID_Item = 36, Name_Item = "Troll_Meat", Quantity_Item = 1, Info_Item = "Troll_Meat", Price_Item = 10 },
            new Monsters_Items { ID_Item = 37, Name_Item = "Troll_Leather", Quantity_Item = 1, Info_Item = "Troll_Leather", Price_Item = 15 },
            new Monsters_Items { ID_Item = 38, Name_Item = "Troll_Crystal", Quantity_Item = 1, Info_Item = "Troll_Crystal", Price_Item = 10 },

            new Monsters_Items { ID_Item = 39, Name_Item = "GoblinKing_Crystal", Quantity_Item = 1, Info_Item = "GoblinKing_Crystal", Price_Item = 50 },
            new Monsters_Items { ID_Item = 40, Name_Item = "GoblinKing_Essence", Quantity_Item = 1, Info_Item = "GoblinKing_Essence", Price_Item = 35 },
            new Monsters_Items { ID_Item = 41, Name_Item = "GoblinKing_Toth", Quantity_Item = 1, Info_Item = "GoblinKing_Toth", Price_Item = 30 },
            new Monsters_Items { ID_Item = 42, Name_Item = "GoblinKing_Leather", Quantity_Item = 1, Info_Item = "GoblinKing_Leather", Price_Item = 30 },
        };

        public static List<Armors_Items> Armors_items { get; private set; } = new()
        {
            new Armors_Items { ID_Item = 0, Name_Item = "Leather_Helmet", Quantity_Item = 1, Info_Item = "+1 to Defense", Price_Item = 5, Defense_Item = 1, Lvl_Item = 1 },
            new Armors_Items { ID_Item = 1, Name_Item = "Leather_ChestPlate", Quantity_Item = 1, Info_Item = "+1 to Defense", Price_Item = 10, Defense_Item = 1, Lvl_Item = 1 },
            new Armors_Items { ID_Item = 2, Name_Item = "Leather_Leggings", Quantity_Item = 1, Info_Item = "+1 to Defense", Price_Item = 10, Defense_Item = 1, Lvl_Item = 1 },
            new Armors_Items { ID_Item = 3, Name_Item = "Leather_Boots", Quantity_Item = 1, Info_Item = "+1 to Defense", Price_Item = 5, Defense_Item = 1, Lvl_Item = 1 },

            new Armors_Items { ID_Item = 4, Name_Item = "Chainmail_Helmet", Quantity_Item = 1, Info_Item = "+1 to Defense", Price_Item = 15, Defense_Item = 1, Lvl_Item = 4 },
            new Armors_Items { ID_Item = 5, Name_Item = "Chainmail_ChestPlate", Quantity_Item = 1, Info_Item = "+2 to Defense", Price_Item = 30, Defense_Item = 2, Lvl_Item = 4 },
            new Armors_Items { ID_Item = 6, Name_Item = "Chainmail_Leggings", Quantity_Item = 1, Info_Item = "+2 to Defense", Price_Item = 30, Defense_Item = 2, Lvl_Item = 4 },
            new Armors_Items { ID_Item = 7, Name_Item = "Chainmail_Boots", Quantity_Item = 1, Info_Item = "+1 to Defense", Price_Item = 15, Defense_Item = 1, Lvl_Item = 4 },

            new Armors_Items { ID_Item = 8, Name_Item = "Iron_Helmet", Quantity_Item = 1, Info_Item = "+2 to Defense", Price_Item = 45, Defense_Item = 2, Lvl_Item = 7 },
            new Armors_Items { ID_Item = 9, Name_Item = "Iron_ChestPlate", Quantity_Item = 1, Info_Item = "+4 to Defense", Price_Item = 90, Defense_Item = 4, Lvl_Item = 7 },
            new Armors_Items { ID_Item = 10, Name_Item = "Iron_Leggings", Quantity_Item = 1, Info_Item = "+4 to Defense", Price_Item = 90, Defense_Item = 4, Lvl_Item = 7 },
            new Armors_Items { ID_Item = 11, Name_Item = "Iron_Boots", Quantity_Item = 1, Info_Item = "+2 to Defense", Price_Item = 45, Defense_Item = 2, Lvl_Item = 7 },

            new Armors_Items { ID_Item = 12, Name_Item = "Steel_Helmet", Quantity_Item = 1, Info_Item = "+3 to Defense", Price_Item = 135, Defense_Item = 3, Lvl_Item = 10 },
            new Armors_Items { ID_Item = 13, Name_Item = "Steel_ChestPlate", Quantity_Item = 1, Info_Item = "+6 to Defense", Price_Item = 270, Defense_Item = 6, Lvl_Item = 10 },
            new Armors_Items { ID_Item = 14, Name_Item = "Steel_Leggings", Quantity_Item = 1, Info_Item = "+6 to Defense", Price_Item = 270, Defense_Item = 6, Lvl_Item = 10 },
            new Armors_Items { ID_Item = 15, Name_Item = "Steel_Boots", Quantity_Item = 1, Info_Item = "+3 to Defense", Price_Item = 135, Defense_Item = 3, Lvl_Item = 10 },

            new Armors_Items { ID_Item = 16, Name_Item = "Mithril_Helmet", Quantity_Item = 1, Info_Item = "+4 to Defense", Price_Item = 405, Defense_Item = 4, Lvl_Item = 13 },
            new Armors_Items { ID_Item = 17, Name_Item = "Mithril_ChestPlate", Quantity_Item = 1, Info_Item = "+8 to Defense", Price_Item = 810, Defense_Item = 8, Lvl_Item = 13 },
            new Armors_Items { ID_Item = 18, Name_Item = "Mithril_Leggings", Quantity_Item = 1, Info_Item = "+8 to Defense", Price_Item = 810, Defense_Item = 8, Lvl_Item = 13 },
            new Armors_Items { ID_Item = 19, Name_Item = "Mithril_Boots", Quantity_Item = 1, Info_Item = "+4 to Defense", Price_Item = 405, Defense_Item = 4, Lvl_Item = 13 },

            new Armors_Items { ID_Item = 20, Name_Item = "Adamantyt_Helmet", Quantity_Item = 1, Info_Item = "+6 to Defense", Price_Item = 1215, Defense_Item = 6, Lvl_Item = 16 },
            new Armors_Items { ID_Item = 21, Name_Item = "Adamantyt_ChestPlate", Quantity_Item = 1, Info_Item = "+12 to Defense", Price_Item = 2430, Defense_Item = 12, Lvl_Item = 16 },
            new Armors_Items { ID_Item = 22, Name_Item = "Adamantyt_Leggings", Quantity_Item = 1, Info_Item = "+12 to Defense", Price_Item = 2430, Defense_Item = 12, Lvl_Item = 16 },
            new Armors_Items { ID_Item = 23, Name_Item = "Adamantyt_Boots", Quantity_Item = 1, Info_Item = "+6 to Defense", Price_Item = 1215, Defense_Item = 6, Lvl_Item = 16 },

            new Armors_Items { ID_Item = 24, Name_Item = "Orichalcum_Helmet", Quantity_Item = 1, Info_Item = "+8 to Defense", Price_Item = 3650, Defense_Item = 8, Lvl_Item = 19 },
            new Armors_Items { ID_Item = 25, Name_Item = "Orichalcum_ChestPlate", Quantity_Item = 1, Info_Item = "+16 to Defense", Price_Item = 7300, Defense_Item = 16, Lvl_Item = 19 },
            new Armors_Items { ID_Item = 26, Name_Item = "Orichalcum_Leggings", Quantity_Item = 1, Info_Item = "+16 to Defense", Price_Item = 7300, Defense_Item = 16, Lvl_Item = 19 },
            new Armors_Items { ID_Item = 27, Name_Item = "Orichalcum_Boots", Quantity_Item = 1, Info_Item = "+8 to Defense", Price_Item = 3650, Defense_Item = 8, Lvl_Item = 19 },

            new Armors_Items { ID_Item = 28, Name_Item = "DragonScale_Helmet", Quantity_Item = 1, Info_Item = "+10 to Defense", Price_Item = 10950, Defense_Item = 10, Lvl_Item = 22 },
            new Armors_Items { ID_Item = 29, Name_Item = "DragonScale_ChestPlate", Quantity_Item = 1, Info_Item = "+20 to Defense", Price_Item = 21900, Defense_Item = 20, Lvl_Item = 22 },
            new Armors_Items { ID_Item = 30, Name_Item = "DragonScale_Leggings", Quantity_Item = 1, Info_Item = "+20 to Defense", Price_Item = 21900, Defense_Item = 20, Lvl_Item = 22 },
            new Armors_Items { ID_Item = 31, Name_Item = "DragonScale_Boots", Quantity_Item = 1, Info_Item = "+10 to Defense", Price_Item = 10950, Defense_Item = 10, Lvl_Item = 22 },
        };

        public static List<Weapons_Items> Weapons_items { get; private set; } = new()
        {
            new Weapons_Items { ID_Item = 0, Name_Item = "Wooden_Sword", Quantity_Item = 1, Info_Item = "+1 to Attack", Price_Item = 5, Attack_Item = 1, Lvl_Item = 1, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 1, Name_Item = "Wooden_Bow", Quantity_Item = 1, Info_Item = "+1 to Attack", Price_Item = 10, Attack_Item = 1, Lvl_Item = 1, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 2, Name_Item = "Wooden_Staw", Quantity_Item = 1, Info_Item = "+1 to Attack", Price_Item = 10, Attack_Item = 1, Lvl_Item = 1, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 3, Name_Item = "Stone_Sword", Quantity_Item = 1, Info_Item = "+2 to Attack", Price_Item = 15, Attack_Item = 2, Lvl_Item = 4, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 4, Name_Item = "Stone_Bow", Quantity_Item = 1, Info_Item = "+2 to Attack", Price_Item = 30, Attack_Item = 2, Lvl_Item = 4, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 5, Name_Item = "Stone_Staw", Quantity_Item = 1, Info_Item = "+2 to Attack", Price_Item = 30, Attack_Item = 2, Lvl_Item = 4, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 6, Name_Item = "Iron_Sword", Quantity_Item = 1, Info_Item = "+4 to Attack", Price_Item = 45, Attack_Item = 4, Lvl_Item = 7, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 7, Name_Item = "Iron_Bow", Quantity_Item = 1, Info_Item = "+4 to Attack", Price_Item = 90, Attack_Item = 4, Lvl_Item = 7, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 8, Name_Item = "Iron_Staw", Quantity_Item = 1, Info_Item = "+4 to Attack", Price_Item = 90, Attack_Item = 4, Lvl_Item = 7, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 9, Name_Item = "Steel_Sword", Quantity_Item = 1, Info_Item = "+6 to Attack", Price_Item = 135, Attack_Item = 6, Lvl_Item = 10, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 10, Name_Item = "Steel_Bow", Quantity_Item = 1, Info_Item = "+6 to Attack", Price_Item = 270, Attack_Item = 6, Lvl_Item = 10, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 11, Name_Item = "Steel_Staw", Quantity_Item = 1, Info_Item = "+6 to Attack", Price_Item = 270, Attack_Item = 6, Lvl_Item = 10, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 12, Name_Item = "Mithril_Sword", Quantity_Item = 1, Info_Item = "+8 to Attack", Price_Item = 405, Attack_Item = 8, Lvl_Item = 13, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 13, Name_Item = "Mithril_Bow", Quantity_Item = 1, Info_Item = "+8 to Attack", Price_Item = 810, Attack_Item = 8, Lvl_Item = 13, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 14, Name_Item = "Mithril_Staw", Quantity_Item = 1, Info_Item = "+8 to Attack", Price_Item = 810, Attack_Item = 8, Lvl_Item = 13, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 15, Name_Item = "Adamantyt_Sword", Quantity_Item = 1, Info_Item = "+12 to Attack", Price_Item = 1215, Attack_Item = 12, Lvl_Item = 16, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 16, Name_Item = "Adamantyt_Bow", Quantity_Item = 1, Info_Item = "+12 to Attack", Price_Item = 2430, Attack_Item = 12, Lvl_Item = 16, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 17, Name_Item = "Adamantyt_Staw", Quantity_Item = 1, Info_Item = "+12 to Attack", Price_Item = 2430, Attack_Item = 12, Lvl_Item = 16, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 18, Name_Item = "Orichalcum_Sword", Quantity_Item = 1, Info_Item = "+16 to Attack", Price_Item = 3650, Attack_Item = 16, Lvl_Item = 19, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 19, Name_Item = "Orichalcum_Bow", Quantity_Item = 1, Info_Item = "+16 to Attack", Price_Item = 7300, Attack_Item = 16, Lvl_Item = 19, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 20, Name_Item = "Orichalcum_Staw", Quantity_Item = 1, Info_Item = "+16 to Attack", Price_Item = 7300, Attack_Item = 16, Lvl_Item = 19, Class_Item = ClassItem.Mag },

            new Weapons_Items { ID_Item = 21, Name_Item = "DragonScale_Sword", Quantity_Item = 1, Info_Item = "+20 to Attack", Price_Item = 10950, Attack_Item = 20, Lvl_Item = 22, Class_Item = ClassItem.Warrior },
            new Weapons_Items { ID_Item = 22, Name_Item = "DragonScale_Bow", Quantity_Item = 1, Info_Item = "+20 to Attack", Price_Item = 21900, Attack_Item = 20, Lvl_Item = 22, Class_Item = ClassItem.Archer },
            new Weapons_Items { ID_Item = 23, Name_Item = "DragonScale_Staw", Quantity_Item = 1, Info_Item = "+20 to Attack", Price_Item = 21900, Attack_Item = 20, Lvl_Item = 22, Class_Item = ClassItem.Mag },
        };

        public static Utitlity_Items Search_Utitlity_Item(int ID_Item)
        {
            Utitlity_Items SearchItem = Utility_items.FirstOrDefault(Item_search => Item_search.ID_Item == ID_Item);

            return SearchItem;
        }

        public static Monsters_Items Search_Monsters_Item(int ID_Item)
        {
            Monsters_Items SearchItem = Monsters_items.FirstOrDefault(Item_search => Item_search.ID_Item == ID_Item);

            return SearchItem;
        }

        public static Armors_Items Search_Armors_Item(int ID_Item)
        {
            Armors_Items SearchItem = Armors_items.FirstOrDefault(Item_search => Item_search.ID_Item == ID_Item);

            return SearchItem;
        }

        public static Weapons_Items Search_Weapons_Item(int ID_Item)
        {
            Weapons_Items SearchItem = Weapons_items.FirstOrDefault(Item_search => Item_search.ID_Item == ID_Item);

            return SearchItem;
        }

        public static void Add_Utitlity(int ID_Item)
        {
            Utitlity_Items Search_Item_List = Search_Utitlity_Item(ID_Item);
            Utitlity_Items Search_Item_Eq = Program.Player.Utitlity_Character.FirstOrDefault(Item => Item.ID_Item == ID_Item);

            if (Search_Item_Eq != null && Search_Item_Eq.Quantity_Item >= 1)
            {
                Search_Item_Eq.Quantity_Item++;
                Console.WriteLine($"Add new item: {Search_Item_List.Name_Item}");
                Thread.Sleep(1000);
            }
            else
            {
                Program.Player.Utitlity_Character.Add(Search_Item_List);

                Console.WriteLine($"Add new item: {Search_Item_List.Name_Item}");
                Thread.Sleep(1000);
            }
        }
        public static void Add_Monsters(int ID_Item)
        {
            Monsters_Items Search_Item_List = Search_Monsters_Item(ID_Item);
            Monsters_Items Search_Item_Eq = Program.Player.Monsters_Character.FirstOrDefault(Item => Item.ID_Item == ID_Item);

            if (Search_Item_Eq != null && Search_Item_Eq.Quantity_Item >= 1)
            {
                Search_Item_Eq.Quantity_Item++;
            }
            else
            {
                Program.Player.Monsters_Character.Add(Search_Item_List);

                Console.WriteLine($"Add new item: {Search_Item_List.Name_Item}");
                Thread.Sleep(1000);
            }
        }

        public static void Add_Armors(int ID_Item)
        {
            Armors_Items Search_Item_List = Search_Armors_Item(ID_Item);
            Armors_Items Search_Item_Eq = Program.Player.Armors_Character.FirstOrDefault(Item => Item.ID_Item == ID_Item);

            if (Search_Item_Eq != null && Search_Item_Eq.Quantity_Item >= 1)
            {
                Search_Item_Eq.Quantity_Item++;
            }
            else
            {
                Program.Player.Armors_Character.Add(Search_Item_List);

                Console.WriteLine($"Add new item: {Search_Item_List.Name_Item}");
                Thread.Sleep(1000);
            }
        }

        public static void Add_Weapons(int ID_Item)
        {
            Weapons_Items Search_Item_List = Search_Weapons_Item(ID_Item);
            Weapons_Items Search_Item_Eq = Program.Player.Weapons_Character.FirstOrDefault(Item => Item.ID_Item == ID_Item);

            if (Search_Item_Eq != null && Search_Item_Eq.Quantity_Item >= 1)
            {
                Search_Item_Eq.Quantity_Item++;
            }
            else
            {
                Program.Player.Weapons_Character.Add(Search_Item_List);

                Console.WriteLine($"Add new item: {Search_Item_List.Name_Item}");
                Thread.Sleep(1000);
            }
        }
    }
}