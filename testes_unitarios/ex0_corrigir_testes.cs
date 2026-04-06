// Exercicio 0 - Identificar e corrigir erros nos testes
//
// Questao A - ERRO: Assert.Equal(4, resultado) esta errado.
//   Somar(2, 3) = 5, mas o teste esperava 4.
//   CORRECAO: trocar 4 por 5.
//
// [Fact]
// public void Somar_DeveRetornar5()
// {
//     var calc = new Calculadora();
//     var resultado = calc.Somar(2, 3);
//     Assert.Equal(5, resultado); // CORRIGIDO: era 4
// }
//
// ---
//
// Questao B - ERRO: calc.Dividir(10, 2) NAO lanca DivideByZeroException.
//   Para provocar divisao por zero o divisor deve ser 0.
//   CORRECAO: trocar o segundo argumento de 2 para 0.
//
// [Fact]
// public void Dividir_DeveLancarExcecao()
// {
//     var calc = new Calculadora();
//     Assert.Throws<DivideByZeroException>(() => calc.Dividir(10, 0)); // CORRIGIDO: era 2
// }
//
// ---
//
// Questao C - ERROS:
//   1. O carrinho tem um item adicionado, mas Assert.Empty verifica
//      uma nova lista anonima — nao o carrinho em si.
//   2. Para testar "carrinho vazio apos Limpar()", deve-se chamar
//      carrinho.Limpar() e depois verificar com Assert.Equal(0, carrinho.Quantidade()).
//
// [Fact]
// public void Carrinho_DeveEstarVazioAposLimpar()
// {
//     var carrinho = new Carrinho();
//     carrinho.Adicionar(new Item { Nome = "Produto", Preco = 15 });
//     carrinho.Limpar();                          // ADICIONADO
//     Assert.Equal(0, carrinho.Quantidade());     // CORRIGIDO: verificar o carrinho real
// }
//
// ---
//
// Questao D - ERRO: IMC 31 esta na faixa "Obesidade" (>= 30), nao "Peso normal".
//   CORRECAO: usar um valor de IMC entre 18.5 e 24.9 para "Peso normal",
//             ou corrigir o valor esperado para "Obesidade".
//
// [Fact]
// public void Classificar_DeveRetornarObesidade_QuandoIMC31()  // nome atualizado
// {
//     var calc = new CalculadoraIMC();
//     var resultado = calc.Classificar(31);
//     Assert.Equal("Obesidade", resultado); // CORRIGIDO: era "Peso normal"
// }
