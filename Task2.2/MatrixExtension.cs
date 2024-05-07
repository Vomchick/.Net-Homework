namespace Task2._2;

public static class MatrixExtension
{
    public static Matrix AddMatrix(this Matrix a, Matrix b)
    {
        var isABigger = a.Size > b.Size;
        var elements = new int[Math.Max(a.Size, b.Size)];

        for(var i = 0; i < elements.Length; i++)
        {
            if (isABigger)
            {
                elements[i] = a[i, i];
            }
            else
            {
                elements[i] = b[i, i];
            }   
        }

        for(var i = 0; i < Math.Min(a.Size, b.Size); i++)
        {
            if (isABigger)
            {
                elements[i] += b[i, i];
            }
            else
            {
                elements[i] += a[i, i];
            }
        }

        return new Matrix(elements);
    }
}
