class Quadrado
{
    private double tamanho = 0.0;
    private double novoTamanho = 0.0;
   

    public Quadrado(double tamanho, double novoTamanho){
        this.tamanho = tamanho;
        this.novoTamanho = novoTamanho; 
        
    }
    public double CalculoArea(){
        //return Math.Pow(); //potencia 
        return this.tamanho * this.tamanho;
    }

    public double Redimensionar(){ ///*(double novoTamanho)*/
        tamanho = novoTamanho; //quando usa o void não precisa de return
        return novoTamanho * novoTamanho;
    }
    public void ImprimirDados(){
        double area = CalculoArea(); 
        double nt = Redimensionar();
        Console.WriteLine($"Area: {area} - Redimensionamento: {Redimensionar}");

    }
}