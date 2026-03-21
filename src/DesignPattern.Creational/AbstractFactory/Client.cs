namespace DesignPattern.Creational.AbstractFactory;

/*
 * This example illustrates how the Abstract Factory can be
 * used for creating furniture of specific type without
 * coupling the client code to concrete furniture classes.
 * Abstract factory is basically a factory of factories.
 * Concrete factories should implement IFactory,
 * these concrete factories can create concrete products which implement IProduct
 * Based on this pattern, client code only has to interact with interfaces of products and factories
 */
public class AbstractFactoryClient
{
    private IFurnitureFactory? FurnitureFactory { get; set; }

    public void Initialize()
    {
        FurnitureFactory = CreateFactory<ModernFurnitureFactory>();
        CreateFurniture();
    }

    private static TFactory CreateFactory<TFactory>() where TFactory : IFurnitureFactory, new()
    {
        return new TFactory();
    }

    private void CreateFurniture()
    {
        if (FurnitureFactory is null) return;

        var chair = FurnitureFactory.CreateChair();
        chair.SitOn();

        var sofa = FurnitureFactory.CreateSofa();
        sofa.SitOn();
    }
}