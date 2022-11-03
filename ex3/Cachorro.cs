public class Cachorro : Mamiferos
{
    public Cachorro()
    {
        base.SetNome("Cachorro");
        base.SetAlimentacao(3);
        base.SetLocomocao("andando");
        this.Patas = 4;
    }

    public void Rosnar()
    {
        Console.WriteLine($"{base.GetNome}: grrrr!!!!!");
    }
}