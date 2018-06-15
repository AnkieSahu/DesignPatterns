using BridgePattern.Abstraction;
using BridgePattern.Abstraction_Refined;
using BridgePattern.Implementor_Concrete;

namespace BridgePattern
{
    class Client
    {
        static void Main(string[] args)
        {
            Petroleum petCar = new Petrol();
            petCar._IVehical = new Baleno();
            petCar.UsePetroleum();

            Petroleum dieselCar = new Diesel();
            dieselCar._IVehical = new Baleno();
            dieselCar.UsePetroleum();
        }
    }
}
