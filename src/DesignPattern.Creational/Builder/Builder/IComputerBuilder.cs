namespace DesignPattern.Creational.Builder;

public interface IComputerBuilder
{
    void Reset();
    IComputerBuilder SetCPU(string? cpu);
    IComputerBuilder SetRAM(int ram);
    IComputerBuilder SetGPU(string? gpu);
    // Optional features for Laptop
    IComputerBuilder SetBatteryCapacity(int batteryCapacity);
    IComputerBuilder SetFullRotationHinge(bool hasFullRotationHinge);
    // Optional features for Desktop
    IComputerBuilder SetChassis(string? chassis);
    IComputer Build();
}