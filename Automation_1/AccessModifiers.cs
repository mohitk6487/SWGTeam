using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_2
{
     public class AccessModifiers
    {
        string car = "Audi";
        public int year = 2025;
        internal int month = 10;
        private int day = 7;
        protected int days = 365;
        void DefautltMethod()
        {
            Console.WriteLine("This is a default/private methond. Accessing default variable 'car': "+ car);
            Console.WriteLine("This is a default/private methond. Accessing public variable 'year': " + year);
            Console.WriteLine("This is a default/private methond. Accessing internal variable 'month': " + month);
            Console.WriteLine("This is a default/private methond. Accessing private variable 'day': " + day);
            Console.WriteLine("This is a default/private methond. Accessing protected variable 'days': " + days);
        }
        private void PrivateMethod()
        {
            Console.WriteLine("This is a private method.");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("This is a protected method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("This is an internal method.");
        }
        public void PublicMethod()
        {
            Console.WriteLine("This is a public method.");
        }
    }
}
