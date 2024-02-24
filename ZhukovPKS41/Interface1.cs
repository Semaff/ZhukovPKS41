Console.WriteLine(IMovable.MaxSpeed);   // 60
IMovable.MaxSpeed = 65;
Console.WriteLine(IMovable.MaxSpeed);   // 65
double time = IMovable.GetTime(500, 10);
Console.WriteLine(time);    // 50

interface IMovable
{
    public const int minSpeed = 0;     // минимальная скорость
    private static int maxSpeed = 60;   // максимальная скорость
    // находим время, за которое надо пройти расстояние distance со скоростью speed
    static double GetTime(double distance, double speed) => distance / speed;
    static int MaxSpeed
    {
        get => maxSpeed;
        set
        {
            if (value > 0) maxSpeed = value;
        }
    }
}
