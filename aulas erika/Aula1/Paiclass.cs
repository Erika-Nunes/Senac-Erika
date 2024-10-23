
class Mae{
    public bool atributoMaeBool = false;
}
class Pai : Mae {
    public string atributoPaiString = " ";
    protected int atributoPaiInt = 0; //só quando terá uma classe filho usa o protect
    private char atributoPaiChar = ' ';
}


class Filho : Pai
{
 void test(){
    atributoPaiString = "";
    atributoPaiInt = 0;
    atributoMaeBool = true;

 }
}
    
