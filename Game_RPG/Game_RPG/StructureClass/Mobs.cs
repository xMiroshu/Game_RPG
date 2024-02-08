using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_RPG.PlayerClass;

namespace Game_RPG.StructureClass
{
    public class Mob_Model
    {
        public string Name_Mob;
        public int Strength_Mob;
        public int Intelligence_Mob;
        public int Dexterity_Mob;
        public int Stamina_Mob;
        public int HP_Mob;
        public int MaxHP_Mob;
        public int MP_Mob;
        public int MaxMP_Mob;
        public int Exp_Drop_Mob;
        public int Money_Drop_Mob;
        public int Defence_Mob;
        public int Energy_Level_Mob;
        public int Attack_Mob;

        public Mob_Model(string Name_mob, int Strength_mob, int Intelligence_mob, int Dexterity_mob, int Stamina_mob, int HP_mob, int MP_mob, int Exp_Drop_mob, int Money_Drop_mob, int Defence_mob)
        {
            Name_Mob = Name_mob;
            Strength_Mob = Strength_mob;
            Intelligence_Mob = Intelligence_mob;
            Dexterity_Mob = Dexterity_mob;
            Stamina_Mob = Stamina_mob;
            HP_Mob = HP_mob;
            MaxHP_Mob = HP_mob;
            MP_Mob = MP_mob;
            MaxMP_Mob = MP_mob;
            Exp_Drop_Mob = Exp_Drop_mob;
            Money_Drop_Mob = Money_Drop_mob;
            Defence_Mob = Defence_mob;
            Energy_Level_Mob = Stamina_Mob * 2;
            Attack_Mob = Strength_Mob / 2;
        }
    }

    class Goblin : Mob_Model
    {
        public Goblin() : base("Goblin", 11, 5, 15, 15, 55, 0, 2, 5, 2) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
        };
    }

    class Goblin_Rider : Mob_Model
    {
        public Goblin_Rider() : base("Goblin_Rider", 19, 10, 22, 25, 100, 0, 6, 20, 7) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
            new Skill_Model { ID_Skill = 5, Name_Skill = "Jump Attack", Cost_Skill = 10, Damage_Skill = 30, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 30 damage" },
        };
    }

    class Goblin_King : Mob_Model
    {
        public Goblin_King() : base("Goblin_King", 30, 12, 25, 40, 250, 50, 10, 50, 12) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
            new Skill_Model { ID_Skill = 4, Name_Skill = "Crushing Blow", Cost_Skill = 25, Damage_Skill = 50, Learning_Prerequisites_Skill = 30, Description_Skill = "Deals 50 damage" },
            new Skill_Model { ID_Skill = 5, Name_Skill = "Jump Attack", Cost_Skill = 10, Damage_Skill = 30, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 30 damage" },
            new Skill_Model { ID_Skill = 2, Name_Skill = "Lightning", Cost_Skill = 20, Damage_Skill = 35, Learning_Prerequisites_Skill = 18, Description_Skill = "Deals 35 damage" },
        };
    }

    class Slime : Mob_Model
    {
        public Slime() : base("Slime", 6, 3, 10, 10, 40, 0, 1, 3, 1) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
        };
    }

    class Wolf : Mob_Model
    {
        public Wolf() : base("Wolf", 15, 8, 20, 20, 80, 0, 3, 10, 4) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
        };
    }

    class Troll : Mob_Model
    {
        public Troll() : base("Troll", 20, 5, 10, 30, 120, 0, 5, 15, 6) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
            new Skill_Model { ID_Skill = 6, Name_Skill = "Healing", Cost_Skill = 30, Damage_Skill = 35, Learning_Prerequisites_Skill = 25, Description_Skill = "Restores 35HP" },
        };
    }

    class Big_Spider : Mob_Model
    {
        public Big_Spider() : base("Big_Spider", 12, 8, 17, 30, 70, 0, 3, 10, 3) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
        };
    }

    class Zombie : Mob_Model
    {
        public Zombie() : base("Zombie", 10, 4, 10, 20, 50, 0, 2, 5, 3) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List { get; private set; } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage"},
        };
    }

    class Behemot : Mob_Model
    {
        public Behemot() : base("Behemot", 35, 15, 25, 40, 300, 50, 10, 50, 10) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List
        {
            get; private set;
        } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
            new Skill_Model { ID_Skill = 4, Name_Skill = "Crushing Blow", Cost_Skill = 25, Damage_Skill = 50, Learning_Prerequisites_Skill = 30, Description_Skill = "Deals 50 damage" },
            new Skill_Model { ID_Skill = 6, Name_Skill = "Master Kick", Cost_Skill = 15, Damage_Skill = 40, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 40 damage" },
        };
    }

    class Beelzebub : Mob_Model
    {
        public Beelzebub() : base("Beelzebub", 30, 15, 28, 40, 350, 50, 12, 70, 13) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
        public List<Skill_Model> Mob_Skill_List
        {
            get; private set;
        } = new()
        {
            new Skill_Model { ID_Skill = 0, Name_Skill = "Strong swing", Cost_Skill = 5, Damage_Skill = 25, Learning_Prerequisites_Skill = 10, Description_Skill = "Deals 25 damage" },
            new Skill_Model { ID_Skill = 1, Name_Skill = "A powerful blow ", Cost_Skill = 10, Damage_Skill = 35, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 35 damage" },
            new Skill_Model { ID_Skill = 4, Name_Skill = "Crushing Blow", Cost_Skill = 25, Damage_Skill = 50, Learning_Prerequisites_Skill = 30, Description_Skill = "Deals 50 damage" },
            new Skill_Model { ID_Skill = 6, Name_Skill = "Master Kick", Cost_Skill = 15, Damage_Skill = 40, Learning_Prerequisites_Skill = 20, Description_Skill = "Deals 40 damage" },
        };
    }

    class Pig : Mob_Model
    {
        public Pig() : base("Pig", 5, 5, 5, 5, 5, 5, 0, 0, 0) //Name, Str, Int, Dex, Stam, HP, MP, EXP, GOLD, DEF
        {
        }
    }
}