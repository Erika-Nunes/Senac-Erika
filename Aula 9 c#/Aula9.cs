
/*
                         Asssunto - Lista 
private List<string> lista = new List<string>(); //eu sempre adicionarei itens se couber e aonde couber (não tem tamanho inicial definido (em vetor tem ))
p++ - ele vai acrescentar mesmo se não houver espaço 

private List<string> lista = new List<string>(); // vai na classe base
se eu qusier adicionar algo a lista -- 
lista[0] = "produto"
conosle.writeline(lista[0]);
lista.count //contar a quantidade de itens 
lista.Add(nome);

*/
/*
QUESTÃO
Classe Conta Bancaria
Atributos:
- saldo
- numero
- lista operações -  quantas vezes foi mexido

Funções:
- depositar
- sacar
- Imprimir historico
-----------------------------------------------
ContaBancaria c1 = new ContaBancaria(0);
//ContaBancaria c2 = new ContaBancaria(1);

//Console.WriteLine(c1.Equals(c2));

c1.deposito(50.0);
c1.saque(10.0);
c1.saque(5.0);
c1.ImprimirHistorico();
Console.WriteLine($"Saldo: R${c1.Getsaldo()}");
*/
/*
Questão
Classe PROODUTOS
Atributos:
- NOME
- PREÇO

Funções:
- IGUAL
*/
Produtos2 p1 = new Produtos2("maça", 2.2);
Produtos2 p2 = new Produtos2("pera", 2.4);

Console.WriteLine(p1.Equals(p2));