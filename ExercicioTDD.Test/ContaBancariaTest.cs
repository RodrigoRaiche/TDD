using ExercicioTDD;
using ExercicioTDD.Exceptions;

namespace ExercicioTDD.Test;

public class ContaBancariaTest
{

    private const string NumeroContaBase = "1234";
    private const double SaldoBase = 5000;
    private const double LimiteSaque = 500;
    private Conta CriarContaBancariaOperacional(bool Operacional)
    {


        return new Conta(
         NumeroContaBase,
         SaldoBase,
         LimiteSaque,
         Operacional
        );
    }

    [Fact]
    public void Deveria_Cadastrar_Conta()
    {
        //Preparacao

        //Execução
        var conta = CriarContaBancariaOperacional(true);

        //validaria o objeto criado
        Assert.NotNull(conta);
        Assert.Equal(conta.NumeroConta, NumeroContaBase);
    }

    [Fact]
    public void Deveria_Efetuar_Deposito()
    {
        var saldoInicial = SaldoBase;
        var valorDeposito = 500;
        var valorEsperado = 5500;

        var conta = CriarContaBancariaOperacional(true);

        conta.Depositar(valorDeposito);

        Assert.Equal(conta.Saldo, valorEsperado);


    }

    [Fact]
    public void Nao_Deveria_Efetuar_Deposito_Em_Conta_Nao_Operacional()
    {
        Assert.Throws<ContaNaoOperacionalException>(() =>
        {
            var saldoInicial = SaldoBase;
            var valorDeposito = 500;
            var valorEsperado = 5500;

            var conta = CriarContaBancariaOperacional(false);

            conta.Depositar(valorDeposito);

        });


    }



}



