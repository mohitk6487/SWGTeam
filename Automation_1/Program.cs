

namespace Sukhi_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
     AccessModifiers obj = new AccessModifiers();

            Console.WriteLine("Accessing public variable 'year': " + obj.year);
            Console.WriteLine(" Accessing internal variable 'month': " + obj.month);
            obj.InternalMethod();
            
          
        }
    }
}