﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class Circle: IShape
    {
        public void drawShape()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
