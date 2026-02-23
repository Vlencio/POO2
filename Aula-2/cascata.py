class _Produto:
    def __init__(self, nome: str, valor: int) -> None:
        self.nome = nome
        self.valor = valor

class Cliente:
    def __init__(self, nome) -> None:
        self.pedido = _Pedido()
        self.nome = nome
    
    def add_prod(self, pedido):
        self.pedido.add_produto(pedido)
    
    def return_value(self):
        return self.pedido.calcular_pedidos()

    def resumo(self):
        print(f'Cliente: {self.nome}\n')
        self.pedido.print_pedido()
        total = self.return_value()
        print(f'Total: R${total}')

class _Pedido:
    def __init__(self) -> None:
        self.produtos = []
    
    def add_produto(self, produto):
        self.produtos.append(produto)

    def calcular_pedidos(self):
        return sum([p.valor for p in self.produtos])
    
    def print_pedido(self):
        for produto in self.produtos:
            print(f'Nome: {produto.nome} | Valor: R${produto.valor}')

nome = input("Digite seu nome: ")
cliente = Cliente(nome=nome)

while True:
    imp_prod = input("Digite o nome do produo ('s' para sair): ")
    if imp_prod == 's':
        break
    
    imp_valor = int(input("Digite o valor do produto: "))

    produto = _Produto(nome=imp_prod, valor=imp_valor)
    cliente.add_prod(produto)

cliente.resumo()