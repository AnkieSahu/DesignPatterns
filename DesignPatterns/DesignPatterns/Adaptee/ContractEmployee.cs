using AdapterPattern.Target;

namespace AdapterPattern.Adaptee
{
    public class ContractEmployee
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public EmployeeType employeeType { get; set; }
        public long GuestGift { get; set; }
    }
}
