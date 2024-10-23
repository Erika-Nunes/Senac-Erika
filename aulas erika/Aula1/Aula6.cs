// See https://aka.ms/new-console-template for more information
// Aula 6 - P.O.O. Programação Orientada a Objeto 
/*
Random r = new Random();
Circulo c = new Circulo();
Circulo c2 = new Circulo(); //cada c é um objeto diferente com valores e tamanho diferentes se eu fazer algo com um não estarei fazendo no outro
c.raio = 2; //c.raio --> buscando o raio no objeto c 
double d = c.CalcularDiametro();
Console.WriteLine(d);
*/
//Questão

/*Classe retangulo
atributos:
-- largura 
-- altura

funções:
-calcula a area
-calcula o perimetro 

*/
/*
Retangulo r = new Retangulo(2, 5); // r do tipo retangulo e esta instanciando nno tipo retangulo
//r.largura = 2;
//r.altura = 5;
double a = r.CalculoArea();
double p = r.CalculoPerimetro();
Console.WriteLine(a);
Console.WriteLine(p);

*/
//Questão

/*Classe pessoa
atributos:
-- nome
-- ano
-- altura

funções:
-construtor
-calcular idade
-imprimir dados

*/
/*
Pessoa p1 = new Pessoa("Erika", 2001, 1.63);
p1.ImprimirDados();


*/
//Questão

/*Classe Quadrado
atributos:
-- tamanho

funções:
-calcular area
-redimensionar - alterar o tamanho do quadrado

*/
/*
Quadrado q1 = new Quadrado(4, 10);
Console.WriteLine(q1.CalculoArea());
q1.ImprimirDados();
*/

//Questão
/*
Classe Conta de Banco
atributos:
-- numero
-- saldo

funções:
- deposito
- saque
*/
/*
ContaBanco c1 =  new ContaBanco(2728.2625);
//Console.WriteLine(c1.deposito());
c1.saque(50.0);
Console.WriteLine($"Conta: {c1.Getnumero()} - Saldo: {c1.Getsaldo()}");
c1.deposito(100);
Console.WriteLine($"Conta: {c1.Getnumero()} - Saldo: {c1.Getsaldo()}");
//c1.ImprimirDados();
*/
//Questao
/*
Classe Aluno
atributos:
-- matricula
-- nome
-- nota1
-- nota2
-- nota trabalho
funções:
- calcular media
    nota da prova: peso 2,5
    nota do trablho: 2,0
- calcular quanto precisa na prova final (media 6)

---------------------------------------------------
funcionamento do peso
peso 5 * 2,5
peso 4 * 2
divide pela quantidade total (7)
(5 + x)/2 = 6(media)
*/
/*
Aluno a1 = new Aluno(1, "Erika", 4, 4, 4);
Console.WriteLine(a1.Getnome() + "" + a1.ProvaFinal());
*/