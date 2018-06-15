using AdapterPattern.Adaptee;
using AdapterPattern.Target;

namespace AdapterPattern.Adapter
{
    public class EmployeeClassAdapter : EmployeeManager, IEmployee
    {
        public PermanentEmp GetEmployee()
        {
            ContractEmployee cntrEmp = GetClientEmployee();
            var perEmp = new PermanentEmp();
            perEmp.EmpID = cntrEmp.EmpID;
            perEmp.Name = cntrEmp.Name;
            perEmp.DeewaliBonus = cntrEmp.GuestGift * 500;
            return perEmp;
        }
    }
}
