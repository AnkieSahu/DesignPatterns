namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var chocolateCakeMaker = new CakeMaker(new ChocolateCake());
            chocolateCakeMaker.MakeCake();
            var cake = chocolateCakeMaker.GetCake();
            cake.ServeCake();

            System.Console.WriteLine("=========================================");

            var strawberryCakeMaker = new CakeMaker(new StrawberryCake());
            strawberryCakeMaker.MakeCake();
            var strawberryCake = strawberryCakeMaker.GetCake();
            cake.ServeCake();
        }
    }
}
