class Clientes
{

    private string ID = " ";
    public string nomes = " ";
    private string email = " ";
    
    public Clientes(string ID, string nomes, string email) {
        this.ID = ID;
        this.nomes = nomes;
        this.email = email;
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
    public PessoaFisica(int cpf) : base(ID, nomes, email) {
        this.cpf = cpf;
    }
}
class PessoaJuridica : Clientes
{
    
    private int cnpj;
    public PessoaJuridica(int cnpj) : base(ID, nomes, email) {
        this.cnpj = cnpj;
    }
}

class Empresa 
{
    private List<Clientes> listaCliente = new List<Clientes>();
    public void AdicionarCliente(int ID, string nomes, string email, int cpf, int cnpj) {

       Clientes cliente = new Clientes(ID ,nomes , email, cpf, cnpj );
        
        listaCliente.Add(cliente);
    }
    public void RemoverCliente() {
        if (listaCliente.Count == 0){
            return;
        }
        listaCliente.RemoveAt(0);
    }

}