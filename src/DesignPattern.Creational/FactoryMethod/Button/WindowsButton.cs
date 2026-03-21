namespace DesignPattern.Creational.FactoryMethod;

public class WindowsButton : IButton
{
    public void Render()
    {
        Console.WriteLine($"{GetType().Name}: Render()");
    }

    public void OnClick()
    {
        Console.WriteLine($"{GetType().Name}: OnClick()");
    }
}