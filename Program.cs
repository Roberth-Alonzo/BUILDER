using System.ComponentModel.DataAnnotations;

internal class Program
{
    private static void Main(string[] args)
    {
       IConstructorProducto construccionCoche = new ConstructorCoche();
       FabricaDeCoches fabricaDeCoches = new FabricaDeCoches(construccionCoche);

       fabricaDeCoches.ConstruirCoche();
       Producto Coche = construccionCoche.ObtenerProductoFinal();

       Console.WriteLine("---------------------------------------------------");
       Console.WriteLine("Información del Coche:");
       Coche.MostrarInfo();
       Console.WriteLine("---------------------------------------------------");
    }
}