using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 37. Să se calculeze şi să se tipărească primii n termeni din şirul Fibonacci, şir definit de relaţia de 
recurenta: f(n)=f(n-2)+f(n-1); f(1)=1, f(2)=1.
*/
namespace FundamenteleProgramarii37
{
    class Program
    {
        static int fibonacci(int n)//functia recurenta care returneaza f(n)=f(n-1)+f(n-2) unde f(1)=f(2)=1;
        {
            if (n-1 <= 1)
                return 1;
            return fibonacci(n - 1) + fibonacci(n - 2);
        }
        static void Main(string[] args)
        {
            //input N
            int n;
            Console.WriteLine("Nr este: ");
            n = int.Parse(Console.ReadLine());

            Console.Write("\nSirul lui fibonacci de n numere este:");

            //parcurgem pe rand fiecare element din sirul fibonacci si il afisam pana cand ajungem la n-lea element din sir
            for (int i = 1; i <= n; i++)
                Console.Write(" {0} ", fibonacci(i));//folosim metoda fibonacci(n) pentru a calcula al i-lea termen din sir
            Console.ReadLine(); //comanda pentru a nu inchide consola prea repede
        }
    }
}
