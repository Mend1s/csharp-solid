using System;

namespace CursoFoop_OCP_ExtensionMethods2
{
    public class Produto
    {
        public int ProdutoId { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        private decimal _custo = 0;
        public decimal Custo
        {
            get => _custo;

            private set
            {
                if (value > 0)
                    _custo = value;
            }
        }
        private decimal _venda = 1;
        public decimal Venda
        {
            get => _venda;

            private set
            {
                if (value > 0)
                    _venda = value;
            }
        }
        public int Estoque { get; private set; }
        public bool Ativo { get; private set; }

        public Produto(int id, string nome, string descricao,
            decimal custo, decimal venda, int estoque, bool ativo)
        {
            ProdutoId = id;
            Nome = nome;
            Descricao = descricao;
            Custo = custo;
            Venda = venda;
            Estoque = estoque;
            Ativo = ativo;
        }     
    }
}
