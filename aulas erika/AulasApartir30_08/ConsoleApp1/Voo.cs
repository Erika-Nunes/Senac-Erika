class Voo
{
    public int Numero {get; private set;}
    public Data Data {get;set;}
    public DateTime Date {get;set;}
    //True = ocupado, false = disponivel
    public bool[] vetorAssentos {get; private set;}

    public Voo(int numero, Data data ){
        Numero = numero;
        Data = data;
        vetorAssentos = new bool[40];
        Date = new DateTime(data.Ano, data.Mes, data.Dia);
    }
    public bool IsAssentosDisponivel(int posicao){
        if (posicao < 0 || posicao >= vetorAssentos.Length)
        {
            Console.WriteLine("Erro: Assento invalido");
            return false;
        }
        
        return !vetorAssentos[posicao];

    }
    public int ProximoAssentoDisponivel(){
        for (int i = 0; i < etorAssentos.Length; i++)
        {
            if (!vetorAssentos[i])
            {
                return i;
            }
        }
        
        return -1;
    }
     public int QntdAssentosDisponiveis(){
        int contador = 0;
        foreach (var assento in vetorAssentos)
        {
            if (!assento)
            {
                contador++;
            }
        }
        
        return contador;
    }
    public void ReservarAssento(int posicao){
        if (posicao < 0 || posicao>= vetorAssentos.Length)
        {
            Console.WriteLine("Erro: Assento invalido");
            return ;
        }
        if(vetorAssentos[posicao]){
            Console.WriteLine("Assento já ocupado");
            return;
        }
        vetorAssentos[posicao] = true;
    }
    public void ImprimirStatus(){
        Data hoje = new Data(9, 9, 2024);
        DateTime today = new DateTime(2024, 9, 9);
        int resultado = Data.Comparar(hoje);
        int result = Date.CompareTo(today);


        if (resultado == 1){ //pode trocar resultado por -- result
            Console.WriteLine("O voo ainda vai acontecer");
        } else if(resultado == -1){
            Console.WriteLine("O voo já decolou");
        } else{
            Console.WriteLine("O voo é hoje");
        }
    }
}   
    