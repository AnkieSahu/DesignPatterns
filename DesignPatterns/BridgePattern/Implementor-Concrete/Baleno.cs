using BridgePattern.Implementor;
using System;

namespace BridgePattern.Implementor_Concrete
{
    class Baleno : IVehical
    {
        public void AssembleVehical(string vehicalType)
        {
            Console.WriteLine("Assembeled Baleno Car with " + vehicalType);
        }
    }
}
