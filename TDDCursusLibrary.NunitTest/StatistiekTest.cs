
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

using NUnit.Framework;

namespace TDDCursusLibrary.NunitTest
{
    [TestFixture]
    public class StatistiekTest
    {
        [Test]
        public void HetGemiddeldeVan10en15is12punt5()
        {
            Assert.AreEqual(12.5m, Statistiek.Gemiddelde(
            new decimal[] { 10m, 15m }));
        }
        [Test]
        public void HetGemiddeldeVanEenGetalIsDatGetal()
        {
            var enigGetal = 1.23m;
            Assert.AreEqual(enigGetal, Statistiek.Gemiddelde(
            new decimal[] { enigGetal }));
        }
        [Test]
        public void HetGemiddeldeVanEenLegeVerzamelingKanJeNietBerekenen()
        {
            Assert.Throws<ArgumentException>(() => Statistiek.Gemiddelde(new decimal[] { }));
        }
        [Test]
        public void HetGemiddeldeVanNullKanJeNietBerekenen()
        {
            Assert.Throws<ArgumentNullException>(() => Statistiek.Gemiddelde(null));
        }
    }
}
