namespace DesignPattern.Creational.Builder;

public class DesktopBuilder : ComputerBuilderBase<Desktop, DesktopBuilder>
{
    public override IComputerBuilder SetChassis(string? chassis)
    {
        _product.Chassis = chassis;
        return this;
    }
}