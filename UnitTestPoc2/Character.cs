using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using UnitTestPoc2;

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

        public List<Gear> Equipment { get; set; }

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
            Equipment = new List<Gear>
            {
                new Gear("Bow", 2, 4, 1, 3),
                new Gear("Armor", 1, 1, 5, 3)
            };
            foreach(Gear g in Equipment)
            {
                Strength = Strength + g.Strength;
                Agility = Agility + g.Agility;
                Health = Health + g.Health;
                Energy = Energy + g.Energy;
            }
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

        public void UnequipItem(string name)
        {
            var unequip = Equipment.Single(e => e.EquipmentName == name);
            if (unequip != null)
                Equipment.Remove(unequip);
            Strength -= unequip.Strength;
            Agility -= unequip.Agility;
            Health -= unequip.Health;
            Energy -= unequip.Energy;
        }

        public void EquipItem(Gear gear)
        {
            Equipment.Add(gear);
            Strength += gear.Strength;
            Agility += gear.Agility;
            Health += gear.Health;
            Energy += gear.Energy;
        }

        public void LevelUp(Race race)
        {
            switch (race)
            {
                case Race.Human:
                    Strength += 2;
                    Agility += 3;
                    Health += 5;
                    Energy += 3;
                    break;
                case Race.Elf:
                    Strength += 2;
                    Agility += 3;
                    Health += 5;
                    Energy += 3;
                    break;
                case Race.Orc:
                    Strength += 2;
                    Agility += 3;
                    Health += 5;
                    Energy += 3;
                    break;
                case Race.Dwarf:
                    Strength += 2;
                    Agility += 3;
                    Health += 5;
                    Energy += 3;
                    break;
                case Race.Gnome:
                    Strength += 2;
                    Agility += 3;
                    Health += 5;
                    Energy += 3;
                    break;
                default:
                    Strength += 1;
                    Agility += 1;
                    Health += 1;
                    Energy += 1;
                    break;
            }
        }
    }
}
