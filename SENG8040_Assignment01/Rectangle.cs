using System;
using System.Collections.Generic;
using System.Text;

namespace SENG8040_Assignment01
{
    public class Rectangle
    {

        private int length;
        private int width;

        // Constructor; default values are 1,1
        public Rectangle()
        {
            this.length = 1;
            this.width = 1;
        }

        // Constructor2 to set length and width for values inoutted by user
        public Rectangle(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        //to get area of rectangle
        public int GetArea()
        {
            return (this.length * this.width);
        }

        //to get perimeter of rectangle
        public int GetPerimeter()
        {
            return (2 * (this.length + this.width));
        }

        public int GetLength()
        {
            return this.length;
        }

        public void SetLength(int length)
        {
            this.length = length;
            return;
        }

        public int GetWidth()
        {
            return this.width;
        }

        public void SetWidth(int width)
        {
            this.width = width;
            return;
        }

    }
}
