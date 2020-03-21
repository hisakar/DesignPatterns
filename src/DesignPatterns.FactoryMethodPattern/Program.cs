using DesignPatterns.FactoryMethodPattern.Factories;
using System;

namespace DesignPatterns.FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomAstroidFactory = new RandomAstroidFactory();
            var astroidOne = randomAstroidFactory.GenerateProduct();
            var astroidTwo = randomAstroidFactory.GenerateProduct();
            var astroidThree= randomAstroidFactory.GenerateProduct();

            Console.WriteLine(astroidOne.ToString());
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine(astroidTwo.ToString());
            Console.WriteLine("---------------------------------------------");
            
            Console.WriteLine(astroidThree.ToString());
            Console.WriteLine("---------------------------------------------");

        }
    }
}
