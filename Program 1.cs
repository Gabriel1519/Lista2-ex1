using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;

            Console.Write("insira o Primeiro algarismo: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("insira o Segundo algarismo Diferente ao segundo: ");
            n2 = int.Parse(Console.ReadLine());

            if (n1 > n2)
                Console.WriteLine("O Primeiro ({0}) é maior que o Segundo ({1})", n1, n2);
            else
                Console.WriteLine("O Segundo ({1}) é maior que o Primeiro ({0})", n1, n2);
        }
    }
}
