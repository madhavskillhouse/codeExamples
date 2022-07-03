using System;

namespace DynamicPolymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Triangle tr = new Triangle(10,10,10);
            //var triArea=tr.CalculateArea();

            //Rectangle rect = new Rectangle(10, 20);
            //var rectArea=rect.CalculateArea();

            //Square square = new Square(10);
            //var sqaureArea= square.CalculateArea();


            //Shape shape = new Triangle(10,10,10);
            //var shapeArea=shape.CalculateArea();

            //Shape shape1 = new Rectangle(10, 20);
            //var shape1Area = shape1.CalculateArea();

            //Shape shape3 = new Square(10);
            //var shape3Area = shape3.CalculateArea();

            Student student = new Bharatesh();
            var favMovie1 = student.GetFavouriteMovie();

            Student student1 = new Vraj();
            var favMovie2 = student1.GetFavouriteMovie();


            Student student2 = new Hemant();
            var favMovie3 = student2.GetFavouriteMovie();


            Student student3 = new Ganesh();
            var favMovie4 = student3.GetFavouriteMovie();



        }
    }
}
