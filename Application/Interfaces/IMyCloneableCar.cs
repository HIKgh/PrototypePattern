namespace Application.Interfaces;

public interface IMyCloneableCar<T> where T : ICar
{
    public IMyCloneableCar<T> Clone();

    public void GetInfo();
}