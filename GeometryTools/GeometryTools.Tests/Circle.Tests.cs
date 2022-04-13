using NUnit.Framework;

namespace GeometryTools
{
    [TestFixture]
    class CircleTests
    {
        [Test]
        public void RadiusLessThenZero()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-2));
        }

        [Test]
        public void GetArea()
        {
            Assert.AreEqual(78, (int) new Circle(5).GetArea());
        }
    }
}
