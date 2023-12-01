using ShapeLibrary;

namespace ShapeTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        public void Circle_CheckSquare()
        {
            Circle circle = new Circle(5);
            double expected = 78.5;
            double result = circle.GetSquare();

            Assert.AreEqual(expected, result);
        }
    }

    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        public void Triangle_CheckSquare()
        {
            Triangle triangle = new Triangle(5, 5, 5);
            double expected = 10.8;
            double result = triangle.GetSquare();

            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Triangle_CheckRectangular()
        {
            Triangle triangle = new Triangle(4, 5, 3);
            bool expected = true;
            bool result = triangle.IsRectangular();

            Assert.AreEqual(expected, result);
        }
    }
}