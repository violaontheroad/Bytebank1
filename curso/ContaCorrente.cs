namespace bytebank
{
    class ContaCorrente
    {
        private string conta;
        private int codigo_agencia;
        private string nome_agencia;
        private double saldo = 150;


        private Cliente Titular { get; set; }
        public static int TotalDeContasCriadas { get; private set; }
        public string Conta { get => conta; set => conta = value; }
        public int Codigo_agencia { get => codigo_agencia; set => codigo_agencia = value; }
        public string Nome_agencia { get => nome_agencia; set => nome_agencia = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        ////Construtor padrão.
        public ContaCorrente()
        {
            TotalDeContasCriadas = TotalDeContasCriadas + 1;
        }
        public ContaCorrente(string conta, int codigo_agencia, string nome_agencia, double saldo, Cliente titular)
        {
            this.Conta = conta;
            this.Codigo_agencia = codigo_agencia;
            this.Nome_agencia = nome_agencia;
            this.Saldo = this.Saldo+ saldo;
            this.Titular = titular;
            TotalDeContasCriadas = TotalDeContasCriadas + 1;
        }

        public ContaCorrente(int codigo_agencia, string conta)
        {
            Codigo_agencia = codigo_agencia;
            Conta = conta;
            TotalDeContasCriadas = TotalDeContasCriadas + 1;
        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Saldo < valor)
            {
                return false;
            }

            Saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }

        public void InformacaoConta()
        {
            Console.WriteLine("### INFORMAÇÕES BANCÁRIAS ###");
            Console.WriteLine("#############################");
            Console.WriteLine($"CONTA: {this.Conta}");
            Console.WriteLine($"COD AGÊNCIA: {this.Codigo_agencia}");
            Console.WriteLine($"NOME AGÊNCIA: {this.Nome_agencia}");
            Console.WriteLine($"SALDO: {this.Saldo}");
            Console.WriteLine($"TITULAR: {this.Titular.Nome}");
            Console.WriteLine($"CPF: {this.Titular.Cpf}");
            Console.WriteLine($"PROFISSÃO: {this.Titular.Profissao}");
        }
    }
}
