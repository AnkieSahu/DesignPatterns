using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposablePattern
{
    public class DesctructorA
    {
        public DesctructorA()
        {
            Console.WriteLine("Class A Contructor called..");
        }
        ~DesctructorA()
        {
            Console.WriteLine("Class A destructor called..");
        }
    }
    public class DesctructorB : DesctructorA
    {
        public DesctructorB()
        {
            Console.WriteLine("Class B Contructor called..");
        }
        ~DesctructorB()
        {
            Console.WriteLine("Class B destructor called..");
        }
    }
    public class DesctructorC : DesctructorB
    {
        public DesctructorC()
        {
            Console.WriteLine("Class C Contructor called..");
        }
        ~DesctructorC()
        {
            Console.WriteLine("Class C destructor called..");
        }
    }
}
