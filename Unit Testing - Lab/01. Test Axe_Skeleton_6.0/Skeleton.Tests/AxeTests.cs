using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class AxeTests
    {
        [Test]
        public void AxeConstructorShoudWorksCorectly()
        {
            int attack = 10;
            int durablity = 20;

                Axe axe = new Axe(attack, durablity);
            Assert.AreEqual(attack, axe.AttackPoints);
            Assert.AreEqual(durablity, axe.DurabilityPoints);

        }
        [Test]
        public void AttackMethodShouldWorksProperly()
        {
            Dummy dummy = new(100, 50);
            Axe axe = new(20, 10);
           axe.Attack(dummy);

            int expectedDurability = 9;
            Assert.AreEqual(expectedDurability, axe.DurabilityPoints);
        }
        [Test]
        public void AttackMethodShoudthrowException()
        {
            Axe axe = new(15, 0);
            Dummy dummy = new(100, 50);

           Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy), "Axe is broken.");
        }
    }
}