//aula 9 - 28/08/2024

class ContaBancaria
{
    private double saldo = 0.0;
    private int numeroConta = 0;
    private List<string> ListaOperacoes ;

    public ContaBancaria(int numeroConta){//,double valor){
        this.numeroConta = numeroConta;
        
        ListaOperacoes = new List<string>();

    }
    public double GetnumeroConta(){ //ACESSAR O VALOR SEM PODER ATRIBUIR NADA FORA DA CLASSE
    return numeroConta;
    }
    public double Getsaldo(){
    return saldo;
    }
    public void deposito(double valor){
        
        saldo += valor;
        ListaOperacoes.Add($"Depositou - R${valor}");
      
       
    }
    public void saque(double valor){
       
        if (valor > saldo){
            return;
        }
        
        else
        {
            saldo -= valor;
            ListaOperacoes.Add($"Sacou - R${valor}");
        }
        
     
    }
    public void ImprimirHistorico(){
        foreach (string op in ListaOperacoes)
        {
            Console.WriteLine(op);
        }
            //Console.WriteLine(ListaOperacoes[0]);
           // Console.WriteLine($"{saldo} - {numeroConta} - {ListaOperacoes}");
    }
public bool Igual(ContaBancaria outraConta){ //comparar objeto com outros 
    return numeroConta == outraConta.numeroConta; //sobreescrever o equals
}
public override bool Equals(object? obj)
{
        ContaBancaria outraConta = (ContaBancaria)obj!;
        return numeroConta == outraConta.numeroConta;
}
}
