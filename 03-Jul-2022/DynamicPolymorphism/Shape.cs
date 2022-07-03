using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicPolymorphism
{
    public class Shape
    {
        public List<int> sides;
        public int sideCount;

        public virtual double CalculateArea()
        {
            return 0;
        }
    }

    public class Triangle:Shape
    {
        public Triangle(int side1,int side2,int side3)
        {
            sideCount = 3;
            sides = new List<int>() { side1, side2, side3 };
        }

        public override double CalculateArea()
        {
            return .5 *sides[0] * sides[1];
        }
    }

    public class Rectangle : Shape
    {

        public Rectangle(int side1, int side2)
        {
            sideCount = 4;
            sides = new List<int>() { side1, side2, side1,side2 };
        }

        public override double CalculateArea()
        {
            return  sides[0] * sides[1];
        }

    }


    public class Square : Shape
    {

        public Square(int side1)
        {
            sideCount = 4;
            sides = new List<int>() { side1, side1, side1, side1 };
        }

        public override double CalculateArea()
        {
            return sides[0] * sides[0];
        }

    }
}
