programa
{
	
	funcao inicio()
	{
//		//vetor de 11 numeros com 10 posições preenchidas, 
//		//pedirá ao usuario uma posição e um numero para 
//		//o mesmo ser inserido no meio dos outros.
//		
//		inteiro vetor[11]
//		inteiro numero = 0
//		inteiro posicao = 0
//		inteiro cont = 0
//		
//
//		para (inteiro i = 0/*começando em 0 */ ; i < 10; i++){
//		vetor[i] = sorteia(0, 100)
//		}
//		para (inteiro i = 0; i < 11; i++){
//			escreva(vetor[i] + " ")
//		}
//			escreva("\n Digite um numero para ser inserido: ")
//			leia(numero)
//			escreva("Digite o numero da posição em que será inserido: ")
//			leia(posicao)
//		
//
//		para (inteiro i = 10; i > posicao; i--){ //ira pegar o valor e substituir pulando uma casa
//			
//			vetor[i] = vetor[i - 1]
//
//		}
//		vetor[posicao] = numero
//		
//		para (inteiro i = 0; i < 11; i++){		
//		escreva(vetor[i] + " " )
//		}

		//tamanho do vetor sem os numeros duplicados  - ordenado 

		inteiro vetor[8] = {1,2,4,4,5,6,7,7}
		inteiro duplicado = 0
		inteiro ultimo = -1

		para (inteiro i = 0; i < 6; i++){
			se (vetor[i] != ultimo){
				duplicado++ // para incrementar de 1 em 1
				ultimo =  vetor[i]
			}
		}
			
		escreva(duplicado + " ")
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1207; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */