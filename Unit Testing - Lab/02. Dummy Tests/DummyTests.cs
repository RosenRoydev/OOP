using NUnit.Framework;
using System;

namespace Skeleton.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyConstructorShouldworksCorectly()
        {
            int health = 30;
            int experience = 50;

            Dummy dummy = new(30, 50);
            Assert.AreEqual(health, dummy.Health);
          
        }

        [Test]
        public void TakeAttackMethodShoulWorksCorectly()
        {
            Dummy dummy = new(30, 50);
            

            dummy.TakeAttack(20);

            int expectedHealth = 10;
            Assert.AreEqual(expectedHealth, dummy.Health);


        }

        [Test]
        public void TakeAttackMethodShouldThrowsExceptionWhenHealthIsZeroOrLower()
        {
            Dummy dummy = new(30, 50);
            dummy.TakeAttack(15);
            dummy.TakeAttack(15);



            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(20), "Dummy is dead.");
        }

        [Test]
        public void MethodGiveExperienceShoulWorksCorectly()
        {
            Dummy dummy = new(20, 50);
            dummy.TakeAttack(20);

           

            int expectedexperience = 50;

            Assert.AreEqual(expectedexperience, dummy.GiveExperience());
        }
        [Test]
        public void MethodGiveExperienceShoulthrowsExceptionWhenDummyIsNotDead()
        {
            Dummy dummy = new(20, 62);
            dummy.TakeAttack(10);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience(), "Target is not dead.");
        }
        [Test]
        public void MethodIsDeadShouldreturnTrueIfDummyHelthIsZeoroOrLessZero()
        {
            Dummy dummy = new Dummy(0, 40);
            

            Assert.IsTrue(dummy.IsDead()); 
        }

    } 
}