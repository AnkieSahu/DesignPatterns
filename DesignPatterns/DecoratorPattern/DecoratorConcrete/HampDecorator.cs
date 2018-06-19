namespace DecoratorPattern
{
    public class HampDecorator : PizzaDecorator
    {
        public HampDecorator(Pizza pz) : base(pz)
        {
            Description = "Hamp";
        }
        public override string GetDescription()
        {
            return $"{_pz.GetDescription()} {Description}";            
        }
        public override decimal GetPrice()
        {
            return base.GetPrice() + 3;
        }
    }
}
