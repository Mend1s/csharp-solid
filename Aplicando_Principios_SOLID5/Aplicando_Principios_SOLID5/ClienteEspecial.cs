namespace Aplicando_Principios_SOLID5
{
    public class ClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco));
        }
    }
}
