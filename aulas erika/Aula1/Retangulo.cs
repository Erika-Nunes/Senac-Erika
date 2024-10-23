class Retangulo{
    
    private double largura = 0;
    private double altura = 0;
    
    public Retangulo(double largura, double altura){ //para mão precisar criar outra variavel 
        this.largura = largura; // precisa do this pois tem mesmo nome da class
        this.altura =  altura;
    }

    public double CalculoArea()
    {
        return largura * altura;
    }
    public double CalculoPerimetro()
    {
        return (largura + altura)*2;
    }

}

//quando se usa this.altura = altura ''this' esse this ta se referindo a largura da classe, se ambos os nomes tanto da classe quanto da função forem iguais não a problema  
//ajuda com isso de publico e privado 