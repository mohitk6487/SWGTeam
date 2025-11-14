

namespace Sukhi_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            AccessModifiers obj = new AccessModifiers();

            Console.WriteLine("\tAccessing public variable 'year': " + obj.year);
            Console.WriteLine("\tAccessing internal variable 'month': " + obj.month);
            obj.InternalMethod();
            ChildClass childObj = new ChildClass();
            childObj.Display();
            childObj.Display(42);
            childObj.PublicMethod();


        }
    }
}