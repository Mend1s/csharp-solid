using System;

namespace LSP_Aderente
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando classe base
            Console.WriteLine("LSP - Usando a classe Base : Conta");
            var conta = new ContaComum();
            conta.Saldo = 100;
            conta.Saque(250);
            Console.WriteLine($"A conta tem o saldo de: {conta.Saldo}");
            //Console.ReadLine();

            //trocando a classe base pela classe derivada
            Console.WriteLine("\n\nLSP - Usando a classe derivada : ContaPoupanca");
            var conta1 = new ContaPoupanca();
            conta1.Saldo = 100;
            conta1.Saque(250);
            Console.WriteLine($"A conta tem o saldo de: {conta1.Saldo}");
            Console.ReadLine();
        }
    }
}
