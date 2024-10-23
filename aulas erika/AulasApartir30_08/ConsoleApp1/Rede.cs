
class Pessoa { //Assunto 2 --numeros estaticos ,metodos estaticos- para não precisar instanciar 
//para utilizar a função Math. - para nos auxiliar para alguam coisa  - Utils. 
    int numero;
    public static int numeroMistico = 0 ;
    public Pessoa(int numero){
        this.numero = numero;
    }
    public static void Teste(){
        Console.WriteLine("Teste");
    }
}

class Rede //Asssunto 1 -- Dictionary
{
    private Dictionary<string, int> RedeTelefone = new Dictionary<string, int>();// não consegue adicionar a mesma cidade com ddd difrentes
    public void AdicionarRede (string cidade, int ddd){
       if (RedeTelefone.ContainsKey(cidade)) //checar se ja existe um igual
       {
            Console.WriteLine("Cidade já cadastrada");
            return;
       } 
        RedeTelefone.Add(cidade, ddd);
        Console.WriteLine("Cidade cadastrada com sucesso");
        //if(RedeTelefone.TryAdd(cidade, ddd)){//testa e retorna em booleano
            //Addcom sucesso 
       // }
       // else
        //{
        //    //cidade já cadastrada
        //}
    }    
    public void RemoverRede(string cidade){
        if (RedeTelefone.Remove (cidade))
        {
            Console.WriteLine("Cidade REMOVIDA com sucesso");
        }
        else
        {
            Console.WriteLine("Cidade NÃO REMOVIDA");
        }
    }
    public void AtualizarRede(string cidade, int ddd){
        if (!RedeTelefone.ContainsKey(cidade))
        {
             Console.WriteLine("Cidade NÃO Encontrada");
             return;
        }
        RedeTelefone[cidade] = ddd;
         Console.WriteLine("Cidade atualizada com sucesso");

    
    }
    public void ImprimirRede(string cidade, int ddd){
        if (!RedeTelefone.ContainsKey(cidade))
        {
             Console.WriteLine("Cidade NÃO Encontrada");
             return;
        }
    Console.WriteLine($"{cidade} - {ddd}");
    }
}

