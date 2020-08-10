using System;
using NUnit.Framework;
using UnitTestPoc2;

namespace UnitTestPoc.Tests
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void Damage_8_HealthEquals2()
        {
            Character charOne = new Character(Race.Human);
            charOne.Damage(8);
            Assert.That(charOne.Health, Is.EqualTo(2));
        }

        [Test]
        public void Damage_10_CharDead()
        {
            Character charTwo = new Character(Race.Elf);
            charTwo.Damage(10);
            Assert.That(charTwo.Dead, Is.False);
        }

        [Test]
        public void StrengthUp_10_GreaterThan13()
        {
            Character orc = new Character(Race.Orc);
            orc.Strength = orc.Strength + 10;
            Assert.That(orc.Strength, Is.GreaterThan(13));
        }

        [Test]
        public void LevelUp_Elf_AgilMoreThan12()
        {
            Character elf = new Character(Race.Elf);
            elf.LevelUp(Race.Elf);
            Assert.That(elf.Agility, Is.GreaterThan(12));
        }

        [Test]
        public void Unequip_Bow_ExpectAgi13()
        {
            Character elf = new Character(Race.Elf);
            elf.UnequipItem("Bow");
            Assert.That(elf.Agility, Is.EqualTo(13));
        }

        [Test]
        public void Equip_boots_ExpectAgi22()
        {
            Character elf = new Character(Race.Elf);
            Gear boots = new Gear("Boots", 0, 5, 2, 4);
            elf.EquipItem(boots);
            Assert.That(elf.Agility, Is.EqualTo(22));
        }
    }
}
