using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibraryMSTest
{
    [TestClass]
    public class WoordTest
    {
        [TestMethod]
        public void LepelIsEenPalindroom()
        {
            Assert.IsTrue(new Woord("lepel").IsPalindroom());
        }
        [TestMethod]
        public void VorkIsGeenPalindroom()
        {
            Assert.IsFalse(new Woord("vork").IsPalindroom());
        }
        [TestMethod]
        public void EenLegeStringIsEenPalindroom()
        {
            Assert.IsTrue(new Woord(String.Empty).IsPalindroom());
        }
    }
}
