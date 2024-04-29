using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._1
{
    public class Point
    {
        int[] _coordinates = new int[3];
        float _mass = 0f;

        public int X
        {
            get
            {
                return _coordinates[0];
            }
            set
            {
                _coordinates[0] = value;
            }
        }

        public int Y
        {
            get
            {
                return _coordinates[1];
            }
            set
            {
                _coordinates[1] = value;
            }
        }

        public int Z
        {
            get
            {
                return _coordinates[2];
            }
            set
            {
                _coordinates[2] = value;
            }
        }

        public float Mass
        {
            get
            {
                return _mass;
            }
            set
            {
                if (value < 0f)
                {
                    _mass = 0f;
                }
                else
                {
                    _mass = value;
                }
            }
        }

        public bool isZero()
        {
            if (X == 0 && Y == 0 && Z == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Distance(Point other)
        {
            return Math.Sqrt(
                Math.Pow(X - other.X, 2) +
                Math.Pow(Y - other.Y, 2) +
                Math.Pow(Z - other.Z, 2)
                );
        }
    }

}
