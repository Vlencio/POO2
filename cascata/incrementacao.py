class Produto:
    def __init__(self, nome: str, valor: float) -> None:
        self.nome = nome
        self.valor = valor

class Carrinho:
    def __init__(self) -> None:
        self.produtos = []
        self.total = 0
    
    def add_produto(self, produto: Produto) -> None:
        self.produtos.append(produto)
        self.total += produto.valor
    
    def calcular_total(self) -> None:
        print(sum([p.valor for p in self.produtos]))
    
class Pagamento:
    @staticmethod
    def pagar(carrinho: Carrinho):
        total = carrinho.total
        print(f'Total a pagar: R${total}')
        type_pay = input('Tipo de pagamento\n\nCartao\nPix\n\n')

        if type_pay.lower() == 'cartao':
            total += (total * 0.0489)
            print(f'Valor com juros da maquina: {round(total, 2)}')
        
        amount = float(input('Digite quanto quer pagar: '))

        if round(amount, 2) == round(total, 2):
            print('Total pago.')
        
        elif amount < total:
            print(f'Restante: {round(total - amount, 2)}')
        
        else:
            print(f'Valor maior do que o devido, insira um valor válido.')
            return

        carrinho.total -= amount

def teste1():
    prod1 = Produto("Produto 1", 150)
    prod2 = Produto("Produto 2", 70)

    carrinho = Carrinho()
    carrinho.add_produto(prod1)
    carrinho.add_produto(prod2)
    carrinho.calcular_total()

def teste2():
    prod1 = Produto("Produto 1", 150)
    prod2 = Produto("Produto 2", 70)

    carrinho = Carrinho()
    carrinho.add_produto(prod1)
    carrinho.add_produto(prod2)
    carrinho.calcular_total()

    Pagamento.pagar(carrinho=carrinho)


teste1()
teste2()