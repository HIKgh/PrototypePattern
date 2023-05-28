using Application.Interfaces;

namespace Application.Implementations;

public class PrototypePatternService : IPrototypePatternService
{
    public void Process()
    {
        Console.Clear();
        Console.WriteLine("Демонстрация работы паттерна Прототип");

        Show(new PassengerCar(1, "Пассажирский автомобиль", 2));
        Show(new Sedan(2, "Пассажирский автомобиль", 5));
        Show(new Hatchback(3, "Хэтчбэк", 5));
        Show(new CargoCar(4, "Грузовой автомобиль", 2000));
        Show(new Track(5, "Трак", 10000));
        Show(new Gazelle(6, "Газель", 3500));

        Console.WriteLine();
        Console.WriteLine("Демонстрация работы паттерна Прототип завершена. Нажмите любую клавишу...");
        Console.ReadKey();
    }

    private void Show(ICar car)
    {
        var myCloneableCar = car as IMyCloneableCar<ICar>;
        Console.WriteLine();
        myCloneableCar?.GetInfo() ;
        Console.WriteLine("Клонируем паттерном Прототип");
        myCloneableCar?.Clone().GetInfo();
        Console.WriteLine("Клонируем ICloneable");
        ((car as ICloneable)!.Clone() as IMyCloneableCar<ICar>)?.GetInfo();
    }
}