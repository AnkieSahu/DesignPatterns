using System;

namespace DecoratorPattern
{
    public class SmallPizza : Pizza
    {
        public SmallPizza()
        {
            Description = "Small Pizza";
        }
        public override string GetDescription()
        {
            return Description;
        }

        public override decimal GetPrice()
        {
            return 10M;
        }
    }
}
