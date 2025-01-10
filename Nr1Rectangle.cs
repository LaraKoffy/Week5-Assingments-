using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nr1
{
    internal class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

       
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

      
        public double CalculateArea()
        {
            return Width * Height;
        }

        
        public double CalculatePerimeter()
        {
            return 2 * (Width + Height);
        }
    }
}
