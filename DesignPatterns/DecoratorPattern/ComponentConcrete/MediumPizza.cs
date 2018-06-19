using System;

namespace DecoratorPattern
{
    public class MediumPizza : Pizza
    {
        public MediumPizza()
        {
            Description = "Medium Pizza";
        }
        public override string GetDescription()
        {
            return Description;
        }
        public override decimal GetPrice()
        {
            return 20M;
        }
    }
}
