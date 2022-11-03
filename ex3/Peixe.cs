public class Peixe : Animal
{
    // 2 Características únicas da classe
    private int escamas;
    public int Escamas
    {
        get { return escamas; }
        set { escamas = value; }
    }
    private string nadadeira;
    public string Nadadeira
    {
        get { return nadadeira; }
        set { nadadeira = value; }
    }
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-


    
    public Peixe PeixePerto { get; set; } = null;
    public int QuantCardume()
    {
        int quant = 0;
        var crr = this;
        while (crr.PeixePerto != null)
        {
            quant++;
            crr = crr.PeixePerto;
        }
        return quant;
    }

    public Peixe(Peixe peixe)
    {
        base.SetAlimentacao(2);
        base.SetNome("Peixe");
        base.SetLocomocao("nadando");
        this.PeixePerto = peixe;
    }
}