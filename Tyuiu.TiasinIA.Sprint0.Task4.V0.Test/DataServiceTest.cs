using Tyuiu.TiasinIA.Sprint0.Task4.V0.lLib;

namespace Tyuiu.TiasinIA.Sprint0.Task4.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedAdditionValild()
        {
            Assert.AreEqual(10, DataService.Addition(5, 5));
        }
        [TestMethod]
        public void CheckedSubtractionValild()
        {
            Assert.AreEqual(5, DataService.Subtraction(10, 5));
        }
        [TestMethod]
        public void CheckedMultiplicationValild()
        {
            Assert.AreEqual(50, DataService.Multiplication(10, 5));
        }
        [TestMethod]
        public void CheckedDivisionValild()
        {
            Assert.AreEqual(3, DataService.Division(9, 3));
        }
             
    }
}