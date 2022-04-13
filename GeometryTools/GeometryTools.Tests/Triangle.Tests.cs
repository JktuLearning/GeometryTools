using NUnit.Framework;

namespace GeometryTools.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        public void SideLessThenZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 2, 0));
        }

        [Test]
        public void Area()
        {
            Assert.AreEqual(77, (int) new Triangle(3, 4, 5).GetArea());
        }

        [Test]
        public void RectangularTriangle()
        {
            Assert.IsTrue(new Triangle(3, 4, 5).IsRectangular);
        }
    }
}
