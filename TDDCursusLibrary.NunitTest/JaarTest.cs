
using TDDCursusLibrary;
using NUnit.Framework;

namespace TDDCursusLibrary.NunitTest
{
    [TestFixture]                                                    
    public class JaarTest                                             //(1)
    {
        [Test]                                                        //(2)
        public void EenJaarDeelbaarDoor400IsEenSchrikkeljaar()        //(3)
        {
              Assert.AreEqual(true, new Jaar(2000).IsSchrikkeljaar);
            //   Assert.IsTrue(new Jaar(2000).IsSchrikkeljaar);       //(4)
        }
        [Test]
        public void EenJaarDeelbaarDoor100MaarNietDoor400IsGeenSchrikkeljaar()
        {
            Assert.AreEqual(false, new Jaar(1900).IsSchrikkeljaar);
            //Assert.IsFalse(new Jaar(1900).IsSchrikkeljaar);
        }
        [Test]
        public void EenJaarDeelbaarDoor4IsEenSchrikkeljaar()
        {
           Assert.AreEqual(true, new Jaar(2012).IsSchrikkeljaar);
            //        Assert.IsTrue(new Jaar(2012).IsSchrikkeljaar);
        }
        [Test]
        public void EenJaarNietDeelbaarDoor4IsGeenSchrikkeljaar()
        {
            //   Assert.AreEqual(false, new Jaar(2015).IsSchrikkeljaar);
            Assert.IsFalse(new Jaar(2015).IsSchrikkeljaar);
        }
    }  
}
