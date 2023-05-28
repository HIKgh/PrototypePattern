using Application.Interfaces;

namespace Application.Implementations;

public class PassengerCar : Car, IMyCloneableCar<ICar>, ICloneable
{
    public PassengerCar(int id, string? name, int spaciousness) : base(id, name)
    {
        Spaciousness = spaciousness;
    }

    public int Spaciousness { get; set; }

    public void GetInfo()
    {
        Console.WriteLine($"Id:{Id}, Name:{Name}, Spaciousness:{Spaciousness}");
    }

    public IMyCloneableCar<ICar> Clone()
    {
        return new PassengerCar(Id, Name, Spaciousness);
    }

    object ICloneable.Clone()
    {
        return Clone();
    }
}