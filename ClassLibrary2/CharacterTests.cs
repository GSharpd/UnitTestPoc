using System;
using NUnit;
using NUnit.Framework;

namespace UnitTestPoc.Tests
{
    [TestFixture]
    public class CharacterTests
    {
        [Test]
        public void TestHuman()
        {
            Character charOne = new Character(Race.Human);
            charOne.Damage(8);
            Assert.That(charOne.Health, Is.EqualTo(2));
        }

        [Test]
        public void TestElf()
        {
            Character charTwo = new Character(Race.Elf);
            charTwo.Damage(10);
            Assert.That(charTwo.Dead, Is.True);
        }

        [Test]
        public void TestOrc()
        {
            Character orc = new Character(Race.Orc);
            orc.Strength = orc.Strength + 10;
            Assert.That(orc.Strength, Is.GreaterThan(13));
        }

        [Test]
        public void TestLvlUp()
        {
            Character elf = new Character(Race.Elf);
            elf.LevelUp(Race.Elf);
            Assert.That(elf.Agility, Is.GreaterThan(12));
        }
    }
}
