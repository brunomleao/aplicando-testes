using TechTalk.SpecFlow;
using Xunit;

[Binding]
public class CalculadoraSteps
{
    private int _numero1;
    private int _numero2;
    private int _resultado;

    [Given(@"os números (.*) e (.*)")]
    public void DadoOsNumerosE(int numero1, int numero2)
    {
        _numero1 = numero1;
        _numero2 = numero2;
    }

    [When(@"eu somar os números")]
    public void QuandoEuSomarOsNumeros()
    {
        _resultado = _numero1 + _numero2;
    }

    [Then(@"o resultado será (.*)")]
    public void EntaoOResultadoSera(int resultadoEsperado)
    {
        Assert.Equal(resultadoEsperado, _resultado);
    }
}
