using System.Reflection.Metadata.Ecma335;

class ContaBanco
{
    private double numero = 0.0;
    private double saldo = 0.0;
    //private double valor = 0.0;
    //pode-se usar dois construtores se tiverem parametros diferentes 
    public ContaBanco(double numero){
        this.numero = numero;
        saldo = 0.0;
    }
    public ContaBanco(double numero, double saldo){//,double valor){
        this.numero = numero;
        this.saldo = saldo;
       // this.valor = valor;
    }
    public double Getnumero(){ //ACESSAR O VALOR SEM PODER ATRIBUIR NADA FORA DA CLASSE
    return numero;
    }
    public double Getsaldo(){
    return saldo;
    }
    public void deposito(double valor){
        if(valor <= 0){
            Console.WriteLine("Valor tem que ser maior do que R$0,0");
            return;
        }
        saldo += valor;
        //return saldo;
    }
    public void saque(double valor){
        //saldo = saldo - valor - valor;
        //return saldo;
        if(valor <= 0){
            Console.WriteLine("Valor tem que ser maior do que R$0,0");
            return;
        }
        if (valor <= saldo){
            saldo -= valor;
            Console.WriteLine("Saque efetudo" +saldo);
        }
        else{
            Console.WriteLine("Saldo insuficiente");
        }

    }
    /*
    public void ImprimirDados(){
        
        Console.WriteLine($"Numero da conta: {numero} - saldo: {saldo} - deposito: {deposito} - Saque: {saque}");
        //Console.WriteLine("O nome é: " +nome+ " tem " +CalculoIdade+ " e sua altura é " +altura);
    }
    */
}