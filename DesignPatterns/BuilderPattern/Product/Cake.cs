using System.Collections.Generic;

namespace BuilderPattern
{
    public class Cake
    {
        public CakeBaseType BaseType { get; set; }
        public CreamType CreamType { get; set; }
        public List<FruitToppings> Toppings { get; set; }
        public void ServeCake()
        {
            System.Console.WriteLine($"Enjoy the cake with {BaseType} base and {CreamType} cream and {string.Join(", ",Toppings)} toppings");
        }
    }
    public enum FruitToppings
    {
        Cheery,
        Strawberry,
        Berries
    }    
    public enum CreamType
    {
        Vanilla,
        Strawberry,
        Chocolate,
        PineApple
    }
    public enum CakeBaseType
    {
        Soft,
        Crunchy,
        Thin
    }    
}
