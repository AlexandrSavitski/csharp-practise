using System;
using System.Collections.Generic;
using System.Text;

namespace Lecture11.Shapes
{
    interface IShapes
    {
        void Square();
    }

    class Rectangle : IShapes
    {
        internal string name = "Rectangle";
        internal int a, b;
        internal double square;
        public void Square()
        {
            square = a * b;
        }
    }
    class Treangle : IShapes
    {
        internal string name = "Treangle";
        internal int a, h;
        internal double square;
        public void Square()
        {
            square = h * 0.5 * a;
        }
    }
    class Circle : IShapes
    {
        internal string name = "Circle";
        internal int r;
        internal double square;
        public void Square()
        {
            square = Math.PI * Math.Pow(r, 2);
        }
    }
}
