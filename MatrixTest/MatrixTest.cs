using Task2._2;

namespace MatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        [TestMethod]
        public void MatrixEmptyConstructor()
        {
            var matrix = new Matrix();
            Assert.IsTrue(matrix.Size == 0);
        }

        [TestMethod]
        public void MatrixIndexerNotDiagonal()
        {
            var matrix = new Matrix(1,2,3,4,5,6,7,8);
            Assert.IsTrue(matrix[1, 0] == 0);
            Assert.IsTrue(matrix[1, 3] == 0);
            Assert.IsTrue(matrix[5, 4] == 0);
            Assert.IsTrue(matrix[3, 8] == 0);
        }

        [TestMethod]
        public void MatrixIndexerGet()
        {
            var matrix = new Matrix(1, 2, 3, 4, 5, 6, 7, 8);
            Assert.IsTrue(matrix[13, 17] == 0);
            Assert.IsTrue(matrix[-1, 0] == 0);
            Assert.IsTrue(matrix[5, 5] == 6);
        }

        [TestMethod]
        public void MatrixIndexerSet()
        {
            var matrix = new Matrix(1, 2, 3, 4, 5, 6, 7, 8);
            matrix[4, 5] = 600;
            matrix[5, 5] = 600;
            Assert.IsTrue(matrix[4, 5] == 0);
            Assert.IsTrue(matrix[5, 5] == 600);
        }

        [TestMethod]
        public void MatrixTrack()
        {
            var matrix = new Matrix(1, 2, 3, 4, 5);
            Assert.IsTrue(matrix.Track() == 15);
        }

        [TestMethod]
        public void MatrixEquals()
        {
            var matrix1 = new Matrix(1, 2, 3, 4, 5);
            var matrix2 = new Matrix(1, 2, 3, 4, 6);
            Assert.IsFalse(matrix1.Equals(matrix2));
            matrix2[4, 4] = 5;
            Assert.IsTrue(matrix1.Equals(matrix2));
            Assert.IsTrue(matrix1.Equals(matrix1));
        }

        [TestMethod]
        public void MatrixGetHashCode()
        {
            var matrix1 = new Matrix(1, 2, 3, 4, 5);
            var matrix2 = new Matrix(1, 2, 3, 4, 6);
            Assert.IsTrue(matrix1.GetHashCode() != matrix2.GetHashCode());
            matrix2[4, 4] = 5;
            Assert.IsTrue(matrix1.GetHashCode() == matrix2.GetHashCode());
        }
    }
}