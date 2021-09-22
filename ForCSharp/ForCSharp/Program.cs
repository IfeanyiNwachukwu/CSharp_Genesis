using ForCSharp.OperatorOverloading;
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
        }
    }
}
