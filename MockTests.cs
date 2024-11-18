using Moq;
using Xunit;

public class MockTests
{
    public interface ICalculadora
    {
        int Somar(int a, int b);
    }

    [Fact]
    public void TesteMockCalculadora()
    {
        var mock = new Mock<ICalculadora>();
        mock.Setup(m => m.Somar(2, 3)).Returns(5);

        var resultado = mock.Object.Somar(2, 3);
        Assert.Equal(5, resultado);
    }
}
