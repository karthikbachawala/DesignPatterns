abstract class Creator
{
    public void SomeOperation()
    {
        IProduct product = CreateProduct();
        product.doStuff();
    }

    public abstract IProduct CreateProduct();
}
