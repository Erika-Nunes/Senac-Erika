//Aula 2 C#//


//Questão 5

//mostrar na tela a sequencia 1 2 3 4 5 6 7 8 9 10
/*
int numero = 0;
while (numero < 10){
    numero++;
    Console.Write(numero); //somente o write para não pular linha 
}
*/
//Obs.: Utilizando o "contador  - "contador" += 1 ou contador++ ou contador = contador + 1
// Obs.: ++contador - vai somar antes -- contador++ - vai repetir valor 


//Questão 6

//Pedir um numero para o usuario e imprimir de 0 até o numero que ele digitou 
// 5 - 0 1 2 3 4 5 
/*
Console.WriteLine("Digite um numero: ");
int numero = Convert.ToInt32(Console.ReadLine());
int i = 0;

while(numero >= i){
    
    Console.Write(i +" ");
    ++i;
}
*/
//Questão 7

//soma de 6 + 8 + 10 + 12 + 14 + 16 + ... + 98 + 100
/*
int valor = 6;
int soma  = 0;
int contador = 2;

 
while(valor <= 100){
    soma += valor ;
    valor += 2;
}
Console.WriteLine(soma +" ");
*/

//Pedir 5 numeros para o usuario e imprimir quantos sao pares e quantos sao impares 
/*
int contador = 0;
int contador_par = 0;
int contador_impar = 0;

while(contador < 5){
    Console.WriteLine("Digie um numero: " +contador + "º:");
    int numero = Convert.ToInt32(Console.ReadLine());


        if (numero % 2 == 0){
            contador_par++;
        }    
        else
        {
            ++contador_impar;
        }   
     contador++;   
}
Console.WriteLine("total par: "+contador_par+" total impar: "+contador_impar);
*/
// Assunto "FOR(PARA DO PORTUGOL)"
// for (var i = 0; i < 10; i++){ }

//Questão 8

// usando o para - reproduza a sequencia 0 1 2 3 4 5 6 7 8 9
/*
for(var i = 0; i < 10; i++){
    Console.Write(i + " ");
}
*/
//Questão 9

//Gerar 20 numeros aleatorios entre 0 e 10. Imprimir os numeros,
//quantos maiores que 5 e quantos divisiveis por 3
/*
int contador_maior5 = 0;
int contador_div3 = 0;
for(int i = 0; i < 20; i++){
    Random aleatorio = new Random(); //criar variavel random(aleatoria) do tipo random
    var numero = aleatorio.Next(0, 10); //sorteia(0, 100)
    Console.Write(numero + " ");
    
    if(numero > 5){
        contador_maior5++;
    }
    if(numero % 3 == 0){
        contador_div3++;
    }

}
Console.WriteLine("\n Total maior que 5: "+contador_maior5+" Total divisivel por 3 : "+contador_div3);
*/