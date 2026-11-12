using System;
namespace DroneInheritance;

class Program
{
    static void Main()
    {
        ReconDrone orlan = new ReconDrone("Орлан-10", "СТЦ", 150, 600, 16, 18, 24, 5000);
        AttackDrone forpost = new AttackDrone("Форпост-Р", "УЗГА", 200, 250, 18, 500, 100, "бронетехника");

        TransportDrone koshchey = new TransportDrone("Кощей", "Авирон", 80, 250, 6, 500, 320, "медицинский");

        LoiteringMunition lancet = new LoiteringMunition("Ланцет", "ZALA", 110, 40, 0.7, 12, 3, "артиллерия", 40, "оптико-электронное");

        AttackReconDrone orion = new AttackReconDrone("Орион", "Кронштадт", 200, 250, 30, 1150, 60, 7000, "крылатая ракета", 4);

        Console.WriteLine("=== Проверка уникальных методов ===");
        orlan.PerformReconnaissance();
        forpost.PerformStrike();
        koshchey.DeliverCargo();
        lancet.LoiterAndStrike();
        orion.PerformReconAndStrike();

        Drone[] dronesFleet = new Drone[]
        {
        orlan,
        forpost,
        koshchey,
        lancet,
        orion
        };

        Console.WriteLine("\n=== Сводная информация (массив Drone[]) ===");
        foreach (Drone drone in dronesFleet)
        {
            Console.WriteLine(drone.GetInfo());
        }
    }
}