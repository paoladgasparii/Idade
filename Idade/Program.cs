using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade expressa em anos: ");
            int anos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade em meses: ");
            int meses = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite sua idade em dias: ");
            int dias = int.Parse(Console.ReadLine());

            int resultado = anos * 365 + meses * 30 + dias;

            Console.WriteLine("Sua idade expressa em dias é: " + resultado);

            Console.ReadKey();  
        }
    }
}
