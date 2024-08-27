class Produto
{
    protected int identificador = 0;
    public string nome = " ";

    public Produto(int identificador,string nome){
        this.identificador = identificador;
        this.nome = nome;
    }

}
class Industrializado : Produto
{
    private int CodBarra = 0;
    public string marca = " ";

    public Industrializado(int identificador,string nome, int CodBarra, string marca) : base(identificador, nome){
        this.CodBarra = CodBarra;
        this.marca = marca;
    }
    public void ImprimirDetalhesIndustri(){
    Console.WriteLine($" Seu ID:{identificador} - nome: {nome} - Codigo de barras: {CodBarra} - Marca: {marca}");
    }
}    
class Natural : Produto
{
    private double peso = 0.0;

    public Natural(int identificador,string nome, double peso) : base(identificador, nome){
        this.peso = peso;   
    }
    public void ImprimirDetalhesNatural(){
    Console.WriteLine($" Seu ID:{identificador} - nome: {nome} - Peso: {peso}");
    }

}

