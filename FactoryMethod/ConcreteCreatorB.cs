
class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}
