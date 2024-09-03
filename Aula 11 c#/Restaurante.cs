//Aula 11 - 30/08/2024
class Cliente {
    private string nome;
    private string telefone;

    public Cliente(string nome, string telefone) {
        this.nome = nome;
        this.telefone = telefone;
    }

    public string GetNome() {
        return nome;
    }

    public override string ToString()
    {
        return $"Nome: {nome} | Telefone: {telefone}";
    }
} 

class Restaurantes {
    private List<Cliente> fila = new List<Cliente>();

    public void AdicionarCliente(string nome, string telefone) {

       Cliente cliente = new Cliente(nome, telefone);
        // lista.Add(pessoa);

        fila.Add(cliente);
    }
    public void RemoverCliente() {
        if (fila.Count == 0){
            return;
        }
        fila.RemoveAt(0);
    }
    public void LimparFila(string nome){
        //fila = new List<Cliente>(); //eliminaria a lista antiga, pois está criando uma em cima
        fila.Clear();
        //for (int i = 0; i < fila.Count; i++)
       //{
           // fila.RemoveAt(i);
        //}
    }
    public void ImprimirFila() {
        //foreach (Cliente cliente in fila)
       // {
           // Console.WriteLine(fila.ToString());
        //}
    
        for (int i = 0; i < fila.Count; i++)
        {
        Console.WriteLine($"{i} - {fila[i].ToString()}");
        }
    
    
    }

}
