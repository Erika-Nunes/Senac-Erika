
//Aula 15 - 05/09/2024
/*
classe Data
atributos:
- Dia 
- Mes
-Ano

funções:
-- construtor (dia,mes,ano) não vai fazer nenhuma verificação
-- Construtor(vazio) - que não passamos nada -> 01/01/01
-- get e um set - Get & Set -> Dia (pega um dia set outro )
-- get e um set - Get & Set -> Mes
-- get e um set - Get & Set -> Ano
-- Nome do mes()
-- Ano Bissexto()
-- clonar() pegarum objeto igual ao seu 
-- comparar(Data)
    - 1: se a data for maior
    - 0: se for igual
    - -1 se a data for menor 

var d1= new Data(10,1,2025)
var d2 = d1.clonar()




var d1 = new Datas(10,1,2025);
var d2 = new Datas(10,1,2025);
//var d2 = d1.clonar()
//d1.comparacao(new Data(11, 1 , 2022));
Console.WriteLine("");

//Data d1 = d.Clonar();
//Console.WriteLine(d1.GetDia() + "" +d1.GetMes()+ "" +d1.GetAno());
*/

//Questão
/*
Classe Voo
atributos:
- numero do Voo
- data
- vetror de assentos

Funções:
- bool AssentoDisponivel(posicao)
- int ProximoAssentoDisponivel()
- int QntdAssentosDisponiveis()
- ReservarAssento(int)
- Get NumVoo
- Get Data 
- ImprimirStatus()
    - Imprimir se o voo é de hoje, se já foi ou se ainda vai acontecer

*/

Voo voo = new Voo(0, new Data(9, 9, 2024));
voo.ReservarAssento(0);
voo.ReservarAssento(voo.ProximoAssentoDisponivel());
Console.WriteLine(voo.IsAssentosDisponivel(7));
voo.ImprimirStatus();