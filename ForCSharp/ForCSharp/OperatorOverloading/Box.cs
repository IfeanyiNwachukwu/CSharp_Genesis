using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForCSharp.OperatorOverloading
{
    public class Box
    {
        private int length;
        private int width;
        private int height;

        public Box(int length, int width, int height)
        {
            this.length = length;
            this.height = height;
            this.width = width;
        }

        public int GetLength()
        {
            return length;
        }
        public int GetWidth()
        {
            return width;
        }
        public int GetHeight()
        {
            return height;
        }

        public static Box operator +(Box box1, Box box2)
        {
            return new Box(box1.height + box2.height, box1.width + box2.width, box1.length + box2.length);
        }

    }
}
