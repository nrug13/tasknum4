using System;

namespace tasknum4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 472998;
            a=Math.Abs(a);
            int reqem_sayi = 1;
           
            
                if (a<100000)
                {
                while ((a /= 10) >= 1 && a < 10000)
                    reqem_sayi++;
                    Console.WriteLine($"{reqem_sayi} reqemlidir");
                }

                else
                {
                    Console.WriteLine("nezere alinmir");
                }
            

            
        }
    }
}
