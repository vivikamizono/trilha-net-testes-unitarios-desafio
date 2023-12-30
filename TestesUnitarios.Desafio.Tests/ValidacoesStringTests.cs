using TestesUnitarios.Desafio.Console.Services;

namespace TestesUnitarios.Desafio.Tests;

public class ValidacoesStringTests
{
    private ValidacoesString _validacoes = new ValidacoesString();

    [Fact]
    public void DeveRetornarAQuantidadeCaracteresDoNomeVitoria()
    {
        // Arrange
        var texto = "Vitoria";
        var resultadoEsperado = 7;

        // Act
        var resultado = _validacoes.RetornarQuantidadeCaracteres(texto);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
    }

    [Fact]
    public void DeveConterAPalavraQualquerNoTexto()
    {
        // Arrange
        var texto = "Uma palavra qualquer em um texto qualquer";
        var textoProcurado = "qualquer";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void NaoDeveConterAPalavraTesteNoTexto()
    {
        // Arrange
        var texto = "Um texto qualquer que não tenha uma palavra teste nela";
        var textoProcurado = "teste";

        // Act
        var resultado = _validacoes.ContemCaractere(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TextoDeveTerminarComAPalavraProcurado()
    {
        // Arrange
        var texto = "começo de um texto qualquer e que não podemos terminar com procurado";
        var textoProcurado = "procurado";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.True(resultado);
    }

    [Fact]
    public void TextoNaoDeveTerminarComAPalavraProcurada()
    {
        // Arrange
        var texto = "Um texto aleatório pois a palavra não é procurada";
        var textoProcurado = "procurada";

        // Act
        var resultado = _validacoes.TextoTerminaCom(texto, textoProcurado);

        // Assert
        Assert.False(resultado);
    }
}
