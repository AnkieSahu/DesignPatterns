using AdapterPattern.Target;

namespace AdapterPattern.Adaptee
{
    public class EmployeeManager
    {
        public ContractEmployee GetClientEmployee()
        {
            ContractEmployee ctrEmp = new ContractEmployee();
            ctrEmp.EmpID = 1;
            ctrEmp.Name = "Ankit Sahu";
            ctrEmp.GuestGift = 20000;
            ctrEmp.employeeType = EmployeeType.ContractEmployee;
            return ctrEmp;
        }
    }
}
