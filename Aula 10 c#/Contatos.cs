using System.ComponentModel;
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



 //
        //{
       //     Console.WriteLine($"{i} - {nome[i]} - {telefone}");
       // }