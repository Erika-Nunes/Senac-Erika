//Aula 5 //
//Funções -- tem que ter retorno 
/*
var resultado = Soma(10,20);
int soma; //se for para mostrar somente o result tem que por --> dotnet run --property WarningLevel=0
Console.WriteLine(resultado);

//void - espaço no vazio void Soma(int num1, int num2){ não retorna nada }
int Soma(int num1, int num2){
    return(0);

}
*/
//Questão
//Escreva uma função que recebe uma string como parametro e ela retorna 
//a quantidade de palavras na frase
/*
Console.WriteLine(ContadorPalavras("Naruto é o maior"));
   

int ContadorPalavras(string frase){
        //1ª forma
    //string[] f = { "ola" "mundo"};
    //return frase.Split(' ').Length;
    //Console.WriteLine(frase[0]); -- para mostrar/percorrer o item selecionado pelo vetor
        //2ª forma
    int contador = 1;
    for (int i = 0; i < frase.Length; i++)
    {
        if(frase[i] == ' '){
            contador++;
        }
    }
    return contador;
}

*/
/*
//Questão
//string reversa 
StringInverso("Erika");

void StringInverso(string palavra){
    var reverso = palavra.Reverse().ToArray();
    Console.WriteLine(reverso);

}
*/