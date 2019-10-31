using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Rectangle: IShape
    {
        public void drawShape()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
