using BridgePattern.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern.Abstraction_Refined
{
    public class Diesel : Petroleum
    {
        public override void UsePetroleum()
        {
            _IVehical.AssembleVehical("Diesel");
        }
    }
}
