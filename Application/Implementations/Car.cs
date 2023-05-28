using Application.Interfaces;

namespace Application.Implementations;

public abstract class Car : ICar
{
    protected Car(int id, string? name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; set; }

    public string? Name { get; set; }
}