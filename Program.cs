using System;

namespace Adding
{
    internal class Program
    {






        public static int Add(int N1, int N2)
        {
            int result = N1+N2;
            Console.WriteLine($"Ressult= {result}");
            return result;
        }








    static void Main(string[] args)
        {
            Console.WriteLine("Enter 2 integer");
            string C1=Console.ReadLine();
            string C2=Console.ReadLine();
            int N1 = int.Parse(C1);
            int N2 = int.Parse(C2);

            int Result=Add(N1,N2);

        }
    }
}
