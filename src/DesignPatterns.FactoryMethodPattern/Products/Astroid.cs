using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern.Products
{
    public class Astroid : IProduct
    {
        private double _axisXCoordinate;
        private double _axisYCoordinate;
        private double _size;
        private string _astroidShape;

        public Astroid(double axisX, double axisY, double size, string astroidShape)
        {
            _axisXCoordinate = axisX;
            _axisYCoordinate = axisY;
            _size = size;
            _astroidShape = astroidShape;
        }

        public override string ToString()
        {
            return "Generated axis-x: " + _axisXCoordinate + "\nGenerated axis-y: " + _axisYCoordinate + "\nGenerated size: " + _size + "\n Generated shape:" + _astroidShape;
        }
    }
}
