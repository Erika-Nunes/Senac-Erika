class Produtos2
{
    public string nome = "";
    private double preco = 0.0;

    public Produtos2(string nome, double preco){
        this.nome = nome;
        this.preco = preco;
    }


    public override bool Equals(object? obj)
    {
        Produtos2 outraProduto = (Produtos2)obj!;
        return nome == outraProduto.nome;
    }
    //segunda forma
    public bool Igual(Produtos2 outroProduto){
        return nome == outroProduto.nome;
    }
}