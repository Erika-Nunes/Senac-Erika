class Animal
{
    public virtual void Comer (){
        Console.WriteLine("Padrão - Comer");
    }
    public virtual void FazerBarulho (){
        Console.WriteLine("Padrão - Barulho");
    }
}

class Cachorro : Animal
{
    public override void Comer()
    {
        Console.WriteLine("Comer ração");
    }
    public override void FazerBarulho()
    {
        Console.WriteLine("auau");
    }
}
class Gato : Animal
{
    public override void Comer()
    {
        Console.WriteLine("Comer Excelense");
    }
    public override void FazerBarulho()
    {
        Console.WriteLine("miau");
    }
}
class Passaro : Animal
{
    public override void Comer()
    {
        Console.WriteLine("Comer alpiste");
    }
    public override void FazerBarulho()
    {
        Console.WriteLine("psiupsiu");
    }
}