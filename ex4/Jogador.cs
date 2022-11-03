using System;
public class Jogador
{
    public int Id { get; private set; }
    public string Nome { get; private set; }
    public string Apelido { get; private set; }
    public DateTime DataNascimento { get; private set; }
    public int Numero { get; set; }
    public string Posicao { get; set; }
    private int quali;
    public int Qualidade 
    {
        get { return this.quali; }
        set
        {
            this.quali = value;
            if (this.quali > 100)
                this.quali = 100;
            else if (this.quali < 0)
                this.quali = 0;                
        }
    }
    private int cart;
    public int Cartoes // O exercício ja pede um metodo para aplicar cartões, mas não precisa por conta do set
    {
        get { return this.cart; }
        set
        {
            if (this.cart >= 3)
                this.Suspenso = true;
            this.cart = value;
        }
    }
    public bool Suspenso { get; set; }
    private Random rand = new Random();
    private bool isTreinado = false;

    public Jogador
    (
        int id,
        string nome,
        string apelido,
        DateTime dataNascimento,
        int numeroCamisa,
        string posicao,
        int qualidade,
        int cartoes = 0,
        bool suspenso = false)
    {
        this.Id = id;
        this.Nome = nome;
        this.Apelido = apelido;
        this.DataNascimento = dataNascimento;
        this.Numero = numeroCamisa;
        this.Posicao = posicao;
        this.Qualidade = qualidade;
        this.Cartoes = cartoes;
        this.Suspenso = suspenso;
    }
    public Jogador
    (
        int id, string nome, string apelido, DateTime dataNascimento 
    )
    {
        this.Id = id;
        this.Nome = nome;
        this.Apelido = apelido;
        this.DataNascimento = dataNascimento;
    }
    
    public bool IsSus() => this.Suspenso;

    public void AplicarCartao(int quantidade)
    {
        Cartoes += quantidade;
    }

    public void CumprirSuspencao()
    {
        Cartoes = 0;
        Suspenso = false;
    }

    public void SofrerLesao()
    {
        int num = (int) rand.NextInt64(100);
        if (num <= 5)
            this.Qualidade = (int) (this.Qualidade - (this.Qualidade * 0.15));
        else if (num <= 10)
            this.Qualidade = (int) (this.Qualidade - (this.Qualidade * 0.10));
        else if (num <= 15)
            this.Qualidade = (int) (this.Qualidade - (this.Qualidade * 0.05));
        else if (num <= 30)
            this.Qualidade -= 2;
        else
            this.Qualidade -= 1;
    }

    public void ExecutarTreinamento()
    {
        if (isTreinado)
            return;

        int num = (int) rand.NextInt64(100);

        if (num <= 5)
            this.Qualidade += 5;
        else if (num <= 10)
            this.Qualidade += 4;
        else if (num <= 15)
            this.Qualidade += 3;
        else if (num <= 30)
            this.Qualidade += 2;
        else
            this.Qualidade += 1;
        
        this.isTreinado = true;
    }

    public void Play() => this.isTreinado = false;

}