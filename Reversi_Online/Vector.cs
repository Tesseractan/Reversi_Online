using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Reversi_Online
{
    class Vector
    {
        private int x = 0;
        private int y = 0;
        #region construtors
        public Vector()
        {

        }
        public Vector(Size size)
        {
            this.x = size.Width;
            this.y = size.Height;
        }
        public Vector(Point point)
        {
            this.x = point.X;
            this.y = point.Y;
        }
        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion
        #region operators
        public static Vector operator+(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X + vector2.X, vector1.Y + vector2.Y);
        }
        public static Vector operator-(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X - vector2.X, vector1.Y - vector2.Y);
        }
        public static Vector operator *(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X * vector2.X, vector1.Y * vector2.Y);
        }
        public static Vector operator /(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X / vector2.X, vector1.Y / vector2.Y);
        }
        public static Vector operator %(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X % vector2.X, vector1.Y % vector2.Y);
        }
        public static Vector operator |(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X | vector2.X, vector1.Y | vector2.Y);
        }
        public static Vector operator ^(Vector vector1, Vector vector2)
        {
            return new Vector(vector1.X ^ vector2.X, vector1.Y ^ vector2.Y);
        }
        public static bool operator<(Vector vector1, Vector vector2)
        {
            return vector1.Length < vector2.Length;
        }
        public static bool operator>(Vector vector1, Vector vector2)
        {
            return vector1.Length > vector2.Length;
        }
        public static bool operator <=(Vector vector1, Vector vector2)
        {
            return vector1.Length < vector2.Length;
        }
        public static bool operator >=(Vector vector1, Vector vector2)
        {
            return vector1.Length >= vector2.Length;
        }
        public static implicit operator Point(Vector vector)
        {
            return new Point(vector.X, vector.Y);
        }
        public static implicit operator Vector(Point point)
        {
            return new Vector(point);
        }
        #endregion
        public void Offset(Vector vector)
        {
            this.x += vector.X;
            this.y += vector.y;
        }
        public void Offset(int dx, int dy)
        {
            this.x += dx;
            this.y += dy;
        }
        public double Length
        {
            get { return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2)); }
        }
        public int X
        {
            get { return this.x; }
            set { this.x = value; }
        }
        public int Y
        {
            get { return this.y; }
            set { this.y = value; }
        }
        public bool IsZero
        {
            get { return this.x == 0 && this.y == 0; }
        }
        
    }
}
