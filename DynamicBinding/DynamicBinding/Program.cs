
namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 5;          // integer variable
            dynamic d = i;      // Dynamic variable will have runtime type of integer
            long l = d;         // Integer can be put in a long without explicit casting
        }
    }
}
