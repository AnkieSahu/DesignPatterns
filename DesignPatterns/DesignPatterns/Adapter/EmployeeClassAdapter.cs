using AdapterPattern.Adaptee;
using AdapterPattern.Target;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Adapter
{
    public class EmployeeClassAdapter : EmployeeManager, IEmployee
    {
        public PermanentEmp GetEmployee()
        {           
            var emp = GetClientEmployee();
            var perEmp = new PermanentEmp();
            perEmp.EmpID = emp.EmpID;
            perEmp.Name = emp.Name;
            perEmp.DeewaliBonus = emp.GuestGift * 500;
            return perEmp;
        }
    }
}
