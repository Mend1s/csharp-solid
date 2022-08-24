using System;

namespace CursoFoop_LSP_Violacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando a classe base
            Console.WriteLine("LSP - Usando a classe base");
            var conta = new Conta();
            conta.Saldo = 100;
            conta.Saque(250);
            Console.WriteLine($"Saldo da conta : {conta.Saldo}");

            Console.WriteLine("\n\nLSP - Usando a classe derivada");
            var conta1 = new ContaPoupanca();
            conta1.Saldo = 100;
            conta1.Saque(250);
            Console.WriteLine($"Saldo da conta : {conta1.Saldo}");
            Console.ReadLine();
        }
    }
}
