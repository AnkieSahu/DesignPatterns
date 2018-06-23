using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDisposablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example for Destructor
            /*
            DesctructorC dc = new DesctructorC();
            Console.WriteLine("C object created..");
            dc= null;
            Console.WriteLine("Assigining null destructor should be called..");
            // At this level, finalize method will not be called even object reference is null.
            // We need to call it forcely by GC.Collect();
            GC.Collect();
            */

            // Example for Dispose method
            /*
            IDisposableExample disex = new IDisposableExample();
            // this call will be handle both managed and unmanged objects.
            disex.Dispose(); 
            disex = null;
            */

            // Example when user forget to call dispose method
            /*
            IDisposableExample disex1 = new IDisposableExample();
            // this call will be handle by destructor and will clear only unmanged objects.
            disex1 = null;
            */

            Console.ReadLine();
        }
    }
}
