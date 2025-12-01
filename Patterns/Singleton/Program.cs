namespace Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            DayLightHandler dayLightHandler = DayLightHandler.getInstance();

            //можно менять dayTime откуда угодно
            dayLightHandler.dayTime = DayLightHandler.DayTime.Evening;
            dayLightHandler.dayTime = DayLightHandler.DayTime.Noon;
        }
    }
}
