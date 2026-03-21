namespace DesignPattern.Creational.AbstractFactory;

/*
 * This is the interface that return products of specific kind
 */
public interface IFurnitureFactory
{
    public IChair CreateChair();
    public ISofa CreateSofa();
}