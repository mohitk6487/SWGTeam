using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sukhi_2
{
    public class ChildClass : AccessModifiers
    {
        public ChildClass()         //Constructor....this will be called when object of ChildClass is created and it will call SuperClass constructor automatically
        {
            Console.WriteLine("\tSuperClass's Protected methond called by child class constructor");
            ProtectedMethod();
        }
        public void Display()
        {
            Console.WriteLine("\tAccessing unparametrzed methond named 'Display'.");
        }
        public void Display(int a)    //Method Overloading
        {
            Console.WriteLine("\tAccessing parametrzed methond named 'Display' with value: " + a);
        }
        public override void PublicMethod()
        {
            Console.WriteLine("\tChildClass's method of the same name of SuperClass methond (Concept of Polymorphism's Overriding).");     //Method Overriding
        }
    }   
}
