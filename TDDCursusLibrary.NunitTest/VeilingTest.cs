using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary.Test
{
    [TestFixture]
    public class VeilingTest
    {
        private Veiling veiling;
        [SetUp]
        public void Initialize()
        {
            veiling = new Veiling();
        }
        [Test]
        public void HetHoogsteBodVanEenNieuweVeilingStaatOpNul()
        {
            Assert.AreEqual(0m, new Veiling().HoogsteBod);
        }
        [Test]
        public void NaEenEersteBodIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            veiling.DoeBod(100m);
            Assert.AreEqual(100m, veiling.HoogsteBod);
        }
        [Test]
        public void NaMeerdereBiedingenIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            veiling.DoeBod(100m);
            veiling.DoeBod(200m);
            veiling.DoeBod(150m);
            Assert.AreEqual(200, veiling.HoogsteBod);
        }
    }
}
