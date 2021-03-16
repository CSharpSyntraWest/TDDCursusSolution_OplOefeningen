using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TDDCursusLibrary.Test
{
    [TestFixture]
    public class WinstServiceMockTests
    {
        private WinstService winstService;
        private IKostDAO kostDAO;
        private IOpbrengstDAO opbrengstDAO;
        private Mock<IKostDAO> mockKostDAO;           //oplossing oefening
        private Mock<IOpbrengstDAO> mockOpbrengstDAO; //oplossing oefening
        [SetUp]
        public void Initialize()
        {
            mockKostDAO = new Mock<IKostDAO>();
            kostDAO = mockKostDAO.Object;
            mockOpbrengstDAO = new Mock<IOpbrengstDAO>();  //oplossing oefening
            opbrengstDAO = mockOpbrengstDAO.Object;        //oplossing oefening
            mockKostDAO.Setup(eenKostDAO =>
             eenKostDAO.TotaleKost()).Returns(169m);
            mockOpbrengstDAO.Setup(eenOpbrengstDAO =>           //oplossing oefening
             eenOpbrengstDAO.TotaleOpbrengst()).Returns(200m);  //oplossing oefening
            winstService = new WinstService(opbrengstDAO, kostDAO);
        }
        [Test]
        public void WinstIsOpbrengstMinKost()
        {
            Assert.AreEqual(31m, winstService.Winst);
            mockKostDAO.Verify(eenKostDAO => eenKostDAO.TotaleKost());
            mockOpbrengstDAO.Verify(eenOpbrengstDAO =>                 //oplossing oefening
             eenOpbrengstDAO.TotaleOpbrengst());                      //oplossing oefening
        }
    }
}
