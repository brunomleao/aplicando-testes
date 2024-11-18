using Xunit;

public class ConversaoTemperaturaTests
{
    [Theory]
    [InlineData(32, 0)]
    [InlineData(212, 100)]
    public void TesteConversaoFahrenheitParaCelsius(double fahrenheit, double celsiusEsperado)
    {
        var resultado = (fahrenheit - 32) * 5 / 9;
        Assert.Equal(celsiusEsperado, resultado);
    }
}
