interface IConstructorProducto
{
    void ConstruirComponenteMarca();

    void ConstruirComponenteModelo();

    void ConstruirComponenteMotor();

    void ConstruirComponenteColor();

    void ConstruirComponenteNumPuertas();
    
    Producto ObtenerProductoFinal();
}