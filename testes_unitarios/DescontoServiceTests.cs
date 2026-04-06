using Xunit;
using AulaTestes;
using System;

namespace AulaTestes.Tests
{
    public class DescontoServiceTests
    {
        // a) Testes individuais com [Fact]
        [Fact]
        public void AplicarDesconto_DeveRetornar90_QuandoValor100Percentual10()
        {
            var service = new DescontoService();
            Assert.Equal(90, service.AplicarDesconto(100, 10));
        }

        [Fact]
        public void AplicarDesconto_DeveRetornar100_QuandoValor200Percentual50()
        {
            var service = new DescontoService();
            Assert.Equal(100, service.AplicarDesconto(200, 50));
        }

        [Fact]
        public void AplicarDesconto_DeveRetornar80_QuandoValor80Percentual0()
        {
            var service = new DescontoService();
            Assert.Equal(80, service.AplicarDesconto(80, 0));
        }

        [Fact]
        public void AplicarDesconto_DeveLancarExcecao_QuandoValorNegativo()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(-10, 10));
        }

        [Fact]
        public void AplicarDesconto_DeveLancarExcecao_QuandoPercentualNegativo()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, -5));
        }

        [Fact]
        public void AplicarDesconto_DeveLancarExcecao_QuandoPercentualMaiorQue100()
        {
            var service = new DescontoService();
            Assert.Throws<ArgumentException>(() => service.AplicarDesconto(100, 101));
        }

        // b) Reescrita com [Theory] e [InlineData]
        [Theory]
        [InlineData(100, 10,  90)]
        [InlineData(200, 50, 100)]
        [InlineData(80,   0,  80)]
        public void AplicarDesconto_DeveRetornarValorCorreto_Theory(double valor, double percentual, double esperado)
        {
            // Arrange
            var service = new DescontoService();
            // Act
            var resultado = service.AplicarDesconto(valor, percentual);
            // Assert
            Assert.Equal(esperado, resultado);
        }
    }
}
