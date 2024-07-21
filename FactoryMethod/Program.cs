ClientCode(new ConcreteCreatorA());
ClientCode(new ConcreteCreatorB());

void ClientCode(Creator creator)
{
    IProduct product = creator.CreateProduct();
    product.doStuff();
}
