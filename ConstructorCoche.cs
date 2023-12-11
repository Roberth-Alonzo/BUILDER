class ConstructorCoche : IConstructorProducto
{
    private Producto coche = new Producto();

    public void ConstruirComponenteMarca()
    {
        coche.Marca = "Jeep";
    }

    public void ConstruirComponenteModelo()
    {
        coche.Modelo = "Wrangerl";
    }

    public void ConstruirComponenteMotor()
    {
        coche.Motor = "V6 3.6 Pentastar";
    }

    public void ConstruirComponenteColor()
    {
        coche.Color = "Rojo";
    }

    public void ConstruirComponenteNumPuertas()
    {
        coche.NumPuertas = 5;
    }
    
    public Producto ObtenerProductoFinal()
    {
        return coche;
    }
}
