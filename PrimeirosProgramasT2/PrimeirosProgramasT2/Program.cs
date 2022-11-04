using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeirosProgramasT2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Olá! Como te chamas?");
            //criar variável Nome
            /* 
             *um comentário 
             *de várias linhas
             */

            String Nome = Console.ReadLine();
            Console.WriteLine("Bem vindo {0}. ",Nome);
            Console.ReadLine(); //prender ecrã
        }
    }
}
