using ExercicioTDD.Exceptions;

namespace ExercicioTDD
{
    public class Conta
    {
        public Conta(string numeroConta, double saldo, double limite, bool operacional)
        {
            this.NumeroConta = numeroConta;
            this.Saldo = saldo;
            this.Limite = limite;
            this.Operacional = operacional;

        }
        public string NumeroConta { get; private set; }
        public double Saldo { get; private set; }
        public double Limite { get; private set; }
        public bool Operacional { get; private set; }

        public void Depositar(double valor)
        {

            VerificaContaEstadoOperacional();

            if (valor <= 0)
            {
                throw new ValorOperacaoZeradoOuNegativoException(this.NumeroConta);
            }

            this.Saldo += valor;
        }

        private void VerificaContaEstadoOperacional()
        {
            if (!Operacional) throw new ContaNaoOperacionalException(this.NumeroConta);

        }



    }



}