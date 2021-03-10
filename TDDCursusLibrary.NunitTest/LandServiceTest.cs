using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace TDDCursusLibrary.NunitTest
{
    [TestFixture]
    public class LandServiceTest
    {
        private ILandDAO landDAO;
        private LandService landService;
        private Mock<ILandDAO> mockFactory;
        [SetUp]
        public void Initialize()
        {
            //landDAO = new LandDAOStub(); 
            mockFactory = new Mock<ILandDAO>();
            landDAO = mockFactory.Object;
            mockFactory.Setup(eenLandDAO => eenLandDAO.OppervlakteAlleLanden())
                 .Returns(20);
            mockFactory.Setup(eenLandDAO => eenLandDAO.Read("B")).
            Returns(new Land
            {
                Landcode = "B",
                Oppervlakte = 5
            }
            );
            //mockFactory.Setup(eenLandDAO => eenLandDAO.Read("NL"))
            //     .Returns(new Land
            //     {
            //         Landcode = "NL",
            //         Oppervlakte = 6
            //     }
            //     );
            //mockFactory.Setup(eenLandDAO => eenLandDAO.Read(string.Empty))
            //            .Throws(new ArgumentException());
            landService = new LandService(landDAO);
        }



        [Test]

        public void VindVerhoudingOppervlakteLandTovOppervlakteAlleLanden()
        {
            Assert.AreEqual(0.25m, landService.
            VindVerhoudingOppervlakteLandTovOppervlakteAlleLanden("B"));
            // hier verifiëren we of landService de methods
            // Read("B") en OppervlakteAlleALanden() heeft opgeroepen op landDAO:
            mockFactory.Verify(eenLandDAO => eenLandDAO.OppervlakteAlleLanden());
            mockFactory.Verify(eenLandDAO => eenLandDAO.Read("B"));
        }
    }
}
