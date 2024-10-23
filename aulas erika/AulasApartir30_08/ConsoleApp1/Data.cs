//class Data
//{
/*
//properties - não é o mesmo que varivael (lenght, count)
public int Dia {get;set;}
private int dia = 0;
private int mes = 0;
private int ano = 0;

public Data(int dia,int mes,int ano){
    this.dia = dia;
    this.mes = mes;
    this.ano = ano;

}
public Data(){

}
public int GetDia(){
    return dia;
}
public int SetDia(){
    return dia;
}
public int GetMes(){
    return mes;
}
public int SetMes(){
    return mes;
}
public int GetAno(){ //pegar
    return ano;
}
public int SetAno(){ //navegar
    return ano;
}

public void NomeMes(int mes){
    //private List<Data> data = new List<Data>();
    switch (mes)
    {
        case 1:
            Console.WriteLine("Janeiro");
            break;
        case 2:
            Console.WriteLine("Fevereiro");
            break;
        case 3:
            Console.WriteLine("Março");
            break;
        case 4:
            Console.WriteLine("Abril");
            break;

        case 5:
            Console.WriteLine("Maio");
            break;
        case 6:
            Console.WriteLine("Junho");
            break;
        case 7:
            Console.WriteLine("Julho");
            break;
        case 8:
            Console.WriteLine("Agosto");
            break;
        case 9:
            Console.WriteLine("Setembro");
            break;
        case 10:
            Console.WriteLine("Outubro");
            break;
        case 11:
            Console.WriteLine("Novembro");
            break;
        case 12:
            Console.WriteLine("Dezembro");
            break;
        default:

    }

}

public void AnoBissexto(int bissexto){

    if (DateTime.IsLeapYear(ano)){
        bissexto = ano;
        Console.WriteLine($"{bissexto} é Bissexto");
    }
}

public Data Clonar( ){
    return new Data(dia,mes,ano); 

}

public void comparacao(){

}

}
*/
using System.IO.Pipes;

class Data
{
    
    private int Dia {get; set;} 
    private int Mes {get; set;}
    private int Ano {get; set;}

    public Datas(){
        Dia = 1;
        Mes = 1;
        Ano = 1;
    }
    public Data(int dia,int mes,int ano){
        Dia = dia;
        Mes = mes;
        Ano = ano;
    
    }
    public string NomeMes{

        switch (Mes){
            case 1:
                return "Janeiro";
                break;
            case 2:
               return "Fevereiro";
                break;
            case 3:
               return "Março";
                break;
            case 4:
                return "Abril";
                break;

            case 5:
                return "Maio";
                break;
            case 6:
                return "Junho";
                break;
            case 7:
                return "Julho";
                break;
            case 8:
                return "Agosto";
                break;
            case 9:
                return "Setembro";
                break;
            case 10:
                return "Outubro";
                break;
            case 11:
                return "Novembro";
                break;
            case 12:
               return "Dezembro";
                break;
            //default:
            
        }
}
    public bool Bissexto(){
        return (Ano % 4 == 0 && Ano % 100 !=) || (Ano % 400 == 0);
    }
    public Data clonar(){
        return new Datas(Dia, Mes, Ano);
    }
    public int comparar(Data outraData){
        if (Ano > outraData.Ano)
        {
            return 1;
        }else if(Ano < outraData.Ano){
            return -1;
        }
        if (Mes > outraData.Mes)
        {
            return 1;
        }else if(Mes < outraData.Mes){
            return -1;
        }
        if (Dia > outraData.Dia)
        {
            return 1;
        }else if(Dia < outraData.Dia){
            return -1;
        }
        return 0;
    }
    public string DataFormatada(){
        return $"{Dia} de {NomeMes()} de {Ano}";
    }

}
