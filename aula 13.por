programa
{
	
	funcao inicio()
	{
//		inteiro num1,num2
//		
//		escreva("digite um valor: ")
//		leia(num1)
//		escreva("digite um valor: ")
//		leia(num2)
//		
//		inteiro resultado = soma(num1, num2)
//		escreva(resultado)
//
//				//ou
//		//inteiro resultado = soma(1, 5)
//		//escreva(resultado)	
			//Criar uma função que recebe 3 notas e retorna a média
			//imprimir situação do aluno
			//media maior que 7: aprovado
			//media entre 5 e 7: recuperação
			//media menor que 5: reprovado

//		real nota1,nota2,nota3
//		escreva("digite um valor: ")
//		leia(nota1)
//		escreva("digite um valor: ")
//		leia(nota2)
//		escreva("digite um valor: ")
//		leia(nota3)
//		
//		real media_notas = media(nota1,nota2,nota3)//(5.1,6.6,8.48)
//		escreva(media_notas)
//
//		se(media_notas > 7){
//			escreva( " - aprovado ")
//		}
//		senao se (media_notas > 5 ){
//			escreva(" - recuperação")
//		}
//		senao{
//			escreva(" - reprovado")
		//Criar uma função que recebe um vetor e retorna o tamanho do mesmo


		inteiro vetor[10]
		inteiro tamanho = tamanhoVetor(vetor)
		escreva(tamanho)

		
		}

		//Criar uma função que recebe um vetor e retorna o tamanho do mesmo
		//quantidade de numero diferente de zero
	}
	funcao inteiro tamanhoVetor(inteiro vetor[]){
		inteiro contador = 0
		para(inteiro i = 0; i < 10; i++)
		{
			contador++
		}
		
		retorne contador
	}


	funcao real media(real nota1, real nota2,real nota3){
		real media_notas = (nota1 + nota2 + nota3)/3
		
		retorne media_notas
		//ou retorne (nota1 + nota2 + nota3)/3
	}

	funcao inteiro soma(inteiro num1, inteiro num2){
		inteiro resultado = num1 + num2
		//se (resultado == 0){ // Utilizando o SE com o RETORNE
			//retorne -1
		//}
		retorne resultado 
				//ou
		retorne num1 + num2
	}

	

}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 1216; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */