
using System;
using System.Collections.Generic;
using System.Text;
using TDDCursusLibrary;

using NUnit.Framework;

namespace TDDCursusLibrary.NunitTest
{
    [TestFixture]
    public class RekeningTest
    {
        private Rekening rekening;

        [SetUp]
        public void Initialize()
        {
            rekening = new Rekening();
        }
        [Test]
        public void HetSaldoVanEenNieuweRekeningIsNul()
        {
            //var rekening = new Rekening();
            Assert.AreEqual(decimal.Zero, rekening.Saldo);
        }
        [Test]
        public void HetSaldoNaEenEersteStortingIsHetBedragVanDieStorting()
        {
            //var rekening = new Rekening();
            var bedrag = 2.5m;
            rekening.Storten(bedrag);
            Assert.AreEqual(bedrag, rekening.Saldo);
        }

        [Test]
        public void HetSaldoNaTweeStortingenIsDeSomVanDeBedragenVanDieStortingen()
        {
            //var rekening = new Rekening();
            rekening.Storten(2.5m);
            rekening.Storten(1.2m);
            Assert.AreEqual(3.7m, rekening.Saldo);
        }
        [Test]
        public void HetBedragVanEenStortingMagNietNulZijn()
        {
            Assert.Throws<ArgumentException>(() => rekening.Storten(decimal.Zero));
        }
        [Test]
        public void HetBedragVanEenStortingMagNietNegatiefZijn()
        {
            Assert.Throws<ArgumentException>(() => rekening.Storten(-1m));
        }
    }
}
