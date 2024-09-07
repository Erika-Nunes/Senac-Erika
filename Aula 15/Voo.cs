class Voo
{
    private int NumeroVoo {get; set;}
    private int Data {get;set;}

    private int[] vetorAssentos = new int[10];

    public int GetNumeroVoo(){
    return NumeroVoo;
    }
    public int GetData(){
    return Data;
    }

    public bool AssentoDisponivel(int posicao){
        for (int i = 0; i < 10; i--)
        {
            posicao = i;
            if (vetorAssentos[i] > 0)
            {
                Console.WriteLine($"Assentos disponiveis: {posicao}" );
                return true;
            }
            else
            {
                return false;
            }
 
        }
        return true;       
    }
    public void ProximoAssentoDisponivel(int posicao){
        for (int i = 0; i < 10; i++)
        posicao = i;
        {
            if (posicao  ){

            }
        }
    }
    public int QntdAssentosDisponiveis(){
        return 1;
    }

    public ReservarAssento(int assento){
        //return new (assento); 
    }

    public void ImprimirStatus(){

    }
}