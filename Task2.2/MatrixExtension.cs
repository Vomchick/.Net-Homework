namespace Task2._2;

public static class MatrixExtension
{
    public static Matrix AddMatrix(this Matrix a, Matrix b)
    {
        var elements = new int[Math.Max(a.Size, b.Size)];
        var minSize = Math.Min(a.Size, b.Size);
        var isASmaller = a.Size < b.Size;
        for (int i = 0; i < elements.Length; i++)
        {
            if (i < minSize)
            {
                elements[i] = a[i, i] + b[i, i];
            }
            else if (isASmaller)
            {
                elements[i] = b[i, i];    
            }
            else
            {
                elements[i] = a[i, i];
            }
        }
        return new Matrix(elements);
    }
}
