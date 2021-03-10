using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary.Test
{
    [TestFixture]
    public class WinstServiceTest
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        [SetUp]
        public void Initialize()
        {
            kostDAO = new KostDAOStub();

            opbrengstDAO = new OpbrengstDAOStub();
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }

        [Test]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
        }
    }
}
