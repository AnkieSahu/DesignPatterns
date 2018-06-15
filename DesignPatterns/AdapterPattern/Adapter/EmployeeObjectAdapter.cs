using AdapterPattern.Adaptee;
using AdapterPattern.Target;

namespace AdapterPattern.Adapter
{
    class EmployeeObjectAdapter : IEmployee
    {
        public PermanentEmp GetEmployee()
        {
            EmployeeManager mgr = new EmployeeManager();
            ContractEmployee cntrEmp = mgr.GetClientEmployee();
            var perEmp = new PermanentEmp();
            perEmp.EmpID = cntrEmp.EmpID;
            perEmp.Name = cntrEmp.Name;
            perEmp.EmployeeTypes = EmployeeType.PermanentEmployee;
            perEmp.DeewaliBonus = cntrEmp.GuestGift * 500;
            return perEmp;
        }
    }
}
