using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnitTestPoc
{

    public enum Race
    {
        Human,
        Elf,
        Orc,
        Dwarf,
        Gnome
    }
    public class Character
    {
        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Health { get; set; }

        public int Energy { get; set; }

        public bool Dead { get; set; }

        public bool IsDead()
        {
            Dead = (Health <= 0);
            return Dead;
        }

        public void FillHuman()
        {
            Strength = 10;
            Agility = 10;
            Health = 10;
            Energy = 10;
        }

        public void FillElf()
        {
            Strength = 8;
            Agility = 12;
            Health = 8;
            Energy = 12;
        }

        public void FillOrc()
        {
            Strength = 13;
            Agility = 7;
            Health = 14;
            Energy = 6;
        }

        public void FillDwarf()
        {
            Strength = 11;
            Agility = 8;
            Health = 15;
            Energy = 8;
        }

        public void FillGnome()
        {
            Strength = 6;
            Agility = 13;
            Health = 9;
            Energy = 8;
        }

        public void FillDefault()
        {
            Strength = 6;
            Agility = 6;
            Health = 6;
            Energy = 6;
        }

        public Character(Race race)
        {
            switch (race)
            {
                case Race.Human:
                    FillHuman();
                    break;
                case Race.Elf:
                    FillElf();
                    break;
                case Race.Orc:
                    FillOrc();
                    break;
                case Race.Dwarf:
                    FillDwarf();
                    break;
                case Race.Gnome:
                    FillGnome();
                    break;
                default:
                    FillDefault();
                    break;
            }
        }

        public int Damage(int dmg)
        {
            Health = Health - dmg;
            IsDead();
            return Health;
            
        }
    }
}
