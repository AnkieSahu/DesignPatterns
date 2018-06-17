namespace BuilderPattern
{
    public abstract class CakeBuilder
    {
        protected Cake cake;
        public Cake GetCake()
        {
            return cake;
        }
        public void PrepareCake()
        {
            cake = new Cake();
        }
        public abstract void PrepareBase();
        public abstract void AddCream();
        public abstract void AddToppings();
        public abstract void Bake();
    }
}
