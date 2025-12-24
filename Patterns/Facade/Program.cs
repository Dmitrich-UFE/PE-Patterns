namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();

            Console.WriteLine("Покупка банана");
            Banana banana = shop.GetBanana();

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
