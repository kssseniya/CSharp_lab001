using zadanie3;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int x1 = 0, y1 = 0;
            Point p1 = new Point (x1, y1);
            int x2 = 0, y2 = 4;
            Point p2 = new Point(x2, y2);
            int x3 = 3, y3 = 0;
            Point p3 = new Point(x3, y3);

            Figure fig = new Figure (p1, p2, p3);

            double perimeter = 12.0;
            
            Assert.AreEqual(perimeter, fig.PerimeterCalculator());
        }
        [TestMethod]
        public void TestMethod2()
        {
            int x1 = 0, y1 = 0;
            Point p1 = new Point(x1, y1);
            int x2 = 0, y2 = 4;
            Point p2 = new Point(x2, y2);
            int x3 = 3, y3 = 0;
            Point p3 = new Point(x3, y3);

            Figure fig = new Figure(p1, p2, p3);

            
            double leng = 4.0;
            Assert.AreEqual(leng, fig.LengthSide(p1, p2));
        }
    }

}