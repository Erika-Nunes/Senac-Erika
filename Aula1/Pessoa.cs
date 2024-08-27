class Pessoa{
    
    private string nome = "";
    private int ano = 0;
    private double altura = 0;
    
    public Pessoa (string nome, int ano, double altura){ //para mão precisar criar outra variavel 
        this.nome = nome; // precisa do this pois tem mesmo nome da class
        this.ano = ano;
        this.altura =  altura;

    }

    public string NomePessoa(){
       /*Console.WriteLine("Qual seu nome: "); 
        string nome1 = Console.ReadLine();*/
        return nome;
    }
    public int CalculoIdade()
    {
        return 2024 - ano;
    }
    
    public double Tamanho(){
        return altura;
    }
    public void ImprimirDados(){
        int idade = CalculoIdade();
        Console.WriteLine($"Nome: {nome} - Altura: {altura} - Idade: {idade}");
        //Console.WriteLine("O nome é: " +nome+ " tem " +CalculoIdade+ " e sua altura é " +altura);
    }
}

//se por um $ antes do inicio da string faz uma interpolação 
//Console.WriteLine($"Nome: {nome}"); -- indica que o nome entre chaves não é a palavra e sim a variavel
