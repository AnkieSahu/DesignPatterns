using AdapterPattern.Adaptee;
using AdapterPattern.Target;

namespace AdapterPattern.Adapter
{
    class EmployeeObjectAdapter : IEmployee
    {
        public PermanentEmp GetEmployee()
        {
            EmployeeManager mgr = new EmployeeManager();
            var emp = mgr.GetClientEmployee();
            var perEmp = new PermanentEmp();
            perEmp.EmpID = emp.EmpID;
            perEmp.Name = emp.Name;
            perEmp.EmployeeTypes = EmployeeType.PermanentEmployee;
            perEmp.DeewaliBonus = emp.GuestGift * 500;
            return perEmp;
        }
    }
}
