#Função para a construção do Array da sequência de finobacci
def fibonacci(n):
    sequencia = [0, 1]
    while len(sequencia)<n:
        next_number = sequencia[-1] + sequencia[-2]
        sequencia.append(next_number)
    return sequencia #retornando o array sequencia!

#definindo o comprimento da sequência (200)
n= 500
resultado = fibonacci(n)

#verificando se o número informado pertence ou não a sequência!
valor = int(input("Informe o valor para verificarmos se está presente na Sequência de Finobacci: "))
if valor in resultado:
    print("O número pertence à sequência")
else:
    print("o número não pertence à sequência")

