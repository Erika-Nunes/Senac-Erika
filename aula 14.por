programa
{
	
	funcao inicio()
	{

	//Criar uma função que recebe um vetor e retorna o tamanho do mesmo
	//quantidade de numero diferente de zero
		
		inteiro vetor[10] = {1, 2, 3, 4, 5, 0, 0 , 0, 0, 0 }
		//inteiro tamanho = tamanhoVetor(vetor)

		se(inserir(vetor,99,1)){
			escreva("Adicionado com sucesso")
		}
		senao{
			escreva("Erro ao add")
		}
		//escreva(tamanho)

		
	//Criar uma função que recebe um vetor, um valor e um indice e adiciona o valor. 
	//retorna verdadeiro caso consiga e falso caso não (lugar vazio ou se já existe , se o vetor tiver cheio não pode adicionar , se for 0 o elemento pode adicionar)
	//[1 2 3 4 0] 5 0
	//inserir é em uma posição e adicionar pode ser no final ou no inicio
	
	
	}		
	funcao logico inserir(inteiro vetor[], inteiro valor, inteiro pos){
		se(tamanhoVetor(vetor) >= 10){
			//capacidade do vetor
			retorne falso
		}
		se(pos > 9 ou pos < 0){
			//limite vetor
			retorne falso
		}

		se (vetor[pos] == 0 ){
			vetor[pos] = valor
		}
		senao{
			para(inteiro i = 9; i > pos; i--){
				vetor[i] =  vetor[i - 1]
			}
			vetor[pos] =  valor 
		} 
		//mostrando na tela
		para(inteiro i = 0; i < 10; i++ )
		escreva(vetor[i]+ " ")
		retorne verdadeiro
	}

	
		//quantidade de numero diferente de zer0
	funcao inteiro tamanhoVetor(inteiro vetor[]){
		
		inteiro contador = 0
		
		para(inteiro i = 0; i < 10; i++)
		{
			se (vetor[i] != 0)
			{
				contador++
			}

		}
		
		retorne contador
	
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1204; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */