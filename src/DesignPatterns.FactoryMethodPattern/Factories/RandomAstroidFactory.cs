using DesignPatterns.FactoryMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern.Factories
{
    public class RandomAstroidFactory : IFactory
    {
        string[] astroidShapes = new string[] { "Rectangle", "Triangle", "Circle" };

        public IProduct GenerateProduct()
        {
            var random = new Random();
            var axisX = random.NextDouble() * GetScreenSizeX();
            var axisY = random.NextDouble() * GetScreenSizeY();
            var size = 20 + random.NextDouble() * 50;
            var astroidShape = astroidShapes[random.Next(0,2)];

            return new Astroid(axisX, axisY, size, astroidShape);
        }

        private int GetScreenSizeX()
        {
            return 1536;
        }

        private int GetScreenSizeY()
        {
            return 864;
        }
    }
}
