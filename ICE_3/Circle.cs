using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double Pi = Math.PI;

        public Circle(string shape, double radius, double pi) : base(shape)
        {
            this.Radius = radius;
            this.Pi = pi;
        }

        public double ICalculateArea()
        {
            double PiR = Pi * Radius;
            double Answer = PiR * PiR;
            return Answer;
        }

        public override void Display()
        {
            base.Display();
            Console.WriteLine(ICalculateArea() + "\n");
        }
    }
}
