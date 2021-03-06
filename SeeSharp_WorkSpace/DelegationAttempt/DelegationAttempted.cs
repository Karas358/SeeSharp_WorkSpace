using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.DelegationAttempt
{
    class DelegationAttempt
    {
        public delegate void delegateAttempting();

        public delegateAttempting myDelegate;

        public void Start()
        {
            myDelegate += myTestDelegateAttempt;
            myDelegate += myOtherTestDelegateAttempt;
            myDelegate();

        }
        private void myTestDelegateAttempt()
        {
            Console.WriteLine("First Attempt");
        }

        private void myOtherTestDelegateAttempt()
        {
            Console.WriteLine("Seond Attempt");
        }

    }
}
