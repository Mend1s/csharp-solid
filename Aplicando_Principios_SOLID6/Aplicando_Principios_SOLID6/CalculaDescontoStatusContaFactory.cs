using System;

namespace Aplicando_Principios_SOLID6
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta
            GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calcular;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calcular = new ClienteNaoRegistrado();
                    break;
                case StatusContaCliente.ClienteComum:
                    calcular = new ClienteComum();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calcular = new ClienteEspecial();
                    break;
                case StatusContaCliente.ClienteVIP:
                    calcular = new ClienteVIP();
                    break;
                default:
                    throw new NotImplementedException();
            }
            return calcular;
        }
    }
}
