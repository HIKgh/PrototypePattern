using Application.Interfaces;

namespace Application.Implementations;

public class Track : CargoCar, IMyCloneableCar<ICar>, ICloneable
{
    public Track(int id, string? name, int capacity) : base(id, name, capacity)
    {
    }

    public new void GetInfo()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Capacity:{Capacity}");
    }

    public new IMyCloneableCar<ICar> Clone()
    {
        return new Track(Id, Name, Capacity);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}