using Calclibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalcLibrary_Test
{
    [TestClass]
    public class Calc_Test
    {
        [TestMethod]
        public void PositiveSum()
        {
            {
                int n1 = 3;
                int n2 = 4;
                int somma_aspettata = 7;
                int somma = calc.Somma( n1, n2) ;
                Assert.AreEqual(somma_aspettata, somma);
            }
        }
    }
}
