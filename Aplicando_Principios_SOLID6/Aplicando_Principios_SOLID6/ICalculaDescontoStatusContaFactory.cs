namespace Aplicando_Principios_SOLID6
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta
            GetCalculoDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
