public abstract class Mamiferos : Animal
{
    // 2 Características privadas únicas com métodos get/set
    private string pelo;
    public string Pelo
    {
        get { return pelo; }
        set { pelo = value; }
    }

    private string mama;
    public string Mama
    {
        get { return mama; }
        set { mama = value; }
    }

    private int quantPatas;
    public int Patas
    {
        get { return quantPatas; }
        set { quantPatas = value; }
    }
    
    
    
}