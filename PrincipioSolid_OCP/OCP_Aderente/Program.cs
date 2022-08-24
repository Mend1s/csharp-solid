using System;

namespace OCP_Aderente
{
    class Program
    {
        static void Main(string[] args)
        {
            Pedido clienteAssociado = new DescontoClienteAssociado();
            Pedido clienteEspecial  = new DescontoClienteEspecial();
            Pedido clienteVIP = new DescontoClienteVIP();
            Pedido clienteComum = new Pedido();

            double clienteComumValorPedido =
                clienteComum.DescontoPedido(1000);

            double clienteAssociadoValorPedido = 
                clienteAssociado.DescontoPedido(1000);

            double clienteEspecialValorPedido = 
                clienteEspecial.DescontoPedido(1000);

            double clienteVIPValorPedido =
                clienteVIP.DescontoPedido(1000);


            Console.WriteLine($"Cliente Comum =" +
                $" {clienteComumValorPedido}");

            Console.WriteLine($"Cliente Associado =" +
                $" {clienteAssociadoValorPedido}");

            Console.WriteLine($"Cliente Especial =" +
                $" {clienteEspecialValorPedido}");

            Console.WriteLine($"Cliente VIP =" +
               $" {clienteVIPValorPedido}");

            Console.ReadLine();
        }
    }
}
