namespace DesignPattern.DesignPattern.Creational.FactoryMethod.Button;

public class HtmlButton : IButton
{
    public void Render()
    {
        Console.WriteLine($"{this.GetType().Name}: Render()");
    }

    public void OnClick()
    {
        Console.WriteLine($"{this.GetType().Name}: OnClick()");
    }
}