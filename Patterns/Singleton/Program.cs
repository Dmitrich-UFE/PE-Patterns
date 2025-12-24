namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DayLightHandler dayLightHandler = DayLightHandler.getInstance();

            //можно менять dayTime откуда угодно

            Console.WriteLine("\nМеняем время дня у единственного обработчика дня и ночи(в играх)");
            dayLightHandler.dayTime = DayLightHandler.DayTime.Evening;
            dayLightHandler.dayTime = DayLightHandler.DayTime.Noon;

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
