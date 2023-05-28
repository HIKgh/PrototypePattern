using Application.Interfaces;

namespace Application.Implementations;

public class CargoCar : Car, IMyCloneableCar<ICar>, ICloneable
{
    public int Capacity { get; }

    public CargoCar(int id, string? name, int capacity) : base(id, name)
    {
        Capacity = capacity;
    }

    public void GetInfo()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Capacity:{Capacity}");
    }

    public IMyCloneableCar<ICar> Clone()
    {
        return new CargoCar(Id, Name, Capacity);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}