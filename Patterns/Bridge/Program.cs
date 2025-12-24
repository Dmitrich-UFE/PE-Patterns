namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DishWasher dishWasher = new DishWasher();
            RemoteController remoteController = new RemoteController(dishWasher);
            Console.WriteLine("Идет управление посудомойкой");

            remoteController.SetPower(true);
            remoteController.Wash();
            remoteController.Fill();
            remoteController.Wash();

            ClothesWasher clothesWasher = new ClothesWasher();
            RemoteController remoteController2 = new RemoteController(clothesWasher);
            Console.WriteLine("\nИдет управление стиральной машиной");

            remoteController2.SetPower(true);
            remoteController2.Wash();
            remoteController2.Fill();
            remoteController2.Wash();

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
