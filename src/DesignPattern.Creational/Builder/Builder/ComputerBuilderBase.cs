namespace DesignPattern.Creational.Builder;

public abstract class ComputerBuilderBase<TProduct, TBuilder> : IComputerBuilder
    where TProduct : IComputer, new()
    where TBuilder : ComputerBuilderBase<TProduct, TBuilder>
{
    protected TProduct _product = new();

    public virtual void Reset()
    {
        _product = new TProduct();
    }

    public virtual IComputerBuilder SetCPU(string? cpu)
    {
        _product.CPU = cpu;
        return this;
    }

    public virtual IComputerBuilder SetRAM(int ram)
    {
        _product.RAM = ram;
        return this;
    }

    public virtual IComputerBuilder SetGPU(string? gpu)
    {
        _product.GPU = gpu;
        return this;
    }

    public virtual IComputerBuilder SetBatteryCapacity(int batteryCapacity)
    {
        // No-op by default
        return this;
    }

    public virtual IComputerBuilder SetFullRotationHinge(bool hasFullRotationHinge)
    {
        // No-op by default
        return this;
    }

    public virtual IComputerBuilder SetChassis(string? chassis)
    {
        // No-op by default
        return this;
    }

    public virtual IComputer Build()
    {
        return _product;
    }
}
