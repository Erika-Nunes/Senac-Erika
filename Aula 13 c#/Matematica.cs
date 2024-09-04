class Matematica
{
    /*
    public static int num1  = 0;
    public static int num2  = 0;
    public static int soma = 0;
    public static int subtracao = 0;
    public static int multiplicacao = 0;
    public static int divisao = 0;

    public static void Somar( int num1, int num2){
        soma = num1 + num2;
        Console.WriteLine(soma);
    }

    public static void Subtrair( int num1, int num2){
        subtracao = num1 - num2;
        Console.WriteLine(subtracao);
    }
    public static void Multiplicar( int num1, int num2){
        multiplicacao = num1 * num2;
        Console.WriteLine(multiplicacao);
    }    
    public static void Dividir(int num1, int num2){
        if (num2 == 0)
        {
            Console.WriteLine("numero tem que ser maior que 0");
            return;
        }
        
        divisao = num1 / num2;
        Console.WriteLine(divisao);
    }   
    */
    /*
    //OR
    public static int Somar( int num1, int num2){
        return num1 + num2;
    }
    public static int Somar( int num1, int num2, int num3){ //Overload -- pode se usar duas funçõe scom mesmo nome contanto que possua variaveis diferentes  
        return num1 + num2 + num3;
    }
    public static int Subtrair( int num1, int num2){
        return num1 - num2;
    }
    public static int Multiplicar( int num1, int num2){
        return num1 * num2;
    }
    public static int Dividir( int num1, int num2){
        if (num2 == 0)
        {
            Console.WriteLine("Não é possivel fazer esse calculo");
            return -1;
        }
        
        return num1 / num2;
    }

*/
//Questão multiplicar 2

    public static int Somar( int num1, int num2){
        return num1 + num2;
    }
    public static int Somar( int num1, int num2, int num3){ //Overload -- pode se usar duas funçõe scom mesmo nome contanto que possua variaveis diferentes  
        return num1 + num2 + num3;
    }
    public static int Subtrair( int num1, int num2){
        return num1 - num2;
    }
    public static int Subtrair( int num1, int num2, int num3){
        return num1 - num2 - num3;
    }
    public static int Multiplicar( int num1, int num2){
        return num1 * num2 ;
    }
    public static int Multiplicar( int num1, int num2, int num3){
        return num1 * num2 * num3;
    }
    public static int Dividir( int num1, int num2){
        if (num2 == 0 )
        {
            Console.WriteLine("Não é possivel fazer esse calculo");
            return -1;
        }
        
        return num1 / num2;
    }
    public static int Dividir( int num1, int num2, int num3){
        if (num2 == 0 && num3 == 0)
        {
            Console.WriteLine("Não é possivel fazer esse calculo");
            return -1;
        }
        
        return num1 / num2 / num3;
    }








}