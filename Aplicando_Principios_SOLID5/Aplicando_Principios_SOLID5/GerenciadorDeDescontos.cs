using System;

namespace Aplicando_Principios_SOLID5
{
    public class GerenciadorDeDescontos
    {
        ICalculaDescontoFidelidade descontoFidelidade;
        public GerenciadorDeDescontos(ICalculaDescontoFidelidade _descontoFidelidade)
        {
            descontoFidelidade = _descontoFidelidade;
        }
        public decimal AplicarDesconto(decimal preco, StatusContaCliente statusContaCliente,
           int tempoDeContaEmAnos)
        {
            decimal precoDepoisDoDesconto = 0;
            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoDepoisDoDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(preco);
                    break;
                case StatusContaCliente.ClienteComum:
                    precoDepoisDoDesconto = new ClienteComum().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoDepoisDoDesconto = new ClienteEspecial().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteVIP:
                    precoDepoisDoDesconto = new ClienteVIP().AplicarDescontoStatusConta(preco);
                    precoDepoisDoDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoDepoisDoDesconto, tempoDeContaEmAnos); break;
                default:
                    throw new NotImplementedException();
            }
            return precoDepoisDoDesconto;
        }
    }
}
