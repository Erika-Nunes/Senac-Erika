/*
//Aula 10 - Contato - 29/08/2024
class Pessoas {
     private string nome;
    private string telefone;
    
    public Pessoas(string nome, string telefone){
        this.nome = nome;
        this.telefone = telefone;
    }
    public string Getnome(){
        return nome;
    }
    public string Gettelefone(){
        return telefone;
    }
    public override string ToString()
    {
        return $"Nome: {nome} | Tel: {telefone}";
    }
}
class Contatos {
 
 private List<Pessoas> agenda = new List<Pessoas>();  
    
    public override bool Equals(object? obj)
    {
        Contatos outroContato = (Contatos)obj!;
        return nome == outroContato.nome;
    }

    public void AdicionarPessoas(string nome,string telefone){
        int indice = BuscarPessoasIndice(nome);
        if(indice < 0){
            Console.WriteLine("Contato invalido");
            return;
        }
        agenda.Add(new Pessoas(nome,telefone));
        
        
    }
    public void RemoverPessoas(string nome){
       int indice = BuscarPessoasIndice(nome);
       if (indice < 0)
       {
        Console.WriteLine("Contato inexistente");
        return;
       }
       
        agenda.RemoveAt(4);

    }  
    public int BuscarPessoasIndice(string nome){
        for (int i = 0; i < agenda.Count; i++){
            if (nome == agenda[i].Getnome())
            {
                return i;
            }
        return -1;
       
        }
    }
    public Pessoa BuscarPessoas(string nome){
       foreach (var item in agenda)
       {
            Console.Write(item +",");
       }
       
       Console.WriteLine($"\n Para o índice {nome} o contato é:{agenda.ElementAt(nome)}");
        Console.ReadLine();    
    }
    public void ImprimirContatos(){
        for (int i = 0; i < agenda.Count; i++)
        Console.WriteLine($"{i} - {telefone}");
    }
    public void ImprimirPessoa(){
        for (int i = 0; i < agenda.Count; i++)
        Console.WriteLine($"{i} - {nome[i]}");
    }
}
*/ 

              //Questão resolvida pelo professor 
 class Pessoa {
    private string nome;
    private string telefone;

    public Pessoa(string nome, string telefone) {
        this.nome = nome;
        this.telefone = telefone;
    }

    public string GetNome() {
        return nome;
    }

    public override string ToString()
    {
        return $"Nome: {nome} | Tel: {telefone}";
    }
} 

class Contatos {
    private List<Pessoa> lista = new List<Pessoa>();

    public void AdicionarPessoa(string nome, string telefone) {
        int indice = BuscarPessoaIndice(nome);

        if (indice >= 0) {
            Console.WriteLine("Pessoa já cadastrada");
            return;
        }

        // Pessoa pessoa = new Pessoa(nome, telefone);
        // lista.Add(pessoa);

        lista.Add(new Pessoa(nome, telefone));
    }

    public void RemoverPessoa(string nome) {
        int indice = BuscarPessoaIndice(nome);

        if(indice < 0) {
            Console.WriteLine("Pessoa não encontrada");
            return;
        }

        lista.RemoveAt(indice);
    }

    public int BuscarPessoaIndice(string nome) {
        for (int i = 0; i < lista.Count; i++) {
            if (nome == lista[i].GetNome()) {
                return i;
            }
        }

        return -1;
    }

    public Pessoa? BuscarPessoaObjeto(string nome) {
        for (int i = 0; i < lista.Count; i++) {
            if (nome == lista[i].GetNome()) {
                return lista[i];
            }
        }

        return null;
    }

    public void ImprimirContatos() {
        foreach (Pessoa pessoa in lista)
        {
            Console.WriteLine(pessoa.ToString());
        }
    }

    public void ImprimirPessoa(string nome) {
        int indice = BuscarPessoaIndice(nome);

        if (indice < 0) {
            Console.WriteLine("Pessoa não encontrada");
            return;
        }

        Console.WriteLine(lista[indice].ToString());
    }
}