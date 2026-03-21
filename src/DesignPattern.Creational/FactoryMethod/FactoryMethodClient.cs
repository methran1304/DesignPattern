namespace DesignPattern.Creational.FactoryMethod;

/*
 * This example illustrates how the Factory Method can be
 * used for creating cross-platform UI elements without
 * coupling the client code to concrete UI classes.
 */

public enum OperatingSystem
{
    Windows,
    Linux,
    MacOs
}

public struct OsConfiguration
{
    public OperatingSystem TargetOs { get; set; }
}

/*
 * This is the client code that utilizes the factory method
 */
public class FactoryMethodClient
{
    private readonly OsConfiguration _config = new()
    {
        TargetOs = OperatingSystem.MacOs
    };

    private Dialog? _dialog;

    public void Initialize()
    {
        _dialog = GetDialog();
        _dialog.Render();
        var button = _dialog.CreateButton(); // client does not know what type of button is actually created
        button.Render();
        button.OnClick();
    }

    private Dialog GetDialog()
    {
        return _config.TargetOs switch
        {
            OperatingSystem.Windows => new WindowsDialog(),
            OperatingSystem.Linux or OperatingSystem.MacOs => new WebDialog(),
            _ => throw new Exception("Unknown target OS")
        };
    }
}