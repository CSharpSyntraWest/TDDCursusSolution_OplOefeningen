using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibraryMSTest
{
    [TestClass]
    public class VeilingTest
    {
        [TestMethod]
        public void HetHoogsteBodVanEenNieuweVeilingStaatOpNul()
        {
            Assert.AreEqual(0m, new Veiling().HoogsteBod);
        }
        [TestMethod]
        public void NaEenEersteBodIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(100m);
            Assert.AreEqual(100m, veiling.HoogsteBod);
        }
        [TestMethod]
        public void NaMeerdereBiedingenIsHetHoogsteBodGelijkAanHetBedragVanDitBod()
        {
            var veiling = new Veiling();
            veiling.DoeBod(100m);
            veiling.DoeBod(200m);
            veiling.DoeBod(150m);
            Assert.AreEqual(200, veiling.HoogsteBod);
        }
    }

}
