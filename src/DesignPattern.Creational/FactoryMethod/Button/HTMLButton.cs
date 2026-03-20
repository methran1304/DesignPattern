namespace DesignPattern.DesignPattern.Creational.FactoryMethod.Button;

public class HtmlButton : IButton
{
    public void Render()
    {
        Console.WriteLine("HTMLButton: Render()");
    }

    public void OnClick()
    {
        Console.WriteLine("HTMLButton: OnClick()");
    }
}