namespace BuilderPattern
{
    public class StrawberryCake : CakeBuilder
    {
        public override void PrepareBase()
        {
            cake.BaseType = CakeBaseType.Crunchy;
            System.Console.WriteLine("Preparing Base of type " + cake.BaseType);
        }
        public override void AddCream()
        {
            cake.CreamType = CreamType.Strawberry;
            System.Console.WriteLine("Applying cream of flavour " + cake.CreamType);
        }
        public override void AddToppings()
        {
            cake.Toppings = new System.Collections.Generic.List<FruitToppings>();
            cake.Toppings.Add(FruitToppings.Strawberry);
            cake.Toppings.Add(FruitToppings.Berries);
            System.Console.WriteLine($"Add toppings {string.Join(", ", cake.Toppings)}");
        }
        public override void Bake()
        {
            System.Console.WriteLine($"Baking the cake at 300c tempreture and cake is ready now.. :)");
        }
    }
}
