using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira o primeiro valor : ");
            string valor1 = Console.ReadLine(); 
            Console.WriteLine();

            Console.WriteLine("insira o segundo valor: ");
            string valor2 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("insira um Operador: (+ - * / ): ");
            string operador = Console.ReadLine();
            Console.WriteLine();

            decimal Resultado = 0;
            if (operador == "+")   
            Resultado = Convert.ToInt16(valor1)  + Convert.ToInt16(valor2);
            if (operador == "-")
                Resultado = Convert.ToInt16(valor1) - Convert.ToInt16(valor2);
            if (operador == "*")
                Resultado = Convert.ToInt16(valor1) * Convert.ToInt16(valor2);
            if (operador == "/")
                Resultado = Convert.ToInt16(valor1) / Convert.ToInt16(valor2);

            Console.WriteLine("O resultado é: " + Resultado);






            Console.ReadKey();

        }
    }
}
