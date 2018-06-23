using System;

namespace IDisposablePattern
{
    public class IDisposableExample : IDisposable
    {
        /// <summary>
        /// Check to varify that object is already disposed or not
        /// </summary>
        private bool isDisposed = false;

        public IDisposableExample()
        {
            Console.WriteLine("Constructor called..");
        }
        /// <summary>
        /// Destructor will be called when user forget to call dispose method.
        /// </summary>
        ~IDisposableExample()
        {            
            Console.WriteLine("Destructor called..");
            Dispose(false);
        }
        /// <summary>
        /// User will call this method to dispose objects and remove objects from finalize queue.
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        /// <summary>
        /// this overloaded dispose method will be handle call from both with user dispose method call and desctructor call.
        /// </summary>
        /// <param name="isDisposing"></param>
        protected void Dispose(bool isDisposing)
        {
            if(!isDisposed)
            {
                if(isDisposing)
                {
                    Console.WriteLine("Relesing managed objects");
                    // release managed objects
                }
                Console.WriteLine("Relesing un-managed objects");
                // release unmanaged resources/objects
                isDisposed = true;
            }
        }
    }
}
