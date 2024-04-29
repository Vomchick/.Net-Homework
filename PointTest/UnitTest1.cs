using Task2._1;

namespace PointTest
{
    [TestClass]
    public class PointTests
    {
        [TestMethod]
        public void PointMassNegativeValue()
        {
            var point1 = new Task2._1.Point()
            {
                X = 1,
                Y = 2,
                Z = 3,
                Mass = -4f
            };

            Assert.IsTrue(point1.Mass == 0f);
        }

        [TestMethod]
        public void PointIsZero()
        {
            var point1 = new Task2._1.Point()
            {
                X = 1,
                Y = 2,
                Z = 3,
                Mass = -4f
            };

            Assert.IsFalse(point1.isZero());
            point1.X = 0;
            Assert.IsFalse(point1.isZero());
            point1.Y = 0;
            Assert.IsFalse(point1.isZero());
            point1.Z = 0;
            Assert.IsTrue(point1.isZero());
        }

        [TestMethod]
        public void PointDistanceToZeroPoint()
        {
            var point1 = new Point()
            {
                X = 1,
                Y = 2,
                Z = 3,
                Mass = -4f
            };

            var point2 = new Point()
            {
                X = 0,
                Y = 0,
                Z = 0,
                Mass = 5f
            };
            Assert.IsTrue(point1.Distance(point2) == 3.7416573867739413);
        }

        [TestMethod]
        public void PointDistanceToItself()
        {
            var point1 = new Point()
            {
                X = 1,
                Y = 2,
                Z = 3,
                Mass = -4f
            };

            Assert.IsTrue(point1.Distance(point1) == 0.0);
        }

        [TestMethod]
        public void PointDistanceToOtherPoint()
        {
            var point1 = new Point()
            {
                X = 1,
                Y = 2,
                Z = 3,
                Mass = -4f
            };

            var point2 = new Point()
            {
                X = 7,
                Y = 1,
                Z = 3,
                Mass = 5f
            };

            Assert.IsTrue(point1.Distance(point2) == 6.082762530298219);
        }

        [TestMethod]
        public void PointDistanceToOtherPointSwapped()
        {
            var point1 = new Point()
            {
                X = 1,
                Y = 2,
                Z = 3,
                Mass = -4f
            };

            var point2 = new Point()
            {
                X = 7,
                Y = 1,
                Z = 3,
                Mass = 5f
            };

            Assert.IsTrue(point2.Distance(point1) == 6.082762530298219);
        }
    }
}