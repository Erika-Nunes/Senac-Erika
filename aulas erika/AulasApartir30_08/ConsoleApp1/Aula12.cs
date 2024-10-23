// Aula 02/09/2024 - dictionary (Q: rede e mensagem)

//chave -> valor(palavra x significado)
/*
Dictionary<string, string> dicionario = new Dictionary<string, string>(); //primeiro string chave e o segundo valor
dicionario["casa"] = "Um lugar para morr"
dicionario["welcome"] = "Um lugar para morar";

Dictionary<int, string> lista2 = new Dictionary<int, string>(); //primeiro string chave e o segundo valor
lista2[0] = " ";

Dictionary <int,int> lista3 = new Dictionary<int,  int>();
Dictionary <string,string> ips = new Dictionary<string,string>();
ips["americaSul"]= "192.168.0.1";
Dictionary <string, Restaurante>| restaurantes = new Dictionary<string,string>();
Restaurantes


Console.WriteLine(dicionario["bem vindo, fulano"]);
*/
/*

Dictionary <string,string> ipsList = new Dictionary<string,string>();

ipsList.Add("EUROPA","192.168.0.1");
ipsList.Add("brasil","192.168.0.1");
ipsList.Add("Asia","192.168.0.1");
if(!ipsList.ContainsKey("brasil")){
    
}
ipsList.TryAdd("brasil", "90808090");
ipsList.Remove("brasil");
Console.WriteLine(ipsList["brasil"]);
*/

//Quetsão 
/*
classe rede 
atributo:
-dictionary <cidade,ddd>

funções 
-adicionar 
-remover 
- atualizar 
-imprimir 

*/
/*
Rede rede = new Rede();

    rede.AdicionarRede("Aracaju", 79);
    rede.AdicionarRede("Bahia", 75);
    
    rede.RemoverRede("Bahia");
        
    rede.AtualizarRede("São Paulo", 21);
    rede.ImprimirRede("Aracaju", 79);

*/
//se for definir como static todos podem saber ou alterar tal valor - atributo da classe não do obj
/* Assunto de metodos estaticos 
Pessoa p1 = new Pessoa(42);
Pessoa p2 = new Pessoa(10);
Pessoa p3 = new Pessoa(99);
Pessoa p4 = new Pessoa(1);
Pessoa.numeroMistico = 1000;
Pessoa.Teste();
*/

/*
Questão

class Mensagem
atributo:
- static contador (para contar quantas vezes foi chamado o escrever)

função:
- static escrever (chamar o write e implementar contador )



Mensagem.Escrever("Hello");
Mensagem.Escrever("Hello");
Mensagem.Escrever("Hello");
Mensagem.Escrever("Hello");
Mensagem.Escrever("Hello");
Console.WriteLine(Mensagem.contador);
*/