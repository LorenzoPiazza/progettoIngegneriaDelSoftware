﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fantacalcio.Dominio;

namespace TestDominio
{
    [TestFixture]
    public class TestLega
    {
        private Lega _lega;
        [SetUp]
        public void LegaSetUp()
        {
            _lega = new Lega("FantacalcioClub", 10, "SquareFC");
        }

        [Test]
        public void TestMethod()
        {
            //Verifica dei parametri passati al costruttore
            StringAssert.Equals(_lega.NomeLega, "FantacalcioClub");
            Assert.AreEqual(_lega.NumeroSquadreTotali, 10);
            Assert.AreEqual(_lega.SquadraAdmin, "SquareFC");

            //Verifica dei parametri settati di default
            Assert.AreEqual(_lega.NumeroPor, 3);
            Assert.AreEqual(_lega.NumeroDif, 8);
            Assert.AreEqual(_lega.NumeroCen, 8);
            Assert.AreEqual(_lega.NumeroAtt, 6);
            Assert.AreEqual(_lega.CreditiInizialiSquadra, 500);
            CollectionAssert.Contains(_lega.Squadre, _lega.SquadraAdmin);
            Assert.Null(_lega.Mercato);
            Assert.Null(_lega.ListaSvincolati);

        }
    }
}