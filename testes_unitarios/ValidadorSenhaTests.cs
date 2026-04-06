using Xunit;
using AulaTestes;

namespace AulaTestes.Tests
{
    public class ValidadorSenhaTests
    {
        [Fact]
        public void EhValida_DeveRetornarTrue_QuandoSenhaContemLetrasENumeros()
        {
            // Arrange
            var validador = new ValidadorSenha();
            // Act
            var resultado = validador.EhValida("Senha123");
            // Assert
            Assert.True(resultado);
        }

        [Fact]
        public void EhValida_DeveRetornarFalse_QuandoSenhaSoTemNumeros()
        {
            var validador = new ValidadorSenha();
            Assert.False(validador.EhValida("12345678"));
        }

        [Fact]
        public void EhValida_DeveRetornarFalse_QuandoSenhaEhVazia()
        {
            var validador = new ValidadorSenha();
            Assert.False(validador.EhValida(""));
        }

        [Fact]
        public void EhValida_DeveRetornarFalse_QuandoSenhaSoTemLetras()
        {
            var validador = new ValidadorSenha();
            Assert.False(validador.EhValida("abcdEFGH"));
        }
    }
}
