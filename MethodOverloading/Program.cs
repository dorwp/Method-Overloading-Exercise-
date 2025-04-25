namespace MethodOverloading
{
    public class Program
    {
        public static int Add(int a, int b)
        {
                return a + b;
        }

        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool c)
        {
            if (c == false)
            {
                return (a + b).ToString();
            }

            if (a + b > 1)
            {
                return (a + b).ToString() + " dollars";
            }

            else 
            {
                return (a + b).ToString() + " dollar";
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1.5, 2.2));
            Console.WriteLine(Add(1, 2, true));
            Console.WriteLine(Add(1, 0, true));
            Console.WriteLine(Add(1, 3, false));
        }
    }
}
