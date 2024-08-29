class CarrinhoDeCompras
{
    private string[] NomeProdutos = new string[5];
    private double total = 0.0;
    public CarrinhoDeCompras() {
        NomeProdutos = new string[5];
    }
    public void AdicionarItem(string nome,double preco){
        for (int i = 0; i < NomeProdutos.Length; i++)
        {
            if(string.IsNullOrEmpty(NomeProdutos[i])){ //se nula ou vazia 
                NomeProdutos[i] = nome;
                total += preco; //incrementa os preços no total 
                return;
            }
        } 
    }
    public double GetTotal(){
        return total;
    }
    public void ImprimirProdutos(){
        for (int i = 0; i < NomeProdutos.Length; i++)
        {
            Console.WriteLine($"{i} - {NomeProdutos[i]}");
        }
    }
}


   
    


