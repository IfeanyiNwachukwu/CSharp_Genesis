using ForCSharp.OperatorOverloading;
using ForCSharp.StringSlicing;
using System;
using System.Diagnostics;

namespace ForCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operator Overloading
            Box box1 = new(2, 2, 2);
            Box box2 = new(2, 2, 2);

            Box box3 = box1 + box2;

            Debug.WriteLine($"Length: {box3.GetLength()}");
            Debug.WriteLine($"Width: {box3.GetWidth()}");
            Debug.WriteLine($"Length: {box3.GetHeight()}");

            // String Slicing
            var result = substring.SliceString("Miracle", 2);
            Debug.WriteLine(result);

            // String Formatting
            int price1 = 100;
            int price2 = 150;
            int price3 = 200;
            Debug.WriteLine(string.Format("The item1 costes {0:C} The item1 costes {1:C}  The item1 costes {2:C}", price1,price2,price3));

            float percent = 0.5f;
            Debug.WriteLine(string.Format("The task is {0:P} complete", percent));




        }
    }
}
