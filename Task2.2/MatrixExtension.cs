using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public static class MatrixExtension
    {
        public static Matrix AddMatrix(this Matrix a, Matrix b)
        {
            var elements = new int[Math.Max(a.Size, b.Size)];
            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = a[i,i] + b[i,i];
            }
            return new Matrix(elements);
        }
    }
}
