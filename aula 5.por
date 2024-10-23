programa
{
	
	funcao inicio()
	{
		// 0 3 6 9 12 15 Fim!

//		inteiro contador = 0
//
//		enquanto (contador <=15){
//			escreva(contador + " ")
//			contador = contador + 3
//		}
//		escreva ("Fim!")
		// Pedir um numero para o usuario e imprimir de 0 até o numero digitado

//		inteiro contador = 0
//		inteiro num = 0
//
//
//		escreva("digite um número: ")
//		leia(num)
//		
//		enquanto (contador <= num){
//			escreva(contador + " ") // o +" " é para dar espaço entre os números
//			contador = contador + 1
//		}
		// Pedir um numero para o usuario e imprimir de 0 até o numero digitado ,porém quando o numero 
	//fordivisivel por 4 será dermarcado por []
		
//		inteiro contador = 0
//		inteiro num = 0
//
//
//		escreva("digite um número: ")
//		leia(num)
//
//	
//		enquanto (contador <= num){
//			se (contador % 4 == 0){
//				escreva ("[" +contador+"]")
//			}
//			senao {
//				escreva (contador + " ")
//			}
//			
//				contador = contador + 1
//		}
		// Pedir um numero para o usuario e imprimir de 6 até  numero e somar ao fim
//		//teiro numero = 0
//		inteiro contador = 6
//		inteiro total = 0
//		
//	//screva( "digite um numero: ")
//	//eia(numero)
//
//		enquanto (contador <= 100){
//		total = total + contador
//			contador = contador + 2 
//		
//		}
//
//		escreva ("\ntotal é " +total)


		//utilizando o += para somar algo com si mesmo, isso também vale para os outros operadores

//		inteiro contador = 6
//		inteiro ope= 6
//
//		contador = contador / 2
//		ope += 2
//		ope -= 2
//		ope*= 2
//		ope /= 2
//
//
//		escreva("contador:" +contador+ "| operadores)"+ope)
    		//Pdir 7 numero para o usuario e imprimir a soma desses valores 
//		inteiro num1 = 0
//		inteiro num2 = 0
//		inteiro num3 = 0
//		inteiro num4 = 0
//		inteiro num5 = 0
//		inteiro num6 = 0
//		inteiro num7 = 0
//		inteiro soma = 0
//
//		escreva("escreva um numero: ")
//		leia(num1)
//
//		escreva("escreva um numero: ")
//		leia(num2)
//
//		escreva("escreva um numero: ")
//		leia(num3)
//
//		escreva("escreva um numero: ")
//		leia(num4)
//
//		escreva("escreva um numero: ")
//		leia(num5)
//
//		escreva("escreva um numero: ")
//		leia(num6)
//
//		escreva("escreva um numero: ")
//		leia(num7)
//
//		soma =num1+num2+num3+num4+num5+num6+num7
//
//		escreva(soma)
//
//		inteiro num = 0
//		inteiro soma = 0 
//		inteiro contador = 0
//
//		
//		
//		enquanto(contador <= 7){
//			
//			escreva(" digite um numero(" + contador + "/7):")
//			leia (num )
//			soma += num
//			contador += 1
//		}
//
//   		escreva (" o total é " +soma)

		//Pedir 5 numeros para o usuario e imprimir quantos são pares e quantos são impares
		// 3 impares e 2 pares 


//		inteiro num = 0 
//		inteiro contador = 0
//		inteiro impar = 0
//		inteiro  par = 0 
//		
//
//		enquanto (contador < 5) {
//			escreva (" digite um numero : ")
//			leia(num)
//			se( num % 2 == 0){
//		 	par +=1
//			}
//			senao {
//				impar += 1
//			}
//			contador += 1
//			}
//			
//			
//			escreva (" Pares: " +par+ " | Impares: " +impar)	


		// Gerando numeros aleatorio usando o sorteia( , )

//			inteiro aleatorio = sorteia(9, 20)
//			escreva (aleatorio)

		// Gerar 20 numeros aleatorios 
		//Imprimir :
		// a. os numero b.quantos são maiores que 5 c. quantos sao divisiveis por 3
//		inteiro contador = 20 //utilizado para limitar a quantidade de vezes que vai ser sorteado
//		inteiro total = 0 
//		inteiro maior_cinco = 0 
//		inteiro divisivel_3 = 0 
//		inteiro aleatorio = 0 //declara a variavel aleatoria fora pois se declarar ela dentro do enquanto você não consegue usra ela fora
//
//		
//		enquanto (total < contador){
//			aleatorio = sorteia(0, 10)//20 numeros aleatorios entre 0 e 10
//			escreva(" O número sorteado é: "+aleatorio+"\n")
//			total += 1 //toda vez que for puxado vai acrescentar 1 no total de vezes sorteadas 
//			
//			se (aleatorio > 5){
//				maior_cinco += 1
//			}
//			se (aleatorio % 3 == 0 ){ //utiliza um outro se pq o senao se não receberia numeros como 9 como divisivel
//				divisivel_3 += 1
//			}
//			
//	
//		}	
//		escreva("Maiores que 5: " +maior_cinco+ " | Divisiveis por 3: " +divisivel_3+ "\n")

		// Gerar um numero aleatorio de 0 a 100 - o usuario deve chutar até acertar o numero aleatorio
	
		//inteiro acertou = falso
//		inteiro chute_user = -1
//		inteiro aleatorio = sorteia(0, 100)
//		escreva (aleatorio+"\n")
//		
//		escreva("Digite um numero entre 0 e 100 : ") // Posso fazer dentro do enquanto 
//		leia(chute_user)
//		
//		
//	
//
//		enquanto (chute_user != aleatorio){
//			escreva("Digite outro numero entre 0 e 100 : ")
//			leia(chute_user)
//		se (chute_user == aleatorio){
//				escreva("Great, você acertou!")
//
////		senao {
////			escreva("Tente outr vez \n")
//		//}
//			}
//		}

		// Pedir o nome dos usuarios até o usuario digitar x
		//Imprimir uma mensagem de boas vindas 
		//Erika  - Boa noite Erika


//		cadeia nome_user = " "
//		cadeia nome_v = "Erika"
//		logico acertou = verdadeiro
//
//		enquanto (acertou){
//			escreva("Digite o nome do usuario: ") 
//			leia(nome_user)
//			se(nome_user == nome_v){
//				acertou = falso
//				
//				escreva("Seja bem-vindo(a) " +nome_user)
//			}
//	
//			senao{
//				escreva("Usuário Invalido \n")
//			}
//				//segundo metodo
//			enquanto (nome_user != nome_v ){
//			escreva("\n Digite o nome do usuario: ")
//			leia(nome_user)
//			se (nome_user == nome_v){
//			escreva("Seja bem-vindo(a) " +nome_user)
//			}
//			senao{
//				escreva ("Usuario invalido")
			
//			}

		
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 5506; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */