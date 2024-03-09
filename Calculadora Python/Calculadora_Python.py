print("Calculadora em Python\n");


n1=float(input("Digite o primeiro valor: "))
n2=float(input("Digite o segundo valor: "))
print("\n")


operacao=int(input("Qual operacao deseja fazer? \n 1 - Adicao \n 2 - Subtracao \n 3 - Multiplicacao \n 4 - Divisao \n"))

if operacao==1:
        total = n1+n2
        print("Restultado: ", n1, "+", n2, "=", total)

elif operacao ==2:
        total = n1-n2
        print("Restultado: ", n1, "-", n2, "=", total)
        
elif operacao==3:
      total = n1*n2
      print("Restultado: ", n1, "x", n2, "=", total)
      
elif operacao==4:
        if n2==0:
            print("Impossivel dividir um numero por 0")
        
        else:
            total = n1/n2
            print("Restultado: ", n1, "/", n2, "=", total)
else:
        print("Voce nao digitou uma operacao valida")





        
