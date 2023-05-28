using Application.Interfaces;

namespace Application.Implementations;

public class Hatchback : PassengerCar, IMyCloneableCar<ICar>, ICloneable
{
    public Hatchback(int id, string? name, int spaciousness) : base(id, name, spaciousness)
    {
    }

    public new void GetInfo()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Spaciousness:{Spaciousness}");
    }

    public new IMyCloneableCar<ICar> Clone()
    {
        return new Hatchback(Id, Name, Spaciousness);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}