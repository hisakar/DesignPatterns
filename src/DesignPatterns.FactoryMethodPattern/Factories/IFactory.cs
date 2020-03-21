using DesignPatterns.FactoryMethodPattern.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryMethodPattern.Factories
{
    public interface IFactory
    {
        IProduct GenerateProduct(); 
    }
}
