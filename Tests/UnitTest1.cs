using NUnit.Framework;
using Raindrops;
using System;

namespace Tests
{
    public class Tests
    {
        RainDrops obj = new RainDrops();


        [TestCase(6, "Pling")]
        [TestCase(12, "Pling")]
        [TestCase(33, "Pling")]
        [TestCase(-33, "Pling")]
        public void NumberDivisableByThreeReturnsPling(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(5, "Plang")]
        [TestCase(40, "Plang")]
        [TestCase(55, "Plang")]
        [TestCase(-55, "Plang")]
        public void NumberDivisableByFiveReturnsPlang(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(7, "Plong")]
        [TestCase(14, "Plong")]
        [TestCase(28, "Plong")]
        [TestCase(-28, "Plong")]
        public void NumberDivisableBySevenReturnsPlong(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }


        [TestCase(4, "4")]
        [TestCase(101, "101")]
        [TestCase(-4, "-4")]
        public void NumberNotDivisableByThreeOrFiveOrSevenReturnsInput(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(15, "PlingPlang")]
        [TestCase(60, "PlingPlang")]
        [TestCase(-60, "PlingPlang")]
        public void NumberDivisableByThreeAndFiveReturnsPlingPlang(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(21, "PlingPlong")]
        [TestCase(63, "PlingPlong")]
        [TestCase(-63, "PlingPlong")]
        public void NumberDivisableByThreeAndSevenReturnsPlingPlong(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(35, "PlangPlong")]
        [TestCase(140, "PlangPlong")]
        [TestCase(-140, "PlangPlong")]
        public void NumberDivisableByFiveAndSevenReturnsPlangPlong(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

        [TestCase(105, "PlingPlangPlong")]
        [TestCase(1050, "PlingPlangPlong")]
        [TestCase(-1050, "PlingPlangPlong")]
        public void NumberDivisableByThreeAndFiveAndSevenReturnsPlingPlangPlong(int input, string expected)
        {
            string actual = obj.PlingPlangPlong(input);
            Assert.That(actual, Is.EqualTo(expected));
        }

    }
}