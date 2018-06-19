namespace DecoratorPattern
{
    public class CheezeDecorator : PizzaDecorator
    {
        public CheezeDecorator(Pizza pz) : base(pz)
        {
            Description = "Cheeze";
        }
        public override string GetDescription()
        {
            return $"{_pz.GetDescription()} {Description}";
        }
        public override decimal GetPrice()
        {
            return base.GetPrice() + 2;
        }
    }
}
