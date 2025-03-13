using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICE_3
{
    abstract class Shape
    {
        public string ShapeName { get; set; }

        public Shape(string shapeName)
        {
            this.ShapeName = shapeName;
        }

        public virtual void Display()
        {
            Console.WriteLine($"{ShapeName}'s area is: ");
        }
    }
}
