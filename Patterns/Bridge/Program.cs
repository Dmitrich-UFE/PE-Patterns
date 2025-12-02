namespace Bridge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DishWasher dishWasher = new DishWasher();
            RemoteController remoteController = new RemoteController(dishWasher);

            remoteController.SetPower(true);
            remoteController.Wash();
            remoteController.Fill();
            remoteController.Wash();

            ClothesWasher clothesWasher = new ClothesWasher();
            RemoteController remoteController2 = new RemoteController(clothesWasher);

            remoteController2.SetPower(true);
            remoteController2.Wash();
            remoteController2.Fill();
            remoteController2.Wash();
        }
    }
}
