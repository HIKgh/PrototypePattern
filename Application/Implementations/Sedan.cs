using Application.Interfaces;

namespace Application.Implementations;

public class Sedan : PassengerCar, IMyCloneableCar<ICar>, ICloneable
{
    public Sedan(int id, string? name, int spaciousness) : base(id, name, spaciousness)
    {
    }

    public new void GetInfo()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Spaciousness:{Spaciousness}");
    }

    public new IMyCloneableCar<ICar> Clone()
    {
        return new Sedan(Id, Name, Spaciousness);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}