//Aula 7 - Herança
/*
-----------------------------------------------------
Utiliza os ":" para dizer que esta herdando algo de outra class
O primeiro sempre erra do segundo Filho(classe derivada) : Pai
ele vai ter o dele mais oq ele herda
Design Patterns 
*/
/*
Filho f = new Filho();
f.atributoPaiInt = 99;
Console.WriteLine(f.atributoPaiInt);

*/

//Questão
/*
Classe Pessoa
atributos:
-- nome
-- CPF 

Classe Funcionario 
atributos:
- salario
- cargo 

Função
-imprimirDetalhes: nome,cpf,salario,cargo
*/
/*
//Pessoa2 p1 = new Pessoa2();
Funcionario f1 = new Funcionario("Erika Caroline",081111111,1412.0,"auxiliar financeiro");
/*
//f1.nome = "Erika Caroline";
//f1.cpf = 081111111;
//f1.salario = 1412.0;
//f1.cargo = "auxiliar financeiro";

f1.ImprimirDetalhes();
*/
//Questão
/*
Classe Produto (a ser herdado)
atributos:
-- identificado(id) todo produto tera e nem sempre codigo de barra
-- nome

Classe Industrializados 
atributos:
- cod. barras
- marca

Classe naturais
atributos:
- peso


Função
-imprimirDetalhes: id,nome,cod barra,marca,peso
/*
Produto p1 = new Produto (0, "papel");
Industrializado i1 = new Industrializado(1, "suco",0101,"marata");
i1.ImprimirDetalhesIndustri();

Natural n1 = new Natural(2, "manga",8);
n1.ImprimirDetalhesNatural();

//n1.ToString =  //pegar e converter para string
//console.writeline(n1.ToString)
return base.toostring 

*/