using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MiniPoker.Test
{
    [TestClass]
    public class CalculoCartasTest
    {
        [TestMethod]
        public void CalcularSequencia_CalcularSeHeSequencia_Test()
        {
            var cartas = new int[5] { 1 , 3 , 2 , 4 , 5};

            bool isSequencia = new CalcularCarta(cartas).CalcularSequencia();

            Assert.IsTrue(isSequencia);


        }

        [TestMethod]
        public void CalcularSequencia_CalcularSeNHeSequencia_Test()
        {
            var cartas = new int[5] { 1, 3, 1, 4, 5 };

            bool isSequencia = new CalcularCarta(cartas).CalcularSequencia();

            Assert.IsFalse(isSequencia);
        }


        [TestMethod]
        public void CalcularSequencia_CalcularSeNullSequencia_Test()
        {
            int[] cartas = null;
            try
            {
                bool isSequencia = new CalcularCarta(cartas).CalcularSequencia();
            }
            catch (ArgumentNullException e) {
                Assert.IsInstanceOfType(e, typeof(ArgumentNullException));
                return;
            }

            Assert.Fail();
        }

    }
}
