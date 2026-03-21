namespace DesignPattern.Creational.FactoryMethod;

public class HtmlButton : IButton
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