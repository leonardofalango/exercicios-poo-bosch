using System;
public class Time
{    
    public string NomeCompleto { get; set; }
    public string Apelido { get; set; }
    public byte[] Brasao { get; set; }
    public List<Jogador> Jogadores { get; set; }
    public Jogador[] Relacionados { get; set; }

    public Time(string nome, string apelido, byte[] fotoBrasao, List<Jogador> jogadores)
    {
        this.NomeCompleto = nome;
        this.Apelido = apelido;
        this.Brasao = fotoBrasao;
        this.Jogadores = jogadores;
    }

    public void Play(Time timeContra)
    {
        for (int i = 0; i < 11; i++)
        {
            this.Jogadores[i].Play();
            timeContra.Jogadores[i].Play();
        }
    }

    public void Plantel()
    {
        for (int i = 0; i < Jogadores.Count; i++)
        {
            Console.Write($"{this.Jogadores[i].Qualidade} {this.Jogadores[i].Posicao}: {this.Jogadores[i].Numero} - ");
            Console.Write($"{this.Jogadores[i].Nome} - {this.Jogadores[i].DataNascimento} - ");
            if (!this.Jogadores[i].IsSus())
                Console.WriteLine($"CONDIÇÃO: TÁ PRA JOGO");
            else
                Console.WriteLine($"CONDIÇÃO: SUSPENSO");
        }
    }

    public void Escalacao()
    {
        for (int i = 0; i < 11; i++)
        {
            Console.Write($"{this.Relacionados[i].Qualidade} {this.Relacionados[i].Posicao}: {this.Relacionados[i].Numero} - ");
            Console.Write($"{this.Relacionados[i].Nome} - {this.Relacionados[i].DataNascimento} - ");
            if (!this.Relacionados[i].IsSus())
                Console.WriteLine($"CONDIÇÃO: TÁ PRA JOGO");
            else
                Console.WriteLine($"CONDIÇÃO: SUSPENSO");
        }
    }

    public static Time makeTime(string[] lines, string nome)
    {
        List<Jogador> jogadores = new List<Jogador>();
        Random rand = new Random();
        int idJogador = 0;
        foreach (var linha in lines)
        {
            string nomeJogador = linha.Substring(0, linha.IndexOf("|"));
            int numero = int.Parse(linha.Substring(linha.IndexOf("|") + 1));
            int qualidade = (int) rand.NextInt64(100);
            string apelido = nomeJogador.Substring(3);
            DateTime dataNascimento = new DateTime();
            
            string posicao;
            if (numero == 1)
                posicao = "GOLEIRO";
            else if (numero == 2)
                posicao = "LATERAL-DIREITO";
            else if (numero == 3 || numero == 4)
                posicao = "ZAGUEIRO";
            else if (numero == 6)
                posicao = "LATERAL-ESQUERDO";
            else if (numero == 5 || numero == 8)
                posicao = "VOLANTE";
            else if (numero == 7)
                posicao = "PONTA-DIREITA";
            else if (numero == 10)
                posicao = "MEIA-ARMADOR";
            else if (numero == 11)
                posicao = "PONTA-ESQUERDA";
            else if (numero == 9)
                posicao = "ATACANTE";
            else
            {
                Console.WriteLine("Posição não reconhecida: ");
                Console.Write(nomeJogador);
                Console.Write(": " + numero);
                Console.Write("\nEscreva a posição: ");
                posicao = Console.ReadLine();
                posicao = "RESERVA";
            }

            Console.WriteLine("Deseja escolher a data de nascimento do jogador?");
            char resp = Console.ReadKey(true).KeyChar;
            if (resp == 's')
            {
                string ParseData = Console.ReadLine();
                int ano = int.Parse(ParseData.Substring(4));
                int mes = int.Parse(ParseData.Substring(4, 2));
                int dia = int.Parse(ParseData.Substring(6, 2));
                dataNascimento = new DateTime(ano, mes, dia);
            }
            else
                dataNascimento = new DateTime(1995,01,15);
            
            Jogador jogador = new Jogador
            (
                idJogador,
                nomeJogador,
                apelido,
                dataNascimento,
                numero,
                posicao,
                qualidade
            );

            jogadores.Add(jogador);
            idJogador++;
            Console.WriteLine("\n");

        }
        Time time = new Time
        (
            nome, 
            nome.Substring(3),
            new byte[12],
            jogadores
        );
        
        return time;
    }

    public void RelacionarJogadores()
    {
        this.Relacionados = new Jogador[11];
        for (int i=0; i<this.Jogadores.Count - 1; i++)
        {
            for (int j=0; j<this.Jogadores.Count; j++)
            {
                if (Jogadores[i].Qualidade > Jogadores[j].Qualidade)
                {
                    var aux = Jogadores[j];
                    Jogadores[j] = Jogadores[i];
                    Jogadores[i] = aux;
                }
            }
        }
        for (int i = 0; i < 11; i++)
            this.Relacionados[i] = this.Jogadores[i];
    }
}