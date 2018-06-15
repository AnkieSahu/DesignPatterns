using BridgePattern.Implementor;
using System;

namespace BridgePattern.Implementor_Concrete
{
    class Desire : IVehical
    {
        public void AssembleVehical(string vehicalType)
        {
            Console.WriteLine("Assembeled Desire Car with " + vehicalType);
        }
    }
}
