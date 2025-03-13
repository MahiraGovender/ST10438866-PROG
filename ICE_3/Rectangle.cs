using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3
{
    class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(string shape, double length, double width) : base(shape)
        {
            this.Length = length;
            this.Width = width;
        }

        public double ICalculateArea()
        {
            double Answer = Length * Width;
            return Answer;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(ICalculateArea() + "\n");
        }
    }
}
