namespace LSP_Aderente
{
    class ContaPoupanca : Conta
    {
        public override double Saldo { get; set; }
        public void Saque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
        }
    }
}
