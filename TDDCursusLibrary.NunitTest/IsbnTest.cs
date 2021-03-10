using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary.Test
{
    [TestFixture]
    public class IsbnTest
    {
        [Test]
        public void HetNummer0IsVerkeerd()
        {
           Assert.Throws<ArgumentException>(() => new Isbn(0));
        }
        [Test]
        public void EenNegatiefNummerIsVerkeerd()
        {
             Assert.Throws<ArgumentException>(() => new Isbn(-9789027439642L));
        }
        [Test]
        public void EenNummerMet12CijfersIsVerkeerd()
        {
             Assert.Throws<ArgumentException>(() => new Isbn(978902743964L));
        }
        [Test]
        public void EenNummerMet14CijfersIsVerkeerd()
        {
            Assert.Throws<ArgumentException>(() => new Isbn(97890274396421L));
        }
        [Test]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal2()
        {
            Assert.Throws<ArgumentException>(() => new Isbn(8789027439642L));
        }
        [Test]
        public void EenNummerMet13CijfersMetCorrectControleGetal2()
        {
            new Isbn(9789027439642L);
        }
        [Test]
        public void EenNummerMet13CijfersMetVerkeerdControleGetal0()
        {
             Assert.Throws<ArgumentException>(() => new Isbn(7789227439640L));
        }
        [Test]
        public void EenNummerMet13CijfersMetCorrectControleGetal0()
        {
            new Isbn(9789227439640L);
        }
    }
}
