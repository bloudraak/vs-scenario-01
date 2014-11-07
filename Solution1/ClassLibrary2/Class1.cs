using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class Class2
    {
        public void DoX()
        {
            Class1 class1 = new Class1();
            class1.DoX();
        }
    }
}
