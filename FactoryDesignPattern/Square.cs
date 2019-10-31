using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Square: IShape
    {
        public void drawShape()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
