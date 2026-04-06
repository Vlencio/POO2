using Xunit;
using AulaTestes;

namespace AulaTestes.Tests
{
    public class CarrinhoTests
    {
        [Fact]
        public void Total_DeveRetornarSomaCorreta_QuandoAdicionarItens()
        {
            // Arrange
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Produto A", Preco = 50 });
            carrinho.Adicionar(new Item { Nome = "Produto B", Preco = 30 });
            // Act
            var total = carrinho.Total();
            // Assert
            Assert.Equal(80, total);
        }

        [Fact]
        public void Limpar_DeveZerarQuantidade_QuandoChamado()
        {
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "Produto", Preco = 15 });

            carrinho.Limpar();

            Assert.Equal(0, carrinho.Quantidade());
        }

        [Fact]
        public void Quantidade_DeveRetornarNumeroCorretoDeItens()
        {
            var carrinho = new Carrinho();
            carrinho.Adicionar(new Item { Nome = "A", Preco = 10 });
            carrinho.Adicionar(new Item { Nome = "B", Preco = 20 });

            Assert.Equal(2, carrinho.Quantidade());
        }
    }
}
