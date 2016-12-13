using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Class.Lib
{
    partial class PartialClass
    {
        public void SomeMethod()
        {
            PartialMethod();
        }

        partial void PartialMethod();       
    }
}
