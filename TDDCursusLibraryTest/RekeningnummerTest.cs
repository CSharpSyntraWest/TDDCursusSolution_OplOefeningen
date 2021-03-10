using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibraryTest
{
    [TestClass]
    public class RekeningnummerTest
    {
        [TestMethod]
        public void NummerMet12CijfersMetCorrectControleIsOK()
        {
            // dit nummer mag geen exception veroorzaken
            new Rekeningnummer("063-1547564-61");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersMetVerkeerdeControleIsVerkeerd()
        {
            new Rekeningnummer("063-1547564-62");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet12CijfersZonderStreepjesMetCorrectControleIsVerkeerd()
        {
            new Rekeningnummer("063154756461");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet13CijfersIsVerkeerd()
        {
            new Rekeningnummer("063-1547564-623");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void NummerMet11CijfersIsVerkeerd()
        {
            new Rekeningnummer("063-1547564-6");
        }
        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void LeegNummerIsVerkeerd()
        {
            new Rekeningnummer(string.Empty);
        }
        [TestMethod, ExpectedException(typeof(ArgumentNullException))]
        public void NummerMetNullIsVerkeerd()
        {
            new Rekeningnummer(null);
        }
        [TestMethod]
        public void ToStringMoetHetNummerTeruggeven()
        {
            var nummer = "063-1547564-61";
            var rekeningnummer = new Rekeningnummer(nummer);
            Assert.AreEqual(nummer, rekeningnummer.ToString());
        }
    }
}
