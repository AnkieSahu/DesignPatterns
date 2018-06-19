namespace DecoratorPattern
{
    public class LargePizza : Pizza
    {
        public LargePizza()
        {
            Description = "Large Pizza";
        }
        public override string GetDescription()
        {            
            return Description;
        }
        public override decimal GetPrice()
        {
            return 30M;
        }
    }
}
