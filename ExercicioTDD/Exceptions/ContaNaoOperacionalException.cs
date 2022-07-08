namespace ExercicioTDD.Exceptions
{

    public class ContaNaoOperacionalException : BaseContaException
    {
        public ContaNaoOperacionalException(string numeroConta) : base("Conta não operacional", numeroConta)
        {
        }

    }
}