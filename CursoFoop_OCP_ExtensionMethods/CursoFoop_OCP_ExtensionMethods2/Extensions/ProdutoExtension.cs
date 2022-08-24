using System;

namespace CursoFoop_OCP_ExtensionMethods2.Extensions
{
    public static class ProdutoExtension
    {
        public static double MargemLucro(this Produto produto)
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                var margemLucro = (lucroLiquido / produto.Venda) * 100;
                return Convert.ToDouble(margemLucro);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Erro ao calcular a margem de lucro");
            }
        }
    }
}
