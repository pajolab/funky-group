using Microsoft.VisualStudio.TestTools.UnitTesting;
using FunkyBus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyBus.Tests
{
    [TestClass()]
    public class KartaTests
    {
        [TestMethod()]
        public void RegistracijaTest_1()
        {
            Assert.IsTrue(Karta.Registracija("A", "A"));
        }

        [TestMethod()]
        public void RegistracijaTest_2()
        {
            Assert.IsFalse(Karta.Registracija("A", ""));
        }

        [TestMethod()]
        public void RegistracijaTest_3()
        {
            Assert.IsFalse(Karta.Registracija("", "A"));
        }

        [TestMethod()]
        public void RegistracijaTest_4()
        {
            Assert.IsFalse(Karta.Registracija("", ""));
        }
    }
}