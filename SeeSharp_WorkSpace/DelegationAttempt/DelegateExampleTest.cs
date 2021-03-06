using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeeSharp_WorkSpace.DelegationAttempt
{
    class DelegateExampleTest
    {
        public delegate void Callback(int z);
        public void myMethodAction(Callback obj)
        {
            for(int x =0; x < 1000; x++)
            {
                obj(x);
            }
        }
    }

    
}
