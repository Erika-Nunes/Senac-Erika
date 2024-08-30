//Aula 10- 29/08/2024
//Crud (create read (update) delete)
//lista telefonica

/*Questao 
atrbutos: (Pessoas ista )
- nome
- telefone 

classe Contatos/agenda 
atributos:
lista de pessoas 

funções:
- AdicionarPessoas(nome,telefone)
    -Não adicionar pessoas duplicadas 
-Remover Pessoa(NOME)
- Buscar pessoa(NOME)
    - Retorna o indice
    -RETORNA -1 CASO NÃO ENCONTRA 
-Imprimir contatos
-imprimir Pessoa(nome)


Insert(dis a lista onde quer posicionar)
Add adiciona no final da lista

*/

Contatos contatos = new Contatos( );
contatos.AdicionarPessoas("A","1");
contatos.AdicionarPessoas("b","2");
contatos.AdicionarPessoas("c","3");
contatos.RemoverPessoas("e");
contatos.ImprimirPessoa("t");

