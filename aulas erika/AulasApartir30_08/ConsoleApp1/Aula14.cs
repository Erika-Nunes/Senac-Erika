//Aula 14 -n 04/09/2024 é a finalização da 13/09
//int cpf, string ID, string nomes,string email) : base(ID, nomes, email) {
//restaurante.ImprimirFila();
//Console.WriteLine(Clientes.PessoaJuridica(01,));


Empresa e1 = new Empresa();
PessoaFisica pf1 = new PessoaFisica(0,"A1","ERIKA","erika@g");
PessoaFisica pf2 = new PessoaFisica(1,"B1","JOAO","JOAO@g");
PessoaJuridica pj1 = new PessoaJuridica(4646,"C1C","ATLAS", "@ATLAS");
PessoaJuridica pj2 = new PessoaJuridica(4747,"D1D","MICRO", "@MICRO");

e1.Adicionar(pf1);
e1.Adicionar(pf2);

e1.Adicionar(pj1);
e1.Adicionar(pj2);

e1.ImprimirPF();
