using System.Security.Cryptography.X509Certificates;

class Pessoa2 //classe ": base(nome,cpf){não precisa por o this. pois já está puxando }
{
    protected string nome = " ";
    protected int cpf = 0;
    
    public Pessoa2(string nome, int cpf) {
        this.nome = nome;
        this.cpf = cpf;
    }
}

class Funcionario : Pessoa2
{
    private double salario = 0.0;
    private string cargo = " ";
    public Funcionario(string nome, int cpf,double salario, string cargo) : base(nome, cpf){
        this.salario = salario;
        this.cargo = cargo;

    }
    public int Getcpf(){
        return cpf;
    }
    public string Getcargo(){
        return cargo;
    }
    public void ImprimirDetalhes(){
        Console.WriteLine($"{nome} de cpf: {cpf}, cargo: {cargo} tem salário de: {salario}");
    }
}
/*



*/

