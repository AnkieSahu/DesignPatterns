using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Target
{
    interface IEmployee
    {
        PermanentEmp GetEmployee();
    }
    public enum EmployeeType
    {
        PermanentEmployee,
        ContractEmployee
    }
}
