class Prato
{
    public int Id{ get; set;}
    public string Nome{ get; set;}
    public int Porcao{ get; set;}
    public double Peso{ get; set;}
    public List <string> Ingredientes { get; set;}

    public Prato( int Id,string Nome,int Porcao,double Peso, List<string> Ingredientes){
       this.Id = Id;
       this.Nome = Nome;
       this.Porcao = Porcao;
       this.Peso = Peso;
       this.Ingredientes = Ingredientes;
    }
}