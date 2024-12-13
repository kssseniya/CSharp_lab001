using zadanie2;

namespace TestProject1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double x = 2.0, y = 3.0, result = 6;
            Rectangle rectangle = new Rectangle(x,y);
            Assert.AreEqual(result, rectangle.Area);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double x = 2.0, y = 3.0, result = 10;
            Rectangle rectangle = new Rectangle(x, y);
            Assert.AreEqual(result, rectangle.Perimeter);
        }
    }
}