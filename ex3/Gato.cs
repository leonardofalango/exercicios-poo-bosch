public class Gato : Mamiferos
{
    public Gato()
    {
        base.SetNome("Gato");
        base.SetLocomocao("pulando");
        base.SetAlimentacao(1);
        base.Patas = 4;
    }

    public void Miar()
    {
        Console.WriteLine($"{this.GetNome}: miauuuu!!!");
    }
}