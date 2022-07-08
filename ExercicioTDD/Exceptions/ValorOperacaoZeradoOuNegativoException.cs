namespace ExercicioTDD.Exceptions
{

    public class ValorOperacaoZeradoOuNegativoException : BaseContaException
    {
        public ValorOperacaoZeradoOuNegativoException(string numeroConta) : base("Valor da operação zerada ou negativa", numeroConta)
        {
        }

    }
}