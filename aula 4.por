programa
{
	
	funcao inicio()
	{
		//Pedir 3 notas para o usuario calcular a media, imprimir se o aluno está reprovado,recuperação ou aprovado 
		//a. menor que 5: reprovado
		//b. entre 5 e 7: recuperação
		//c. maior que 7: aprovado

//		real nota1 = 0.0
//		real nota2 = 0.0
//		real nota3 = 0.0
//		real media = 0.0 
//
//		escreva("digite a primeira nota:")
//		leia(nota1)
//
//		escreva("digite a segunda nota:")
//		leia(nota2)
//
//		escreva("digite a terceira nota:")
//		leia(nota3)
//
//		media = (nota1 + nota2 + nota3)/3
//
//		se (media<5){
//			escreva("o aluno está reprovado")
//		}
//		//senao se (media >=5 e media<7){ //usando o "e"
//		senao se (media <= 7){
//			escreva("o aluno está de recuperação")
//		}
//		senao {
//			escreva("O aluno está aprovado")
//		}

		//Pedir 1 numero para o usuario e imprimir se:
		//a. é positivo ou negativo 
		//b. se é par ou ímpar

//		inteiro num1 = 0
//		real negativo
//		
//		
//		escreva("digite um numero:")
//		leia(num1)
//		se(num1 == 0){
//			escreva("Neutro\n")
//		}
//		se (num1 > 0){
//			escreva("Positivo")
//			}
//		senao{
//			escreva("Negativo")
//		}
//
//		se(num1 % 2 == 0)
//		{
//		escreva(" e este numero é par")
//		}
//			
//		senao
//		{
//			escreva(" este numero é impar")
//		}

		//Pedir para o usuario o valor do salario minimo e o salario atual
		//Imprimir novo salario
		//a. salario atual ate 3 salarios minimos -> +50%
		//b. salario atual entre 3 e 10 -> +20%
		//c. salario atual entre 10 e 20  -> +15%
		//d. salario atual acima de 20  -> +10%

//		real salario_m = 0.0
//		real salario_atual = 0.0
//		real novo_sal = 0.0
//		//multiplicador = 0.0
//		escreva("digite o valor do salario minimo: ")
//		leia(salario_m)
//
//		escreva("digite o valor do seu salario atual : ")
//		leia(salario_atual)
//
//		se (salario_atual <= 3*salario_m){
//			novo_sal = (salario_atual * 0.5)+salario_atual //pode multiplicar direto por 1.5(total + 50% ou 100% + 50%)
//			escreva("Novo salario é:" +novo_sal) 
//		}
//		senao se(salario_atual <= 10*salario_m){
//			novo_sal = (salario_atual * 0.2)+salario_atual
//			escreva("Novo salario é:" +novo_sal)
//			//multiplicador = 1.2
//		}
//		senao se(salario_atual <= 20*salario_m){
//			novo_sal = salario_atual * 0.15 + salario_atual
//			escreva("Novo salario é:" +novo_sal)
//		}
//		senao{ //se(salario_atual > 20*salario_m){
//			novo_sal = (salario_atual * 0.10)+salario_atual
//			escreva("Novo salario é: " +novo_sal)
//		}
//		
		//novo_sal = salario_atual + multiplicador

		//Operadores Logicos E e Ou

//		real nota1 = 0.0
//		real nota2 = 0.0
//		real nota3 = 0.0
//		real media = 0.0 
//
//		escreva("digite a primeira nota:")
//		leia(nota1)
//
//		escreva("digite a segunda nota:")
//		leia(nota2)
//
//		escreva("digite a terceira nota:")
//		leia(nota3)
//
//		media = (nota1 + nota2 + nota3)/3
//
//		se (media<5){
//			escreva("o aluno está reprovado")
//		}
//		senao se (media >=5 e media<7){ //usando o "e"
//		
//			escreva("o aluno está de recuperação")
//		}
//		senao {
//			escreva("O aluno está aprovado")
//		}

		//Pedir um numero para o usuario e imprimir se o numero é valido 
		//Intervalo: [100-200[ tem que ser menor que 200

//		inteiro num1
//
//		escreva ("digite um numero:")
//		leia(num1)
//
//		se(num1 >=100 e num1<200){
//		escreva("valido")}
//		senao{
//			escreva("invalido")
//		}
//		}
		//Pedir 1 numero para o usuario e imprimir se o numero é valido
		//maior que 80 ou menor que 25 ou igual a 40 entao valido  
		
//		inteiro num = 0
//
//		escreva ("digite um numero:")
//		leia(num)
//
//		se(num>80 ou num<25 ou num == 40){ //as vezes vai acontecer de precisarmos usar os parentesis para mudar a ordem de execução
//			escreva("numero valido")}
//		
//		senao{
//			escreva("numero invalido")}
//		
		//Pedir o nome do mês para o usuario e imprimir quantos dias tem esse mes

//		cadeia nome_mes
//		inteiro dias
//
//		escreva ("digite um mês: ")
//		leia(nome_mes)
//
//		se (nome_mes == "Janeiro" ou nome_mes =="janeiro" ou nome_mes =="Março" ou nome_mes =="março" 
//			ou nome_mes =="Maio" ou nome_mes =="maio" ou nome_mes =="Julho" ou nome_mes =="julho" ou nome_mes =="Agosto" ou nome_mes =="agosto"
//			ou nome_mes =="Outubro" ou nome_mes =="outubro" ou nome_mes =="Dezembro" ou nome_mes =="dezembro"){
//			escreva("Esse mês tem 31 dias!")
//		}
//		senao se (nome_mes == "Abril" ou nome_mes =="abril" ou nome_mes =="Junho" ou nome_mes =="junho" 
//			ou nome_mes =="Setembro" ou nome_mes =="setembro" ou nome_mes =="Novembro" ou nome_mes =="novembro"){
//			escreva("Esse mês tem 30 dias!")	
//		}
//		senao se (nome_mes == "Fevereiro" ou nome_mes =="fevereiro"){
//			escreva("Esse mês tem 28 dias")
//		}
//		senao{
//			escreva("Digite um mês valido -> ex: Janeiro, janeiro")
//
//		}

		//Pedir um ano para o usuario e imprimir se o ano é bissexto

//		inteiro ano = 0
//		
//
//		escreva ("digite um ano: ")
//		leia(ano)
//		
//		
//		se((ano % 4 == 0 e ano % 100 != 0) ou ano % 400 == 0 ){
//			escreva("esse ano é bissexto")
//		}
//		senao{
//			escreva("esse ano não é bissexto")
//		}

		 //Estrutura de repetição 

//		 inteiro contador = 0
//		 
//		 enquanto (contador <= 10){
//		 	escreva(contador + " ")
//		 	 contador = contador + 1
//		 	
//		 }

		// Imprimir ordem reversa 10 - 0
//		inteiro contador = 10
//		 
//		 enquanto (contador >= 0){
//		 	escreva(contador + " ")
//		 	 contador = contador - 1
//		 	
//		 }
 		// 6 7 8 9 10 Fim!
//		 inteiro contador = 6
//		 
//		 enquanto (contador <=10){
//		 	escreva(contador + " " )
//		 	 contador = contador + 1
//		 	 
//		 }
//		 	escreva ("Fim!")
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
//		
	
	}

}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 6575; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */