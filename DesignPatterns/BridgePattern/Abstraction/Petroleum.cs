using BridgePattern.Implementor;

namespace BridgePattern.Abstraction
{
    public abstract class Petroleum
    {
        public IVehical _IVehical;
        public abstract void UsePetroleum();
    }
}
