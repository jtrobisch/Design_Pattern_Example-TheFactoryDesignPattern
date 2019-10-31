using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public enum shapeList{
        circle,square,rectangle
    }
    public class ShapeFactory
    {
        public IShape getShape(shapeList shapeType)
        {
            if(shapeType == shapeList.circle)
            {
                return  new Circle();
            }
            if (shapeType == shapeList.square)
            {
                return new Square();
            }
            if (shapeType == shapeList.rectangle)
            {
                return new Rectangle();
            }
            else
            {
                return null;
            }
        }
    }
}
