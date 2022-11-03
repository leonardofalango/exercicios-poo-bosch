public abstract class Animal
{
    private string? nomeAnimal;
    private string? tipoLocomocao;
    private string? alimentacao;
    public virtual void Locomover(int distancia)
    {
        for (int i = 0; i < distancia; i++)
            Console.WriteLine($"{nomeAnimal} {tipoLocomocao}");
    }


    // Getter e setter feito a mão
    public string GetNome() => nomeAnimal;
    public void SetNome(string nome)
    {
        this.nomeAnimal = nome;
    }

    public string GetLocomocao() => tipoLocomocao;
    public void SetLocomocao(string locomocao)
    {
        this.tipoLocomocao = locomocao;
    }

    public string GetAlimentacao() => alimentacao;
    public void SetAlimentacao(int tipoAlimentacao)
    {
        if (tipoAlimentacao == 1)
            this.alimentacao = "Carnivoro";
        else if (tipoAlimentacao == 2)
            this.alimentacao = "Herbivoro";
        else if (tipoAlimentacao == 3)
            this.alimentacao = "Onivoro";
        else
            return;
    }
}