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
    }
}
