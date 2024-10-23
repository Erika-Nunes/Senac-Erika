programa
{
	
	funcao inicio()
	{
//		// Gerar 20 numeros aleatorios 
//		//Imprimir :
//		// a. os numero b.quantos são maiores que 5 c. quantos sao divisiveis por 3
//		
//		inteiro contador = 20 //utilizado para limitar a quantidade de vezes que vai ser sorteado
//		inteiro total = 0 
//		inteiro maior_cinco = 0 
//		inteiro divisivel_3 = 0 
//		inteiro aleatorio = 0 //declara a variavel aleatoria fora pois se declarar ela dentro do enquanto você não consegue usra ela fora
//
//		
//		enquanto (total < contador){ //posso utilizar (contador < 20)
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
	
	//Gerar 10 idades aleatorias 
	//Imprimir :
	// a. A média das idades
	// b. A maior idade
	
	//inteiro total = 0
//	inteiro contador = 0
//	real media_idade = 0.0
//	inteiro maior_idade = 0
//	inteiro idade = 0
//	inteiro soma = 0
//	
//			
//	enquanto  (contador < 10){
//		idade = sorteia(1, 100)
//		escreva (idade+ " ")
//		
//		
//	se (idade > maior_idade){
//		maior_idade = idade
//	}
//	soma += idade
//		
//	contador += 1
//	}
//	
//	media_idade = soma / 10.0 
//	
//	escreva("\nMédia idade: " +media_idade+ " | A maior idade é: " +maior_idade+ "\n")
	
	
	// Gerar 10 preços aleatorios ou pedindo ao usuario
	//Imprimir - a. Os preços  b. O maior preço c. O menor preço 
//	
//	inteiro contador = 0 
//	real preco = 0.0
//	real maior_preco = 0.0
//	real menor_preco = 0.0 //atribui um valor não existente como "-1" ou um valor logico
//	real soma = 0.0
//	logico primeiro_menor = verdadeiro 
//	
//	//escreva ("Digite o preço mais alto: ") //pode pedir para atribuir um valor limite para o menor_preco
//	//leia(menor_preco)
//	enquanto (contador < 10){
//		preco = sorteia(1, 500)
//		//preco = sorteia(1, 500)
//		escreva (preco+ " ")
//		
//		se (preco > maior_preco ){
//			maior_preco = preco
//		}
//		se (preco < menor_preco ou primeiro_menor){ //colocar um menor preço inexistente
//			menor_preco = preco
//			primeiro_menor = falso
//			
//		}
//		soma += preco
//		contador += 1
//	}
//	
//	escreva ("\n O maior preço: " +maior_preco+ " | O menor preco: " +menor_preco)
	
	//PEDIR UM NUMERO PARA O USUARIO 
		//IMPRIMIR SE O NÚMERO É PRIMO OU NÃO 
		//PARA SER PRIMO TEM QUE SER MAIOR QUE 1 E SOMENTE DIVISIVEL POR SI MESMO E POR 1


//		inteiro numero = 0
//		//inteiro primo = 0
//		//inteiro divisivel = 0
//
//
//		escreva("Digite um número : ")
//		leia(numero)
//		
//
//		se (numero == 2 ou numero == 5){
//			escreva("Número primo")
//		}
//		senao se (numero > 1 e numero % numero == 0 e numero % 1 == 0 e numero % 3 != 0 e numero % 2 != 0 e numero % 5 != 0){
//			escreva("Número primo")
//		}
//		senao {
//			escreva ("Esse número não é primo")
//		}
//		
		//MODO DO PROF
		inteiro numero = 0
		inteiro contador = 2
		logico primo = verdadeiro
		escreva("Digite um numero: ")
		leia(numero)
		
		se(numero <2){
			primo = falso
		}
		senao{
			enquanto (contador <=( numero/2) e primo){
				
			
				se(numero % contador == 0){
					primo = falso 
				}
				contador += 1
				
			}
		}
			
		se(primo){
			escreva("É primo")

		}
	 	senao{
	 		escreva("Não é primo")
	 	}
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 3490; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */