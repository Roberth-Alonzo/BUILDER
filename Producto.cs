using System;
class Producto
{
    public string Marca {get; set;}

    public string Modelo {get; set;}

    public string Motor {get; set;}

    public string Color {get; set;}
    
    public int NumPuertas {get; set;}

    public void MostrarInfo()
    {
        Console.WriteLine("Marca: " + Marca);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Tipo de Motor: " + Motor);
        Console.WriteLine("Color: " + Color);
        Console.WriteLine("Número de Puertas: " + NumPuertas);
    }
}