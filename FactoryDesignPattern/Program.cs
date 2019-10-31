using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Factory pattern is one of the most used design patterns in programming.This type of design pattern comes under 
            //creational pattern as this pattern provides one of the best ways to create an object.
            //In Factory pattern, we create object without exposing the creation logic to the client and refer to newly created 
            //object using a common interface.


            ShapeFactory shapeFactory = new ShapeFactory();

            //get an object of Circle and call its draw method.
            IShape shape1 = shapeFactory.getShape(shapeList.circle);

            //call draw method of Circle
            shape1.drawShape();

            //get an object of Rectangle and call its draw method.
            IShape shape2 = shapeFactory.getShape(shapeList.rectangle);

            //call draw method of Rectangle
            shape2.drawShape();

            //get an object of Square and call its draw method.
            IShape shape3 = shapeFactory.getShape(shapeList.square);

            //call draw method of circle
            shape3.drawShape();

            Console.ReadLine();
        }
    }
}
