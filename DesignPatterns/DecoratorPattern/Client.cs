using System;

namespace DecoratorPattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Pizza lrgPizza = new LargePizza();
            lrgPizza = new CheezeDecorator(lrgPizza);
            lrgPizza = new HampDecorator(lrgPizza);
            Console.WriteLine(lrgPizza.GetDescription());
            Console.WriteLine($"{lrgPizza.GetPrice()}$");
            Console.ReadKey();
        }
    }
}
