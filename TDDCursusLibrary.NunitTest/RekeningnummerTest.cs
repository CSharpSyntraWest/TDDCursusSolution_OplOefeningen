
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;
using NUnit.Framework;

namespace TDDCursusLibrary.NunitTest
{
    [TestFixture]
    public class RekeningnummerTest
    {
        [Test]
        public void NummerMet12CijfersMetCorrectControleIsOK()
        {
            // dit nummer mag geen exception veroorzaken
            new Rekeningnummer("063-1547564-61");
        }
        [Test]
        public void NummerMet12CijfersMetVerkeerdeControleIsVerkeerd()
        {
            Assert.Throws<ArgumentException>(() => new Rekeningnummer("063-1547564-62"));
        }
        [Test]
        public void NummerMet12CijfersZonderStreepjesMetCorrectControleIsVerkeerd()
        {

            Assert.Throws<ArgumentException>(() => new Rekeningnummer("063154756461"));
        }
        [Test]
        public void NummerMet13CijfersIsVerkeerd()
        {
            Assert.Throws<ArgumentException>(() => new Rekeningnummer("063-1547564-623"));
        }
        [Test]
        public void NummerMet11CijfersIsVerkeerd()
        {
            Assert.Throws<ArgumentException>(() => new Rekeningnummer("063-1547564-6"));
        }
        [Test]
        public void LeegNummerIsVerkeerd()
        {
            Assert.Throws<ArgumentException>(() => new Rekeningnummer(string.Empty));
        }
        [Test]
        public void NummerMetNullIsVerkeerd()
        {
            Assert.Throws<ArgumentNullException>(() => new Rekeningnummer(null));
        }
        [Test]
        public void ToStringMoetHetNummerTeruggeven()
        {
            var nummer = "063-1547564-61";
            var rekeningnummer = new Rekeningnummer(nummer);
            Assert.AreEqual(nummer, rekeningnummer.ToString());
        }
    }
}
