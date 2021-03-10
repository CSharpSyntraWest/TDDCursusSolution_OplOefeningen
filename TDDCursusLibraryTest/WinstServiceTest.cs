using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

namespace TDDCursusLibraryMSTest
{
    [TestClass]
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        [TestInitialize]
        public void Initialize()
        {
            kostDAO = new KostDAOStub();

            opbrengstDAO = new OpbrengstDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [TestMethod]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
        }
    }
}
