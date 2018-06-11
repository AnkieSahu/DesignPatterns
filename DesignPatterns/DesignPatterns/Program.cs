using AdapterPattern.Adapter;
using AdapterPattern.Target;
using System;

namespace AdapterPattern
{
    class Program : PermanentEmp
    {
        static void Main(string[] args)
        {
            //// Without Adapter
            //IEmployee emp = new EmployeeManager(); // It will throw error
            //Console.WriteLine(emp.GetEmployee());

            // From Object Adapter
            IEmployee objAdptr = new EmployeeObjectAdapter();            
            Console.WriteLine(objAdptr.GetEmployee().ToString());

            // From Class Adapter
            IEmployee clsAdptr = new EmployeeClassAdapter();
            Console.WriteLine(clsAdptr.GetEmployee().ToString());


        }       
    }
}
