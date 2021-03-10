using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary.Test
{
    [TestFixture]
    public class WinstServiceTest2
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private Mock<IKostDAO> mockKostDAO;
        private Mock<IOpbrengstDAO> mockOpbrengstDAO;
        [SetUp]
        public void Initialize()
        {
            mockKostDAO = new Mock<IKostDAO>();
            kostDAO = mockKostDAO.Object;
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();
            opbrengstDAO = mockOpbrengstDAO.Object;
            mockKostDAO.Setup(eenKostDAO =>
             eenKostDAO.TotaleKost()).Returns(169m);
            mockOpbrengstDAO.Setup(eenOpbrengstDAO =>
             eenOpbrengstDAO.TotaleOpbrengst()).Returns(200m);
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [Test]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
            mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO =>
             eenOpbrengstDAO.TotaleOpbrengst());
        }
    }
}
