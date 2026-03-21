namespace DesignPattern.Creational.FactoryMethod;

// Product interface. Concrete products should implement this interface and provide their implementation.
public interface IButton
{
    void Render();
    void OnClick();
}