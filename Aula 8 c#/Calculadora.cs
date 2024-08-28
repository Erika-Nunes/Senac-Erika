class Calculadora
{
    private int resultado ;
    public int Getresultado(){
        return resultado;
    }

    public void Somar(int numero) {
        resultado += numero;
    }

    public void Subtrair(int numero) {
        resultado -= numero;
    } 
}