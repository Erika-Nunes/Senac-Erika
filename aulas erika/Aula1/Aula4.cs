//Aula 4 C#//

//Questão 14
// Criar um vetor de 7 elementos. Preencher com números aleatórios entre 1 e 10. Impmimir o Vetor
/*
int[] vec = new int[7]; //vetor de 7 posiçoes 


for(int i = 0; i < vec.Length; i++){
    Random aleatorio = new Random(); //gerar numeros aleatorios
    int numero = aleatorio.Next(1, 10);
    vec[i] = numero;
    //vetor[i] = random.Next(1,10); - faz diretão

}
for(int i = 0; i < vec.Length; i++){

    
    Console.Write(vec[i] + " "); //vec[i] - significa que o vetor inicia em "i"

}
*/

//foreach - para cada

//foreach(int item in vetor){ //o item é um elemento -não é oo indice -- é o numero entre as chaves no vetor - 
//só usa quando não precisar usar o [i] ou seja de posição

//}
//Questão 15
//Preencher um vetor 10 elementos com as notas dos alunos. 
//Impmimir as notas,médias,maior e a menor nota 
/*
double[] vetor = new double[10];
//int[] vetor = {};
double soma = 0.0;
double media = 0;
double maior = 0;
double menor = 0;
bool cont = true;

foreach (Double item in vetor)
{
    Random aleatorio = new Random();
    vetor[(int)item] = aleatorio.Next(0,100)/10.0;
        Console.Write(vetor[(int)item] + " ");
        soma += vetor[(int)item];
    media = soma / 10;
        
    if (vetor[(int)item] > maior )
    {
        maior = vetor[(int)item];
    }
    if(vetor[(int)item] < menor || cont == true){
        menor = vetor[(int)item];
        cont = false;
    }
    
}
    Console.Write(media + " ");
    Console.Write("a maior nota: "+ maior + " ");
    Console.Write("a menor nota: "+ menor + " ");
*/

/* do prof
double[] notas
for (int i = 0; i < vetor.Length; i++)
{
    double nota = Math.Round(random.NextDouble()*10);
    notas[i] = nota;
}
foreach(var nota in notas){
    Console.Write(nota + " " );
    soma += nota;
    if(nota > maior){
        maior = nota;    
    }
    if{
        menor = nota;
    }
    media = soma / notas.Length;
}
Console.Write(media + " ");
Console.Write("a maior nota: "+ maior + " ");
Console.Write("a menor nota: "+ menor + " ");
*/
//Matriz -- int[,] matriz = new int[5, 5];
/*
int[,] matriz = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
     Console.WriteLine();


}
Console.WriteLine();
*/
//Questão 16

// fazer matriz 1 0 0 0 0
/* 1 0 0 0 0 
   0 1 0 0 0
   0 0 1 0 0
   0 0 0 1 0
   0 0 0 0 1
*/
/*
//toda vez que for igual  j e for 
int[,] matriz = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    
    for (int j = 0; j < 5; j++)
    {
        if(i == j){
            matriz[i,j] = 1;
        }
        else{
            matriz[i,j] = 0;
        }

        Console.Write(matriz[i, j] + " ");
    }
     Console.WriteLine();


}
Console.WriteLine();

*/