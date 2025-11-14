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
            Console.WriteLine("\tThis is a default/private methond. Accessing default variable 'car': "+ car);
            Console.WriteLine("\tThis is a default/private methond. Accessing public variable 'year': " + year);
            Console.WriteLine("\tThis is a default/private methond. Accessing internal variable 'month': " + month);
            Console.WriteLine("\tThis is a default/private methond. Accessing private variable 'day': " + day);
            Console.WriteLine("\tThis is a default/private methond. Accessing protected variable 'days': " + days);
        }
        private void PrivateMethod()
        {
            Console.WriteLine("\tThis is a private method.");
        }
        protected  void ProtectedMethod()
        {
            Console.WriteLine("\tThis is a protected method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("\tThis is an internal method.");
        }
        public virtual void PublicMethod()
        {
            Console.WriteLine("\tThis is a public method.");
        }
        public AccessModifiers()
        {
            Console.WriteLine("\tI am a super class constructor, who is called by a child class constructor that is called by another constructor.");
            
        }
        
    }
}
