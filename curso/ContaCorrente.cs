using bytebank;

namespace bytebank
{
    public class ContaCorrente
    {

        private Cliente titular;
        public Cliente Titular { get { return titular; } set { titular = value; } }

        public int Numero_agencia { get => numero_agencia; set => numero_agencia = value; }
        public string Conta { get => conta; set => conta = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public string nome_agencia;
        private int numero_agencia;
        private string conta;

        private double saldo;


        public bool Sacar(double valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo = Saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            Saldo = Saldo + valor;
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (Saldo < valor)
            {
                return false;
            }
            if (valor < 0)
            {
                return false;
            }
            else
            {
                Saldo = Saldo - valor;
                destino.Saldo = destino.Saldo + valor;
                return true;
            }
        }

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }
        }

        public ContaCorrente(int agencia, string conta)
        {
            Numero_agencia = agencia;
            Conta = conta;
        }



    }
}


















