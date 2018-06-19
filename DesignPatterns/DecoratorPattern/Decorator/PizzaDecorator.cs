namespace DecoratorPattern
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza _pz;
        public PizzaDecorator(Pizza pz)
        {
            this._pz = pz;
        }
        public override string GetDescription()
        {
            return _pz.Description;
        }
        public override decimal GetPrice()
        {
            return _pz.GetPrice();
        }
    }
}
