using DesignPattern.Creational.Builder;

public class BuilderClient
{
    public void Initialize()
    {
        // Using LaptopBuilder (inherits from ComputerBuilderBase)
        IComputerBuilder laptopBuilder = new LaptopBuilder();
        var laptop = laptopBuilder
            .SetCPU("Intel i5")
            .SetGPU("Nvidia RTX 3060")
            .SetRAM(16)
            .SetBatteryCapacity(12)
            .SetFullRotationHinge(true)
            .Build();
        laptop.DisplaySpecification();

        // Using DesktopBuilder (inherits from ComputerBuilderBase)
        IComputerBuilder desktopBuilder = new DesktopBuilder();
        var desktop = desktopBuilder
            .SetCPU("AMD Ryzen 7")
            .SetGPU("Nvidia RTX 4080")
            .SetRAM(32)
            .SetChassis("Full Tower")
            .Build();
        desktop.DisplaySpecification();
    }
}