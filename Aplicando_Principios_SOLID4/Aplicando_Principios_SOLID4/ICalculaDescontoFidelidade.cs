using System;
using System.Collections.Generic;
using System.Text;

namespace Aplicando_Principios_SOLID4
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
    }
}
