using System;

namespace Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter Two numbers for Division Operation");
                Console.WriteLine("Enter Numerator");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Denominator");                 
                int b = int.Parse(Console.ReadLine()); ;
              
                var reminder = a / b;
                
                Console.WriteLine($"Result of Division Operation id {reminder}");

                Console.WriteLine("Enter max limit for the array");
                int size = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the index to fetch");
                int index = int.Parse(Console.ReadLine()); ;
                int[] integers=new int[size];

                int arrayItem = integers[index];
            }
           
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero is not allowed");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Entered index is out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
