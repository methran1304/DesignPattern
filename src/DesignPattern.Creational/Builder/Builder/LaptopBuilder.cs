namespace DesignPattern.Creational.Builder;

public class LaptopBuilder : ComputerBuilderBase<Laptop, LaptopBuilder>
{
    public override IComputerBuilder SetBatteryCapacity(int batteryCapacity)
    {
        _product.BatteryCapacity = batteryCapacity;
        return this;
    }

    public override IComputerBuilder SetFullRotationHinge(bool hasFullRotationHinge)
    {
        _product.HasFullRotationHinge = hasFullRotationHinge;
        return this;
    }
}