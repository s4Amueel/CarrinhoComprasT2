using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosProgramasT2
{
    internal class Programa2
    {
        static void Main(string[] args)
        {
            int num1, num2, soma;
            Console.WriteLine("Digite um numero: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            soma = num1 + num2;
            Console.WriteLine("A soma de {0} com {1} é = {2}", num1, num2, soma);


            Console.ReadKey();



        }

    }
}
