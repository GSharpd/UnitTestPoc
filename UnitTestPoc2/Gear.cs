using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestPoc2
{
    public class Gear
    {
        public string EquipmentName { get; set; }

        public int Strength { get; set; }

        public int Agility { get; set; }

        public int Health { get; set; }

        public int Energy { get; set; }

        public Gear(string name, int str, int agi, int hp, int eng)
        {
            EquipmentName = name;
            Strength = str;
            Agility = agi;
            Health = hp;
            Energy = eng;
        }
    }
}
