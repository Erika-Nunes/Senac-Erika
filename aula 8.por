programa
{
	
	funcao inicio()
	{
//		inteiro numero[5] = {1, 1, 1, 1, 1}
//		inteiro num = 0
//
//		numero[1] = 10
//
//		para (inteiro i = 0; i < 5; i++){
//			escreva(numero[i] + "  ")
//		}

		//Preencha um vetor de 10 elementos com o numero 99
		//inicializar o vetor padrão 
		//IMPRIMIR VETOR
//		inteiro numeros[11]
//		
//		
//
//		para (inteiro i = 0;i < 10; i++){
//			numeros [i] = 999
//			escreva(numeros[i] + " ")
//			
//		}

		//
		//Preencha um vetor de 10 elementos com os numeros 5 10 15 20 25 30 35 40 45 50
		//inicializar o vetor padrão 
		//IMPRIMIR VETOR

//		inteiro numeros[11]
//		inteiro num = 5
		
		
//		para (inteiro i = 0;i < 10; i++){
//			numeros [i] = num
//			escreva(numeros[i] + " ")
//			num += 5
//		}
		//resp prof

//		para (inteiro i = 0;i < 10; i++){
//			numeros [i] = i * 5 + 5
//
//			escreva(numeros[i] + " ")
//		}

		//Preencha um vetor de 10 elementos com os numeros 9 ate 0
		//IMPRIMIR VETOR
//		inteiro numeros[11]
//		
//		para (inteiro i = 10;i > 0; i--){
//			numeros [i] = i - 1
//
//			escreva(numeros[i] + " ")
//		}
//
//		//resp prof
//
////		para (inteiro i = 0;i < 10; i++){
////			numeros [i] = 9 - i
////
////			escreva(numeros[i] + " ")
////		}

		// 10 elementos - 5 3 5 3 5 3 5 3 5 3
		
//		inteiro numeros[10]
//		
//		para (inteiro i = 0;i < 5; i++){
//			numeros [i] = 5
//			escreva(numeros[i] + " ")
//			para (inteiro j = 0;j < 1; j++){
//				numeros [j] = 3
//				escreva(numeros[j]+ " ")	
//			}
//		
//			
//		}
//
//		//resp prof
//		para (inteiro i = 0;i < 10; i++){
//			se(i % 2 == 0){
//				numeros[i] = 5
//			}
//			senao{
//				numeros[i] = 3
//			}
//		
//		}
//		para (inteiro i = 0;i < 10; i++){
//			escreva(numeros[i] + " ")
//		}


		// um vetor de 10 elementos com numeros aleatorios entre 0 e 100
//		inteiro numeros[10]
//		
//		para (inteiro i = 0;i < 10; i++){
//			//inteiro aleatorio = sorteia(0,100)
//			//numeros [i] = aleatorio
//			//ou
//			numeros [i] = sorteia(0, 100)
//			
//		}
//		para (inteiro i = 0;i < 10; i++){
//			escreva(numeros[i] + " ")
//		}

		//Pedir 7 nomes para o usuario
		//Imprimir os nomes na ordem inversa - a b c , c b a
		
//		cadeia nome[7]
//
//		cadeia nom1 =  " "
////		
//		
//		para (inteiro i = 0; i < 7; i++){
//			escreva("digite um nome: " +(i+1) + "/7: ")
//			leia(nom1)
//			nome[i] = nom1
//			
//			
//		}	
//		para (inteiro i = 6; i >= 0; i--){
//			escreva(nome[i] + " | ")
//		}
		
		//Pedir/gerar (0,100) ou 7 números
		//imprimir as posições(indices) dos números múltiplos de 10

//		inteiro numeros[7] 
//		
//	
//		para (inteiro i = 0; i < 7; i++){ // A POSIÇÃO NADA MAIS É QUE "i"
//			inteiro aleatorio = sorteia(0,100)	
//			numeros [i] = aleatorio
//			escreva(numeros[i] + "/7: ")
//		}	
//		para (inteiro i = 0;i < 7; i++){
//			se (numeros[i] % 10 == 0){
//				escreva("\n multiplo " +i)
//				
//			}
//			
//			
//		}
		//Gerar um vetor de 30 posições com números entre 1 e 15. Peça um número para o usuario
		//Imprimir o vetor
		//Impimir em quais posições e quantas vezes o numero foi sorteado 	
//		inteiro numeros[30]
//		inteiro num = 0
//		//inteiro arm = 0
//		
//		para (inteiro i = 0; i < 30; i++){
//			inteiro aleatorio = sorteia(1, 15)	
//			numeros[i] = aleatorio	
//		}	
//		escreva("Digite um numero entre 1  e 15 : ")
//		leia(num)
//		
//		para (inteiro i = 0;i < 30; i++){
//			escreva(numeros[i] + " ")
//		}
//		
//			
//		para (inteiro i = 0;i < 30; i++){
//			se (num == numeros[i] ){
//				escreva("\n as posições são: " +i)
//			num++
//				
//			}
//				
//		}	
//		escreva("\n a quantidade de vezes que aparece: " +num)					
	
		//Pedir/ gerar 10 notas
	
		//imprimir 
		//a. a média da turma 
		//quantos alunos estão acima da média
		//c. a maior nota
		//d. a menor nota 
		inteiro notas[10]
		inteiro media = 0
		inteiro contador = 0
		inteiro maior_nota = 0
		inteiro menor_nota = 0


		para (inteiro i = 0; i < 10; i++ ){
			notas[i] = sorteia(0, 10)
	
		}
		para (inteiro i = 0;i < 10; i++){
			escreva(notas[i] + " ")
		}
		
		para (inteiro i = 0; i < 10; i++){
			media = (notas[i] + notas[i])/10 
			escreva("\na media é:" +media)
			
		//}
		//para (inteiro i = 0; i< 10; i++){

			se(notas[i] > media){
				escreva("os alunos acima da media são: " + contador )}
		contador ++
		}	
			
		para (inteiro i = 0; i< 10; i++){
				se (notas[i] > notas[i]){
				 	maior_nota = notas[i] 
					escreva("a maior nota é: " +maior_nota)
				}
				senao se (notas[i] < notas[i]){
					menor_nota = notas[i]
					escreva("a menor nota é: " +menor_nota)
				}
		}
	
	}
}	
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 4322; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */