namespace CursoFoop_LSP_Violacao
{
    class Conta
    {
        public double Saldo { get; set; }
        public virtual void Saque(double valor)
        {
            Saldo -= valor;
        }
    }
}
