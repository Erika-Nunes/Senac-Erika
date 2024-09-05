class Clientes
{

    protected string ID = " ";
    protected string nomes = " ";
    protected string email = " ";
    
    public Clientes(string ID, string nomes, string email) {
        this.ID = ID;
        this.nomes = nomes;
        this.email = email;
    }
    public virtual void ImprimirDados(){
        Console.WriteLine($"{ID} - {nomes} - {email}");
    }

    public string GetNomes() {
        return nomes;
    }
    public string GetID() {
        return ID;
    }
    public string GetEmail() {
        return email;
    }

    public override string ToString()
    {
        return $"ID: {ID} | Nome: {nomes} | Telefone: {email}";
    }

}

class PessoaFisica : Clientes
{
    private int cpf;
    public PessoaFisica(int cpf, string ID, string nomes,string email) : base(ID, nomes, email) {
        this.cpf = cpf;
    }
    public override void ImprimirDados(){
        Console.WriteLine($"{ID} - {nomes} - {email} - {cpf}");
    }
}
class PessoaJuridica : Clientes
{
    private int cnpj;
    public  PessoaJuridica(int cnpj, string ID, string nomes,string email) : base(ID, nomes, email) {
        this.cnpj = cnpj;

    }
    public override void ImprimirDados(){
        Console.WriteLine($"{ID} - {nomes} - {email} - {cnpj}");
    }
}

class Empresa 
{
    private List<Clientes> listaCliente = new List<Clientes>();
    public void Adicionar(Clientes cliente) {
        foreach (Clientes c in listaCliente)
        {
            if (c.GetID() == cliente.GetID())
            {
                Console.WriteLine("CLIENTE JÁ CADASTRADO");
                return;
            }
        }
        
        listaCliente.Add(cliente);
    }
    

    public void RemoverCliente(Clientes cliente) {
        if (listaCliente.Remove (cliente)){
            Console.WriteLine("Removido com sucesso");
        }
        else
        {
            Console.WriteLine("Cliente não removido");
        }
        
    }
    public void ImprimirPF( int cpf, string ID, string nomes, string email){
       foreach (Clientes cliente in listaCliente)
       {
        if (cliente is PessoaFisica )
        {
            cliente.ImprimirDados();
        }
       }
       
       
        
    }
    public void ImprimirPJ(int cnpj, string ID, string nomes, string email){
       foreach (Clientes cliente in listaCliente)
       {
        if (cliente is PessoaJuridica )
        {
            cliente.ImprimirDados();
        }
       }

    }
}