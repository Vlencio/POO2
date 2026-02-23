class Produto:
    def __init__(self, nome, valor) -> None:
        self.nome = nome
        self.valor = valor

class Carrinho:
    def __init__(self) -> None:
        self.produtos = []
    
    def add_produto(self, produto) -> None:
        self.produtos.append(produto)
    
    def calcular_total(self) -> None:
        print(sum([p.valor for p in self.produtos]))

def teste1():
    prod1 = Produto("Produto 1", 150)
    prod2 = Produto("Produto 2", 70)

    carrinho = Carrinho()
    carrinho.add_produto(prod1)
    carrinho.add_produto(prod2)
    carrinho.calcular_total()


teste1()