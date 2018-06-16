namespace BuilderPattern
{
    public class CakeMaker
    {
        private readonly CakeBuilder builder;
        public CakeMaker(CakeBuilder builder)
        {
            this.builder = builder;
        }
        public void MakeCake()
        {
            builder.PrepareCake();
            builder.PrepareBase();
            builder.AddCream();
            builder.AddToppings();
            builder.Bake();
        }
        public Cake GetCake()
        {
            return builder.GetCake();
        }
    }
}
