// Aula 3
 //Questão 10

//Pedir 5 preços para o usuario e imprimir o maior e o menor valor 
/*
Boolean menorP = true;
double maior = 0.0;
double menor = 0.0;

for(double i = 0.0; i < 5; i++){
    Console.WriteLine("Digite um preço: " +"R$:");
    double preco = Convert.ToDouble(Console.ReadLine());
  

    if(maior < preco ){
        maior = preco;
        
    }
    if (preco < menor || menorP){
        menorP = false;
        menor = preco;
        
    }
}
Console.WriteLine("Maior preço: "+maior+ " Menor preço: " +menor);

*/
// Assunto -- Do{ codigo } while(condicional) -- vai rodar pelo menos uma vez
//while(condicional) -- esse possa ser que não roda

//Exemplo Do -- WHILE
/*
int contador = 0;
do{
    Console.Write(contador +"");
    contador++;
}

while(contador < 10);
*/
//gerar um numero aleatorio entre 0 e 100.
//usuario pode chutar ate acertar 
/*
bool acertou = false;
Random aleatorio = new Random();
int numero = aleatorio.Next(0, 100); //sorteia(0, 100)
Console.Write(numero + " ");

while (!acertou){
    Console.WriteLine("Adivinhe o numero sorteado: ");
    int certo = Convert.ToInt32(Console.ReadLine());
    if(certo == numero)
    {
        acertou = true;
        Console.WriteLine("Acertou ");
    }
    else{
        acertou = false;
        Console.WriteLine("Tente novamente!!! ");
    }
    
} 
*/
//Quetsão 12
//pedir um numero para o usuario e imprimir o dia da smena corresp

//usando switch e break
/*
Console.WriteLine("Digite um numero: ");
int dia = Convert.ToInt32(Console.ReadLine());

switch(dia){
    case 1:
        Console.WriteLine("Domingo");
        break;
    case 2:
        Console.WriteLine("Segunda");
        break;
    case 3:
        Console.WriteLine("Terça");
        break;
    case 4:
        Console.WriteLine("Quarta");
        break;
    case 5:
        Console.WriteLine("Quinta");
        break;
    case 6:
        Console.WriteLine("Sexta");
        break;
    case 7:
        Console.WriteLine("Sabado");
        break;

}
*/

//vetores

//int[] vector = {0,1,2,3,4 }; //voce mesmo atribui os numeros
/*
int[] vec = new int[10]; // ja gera auto
//int vetor  = 0;

for(int i = 0; i < vec.Length; i++){
    vec[i] = i;

}
for(int i = 0; i < vec.Length; i++){

    
    Console.Write(vec[i] + " ");

}
*/