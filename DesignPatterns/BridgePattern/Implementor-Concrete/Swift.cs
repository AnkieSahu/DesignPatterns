using BridgePattern.Implementor;
using System;

namespace BridgePattern.Implementor_Concrete
{
    class Swift : IVehical
    {
        public void AssembleVehical(string vehicalType)
        {
            Console.WriteLine("Assembeled Swift Car with "+ vehicalType);
        }
    }
}
