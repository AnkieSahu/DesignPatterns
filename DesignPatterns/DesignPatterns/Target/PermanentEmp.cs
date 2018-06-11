namespace AdapterPattern.Target
{
    public class PermanentEmp
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public EmployeeType EmployeeTypes { get; set; }
        public long DeewaliBonus { get; set; }
        public override string ToString()
        {
            return $"EmpID:{EmpID}, Name:{Name}, EmployeeType:{EmployeeTypes.ToString()} Bonus:{DeewaliBonus}";
        }
    }
}
