namespace Aplicando_Principios_SOLID6
{
    public class ClienteVIP : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
        }
    }
}
