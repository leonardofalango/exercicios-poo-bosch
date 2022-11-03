using System;
public class Quadrilatero
{
    public double Altura { get; set; }
    public double Base { get; set; }
    public double Area { get; private set; }
    private bool isSet = false;

    public Quadrilatero(double alt, double largura)
    {
        this.Altura = alt;
        this.Base = largura;
    }

    public void PrintArea()
    {
        if (!isSet)
        {
            this.Area = this.Altura * this.Base;
            this.isSet = true;
        }
        Console.WriteLine($"Area: {this.Area}");
    }

    public void Print()
    {
        if (!isSet)
        {
            this.Area = this.Altura * this.Base;
            this.isSet = true;
        }
        Console.WriteLine($"Altura: {this.Altura}");
        Console.WriteLine($"Largura: {this.Base}");
        this.PrintArea();
    }
}