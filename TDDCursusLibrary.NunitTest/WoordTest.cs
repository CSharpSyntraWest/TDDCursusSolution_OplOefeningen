using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibrary.NunitTest
{
    [TestFixture]
    public class WoordTest
    {
        [Test]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }
        [Test]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("vork").IsPalindroom());
        }
        [Test]
        public void EenLegeStringIsEenPalindroom()
        {
            Assert.IsTrue(new Woord(String.Empty).IsPalindroom());
        }
    }
}
