using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Matrix
    {
        int[] _elements;
        public int Size { get; }

        public Matrix(params int[] elements)
        {
            if (elements == null)
            {
                Size = 0;
                _elements = [];
            }
            else
            {
                Size = elements.Length;
                _elements = elements;
            }

        }

        public int this[int i, int j]
        {
            get 
            {
                if (IndexCheck(i,j) && i == j)
                {
                    return _elements[i];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if (IndexCheck(i,j) && i == j)
                {
                    _elements[i] = value;
                }
            }
        }
        bool IndexCheck(int i, int j)
        {
            if(i < Size && i  >= 0 && j < Size && j >= 0)
            {
                return true;
            }
            return false;
        }

        public int Track()
        {
            int sum = 0;
            foreach (int i in _elements) 
            {
                sum += i;
            }
            return sum;
        }

        public override bool Equals(object? obj)
        {
            var matrix = obj as Matrix;
            if (matrix != null && matrix.Size == Size)
            {
                for (int i = 0; i < Size; i++)
                {
                    if (matrix[i,i] != _elements[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    sb.Append(this[i,j] + " ");
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public override int GetHashCode()
        {
            int hash = 0;
            foreach(var element in _elements)
            {
                hash += element.GetHashCode();
            }
            return hash + Size.GetHashCode();
        }
    }
}
