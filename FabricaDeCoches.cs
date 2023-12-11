class FabricaDeCoches
{
    private IConstructorProducto constructorProducto;

    public FabricaDeCoches (IConstructorProducto constructor)
    {
        this.constructorProducto = constructor;
    }
    
    public void ConstruirCoche()
    {
        constructorProducto.ConstruirComponenteMarca();
        constructorProducto.ConstruirComponenteModelo();
        constructorProducto.ConstruirComponenteMotor();
        constructorProducto.ConstruirComponenteColor();
        constructorProducto.ConstruirComponenteNumPuertas();
    }
}