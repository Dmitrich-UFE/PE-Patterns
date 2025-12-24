namespace Proxy
{
    internal class Program
    {
        //Пример: проверка на премиум для доступа к базе данных
        static void Main(string[] args)
        {
            User user = new User(false);

            PremiumService service = new PremiumBase(new Content("супер видео"));
            PremiumService proxy = new PremiumProxy(service);

            Console.WriteLine("Проверка пользователя на премиум\n");

            Console.WriteLine("Пытаемся обойти прокси (не премиум пользователь)");
            service.GetPremiumContent(user);

            Console.WriteLine("\nНе пытаемся обойти прокси для проверки премиума (премиум пользователь)");
            proxy.GetPremiumContent(user);

            User premiumUser = new User(true);
            Console.WriteLine("\nПытаемся обойти прокси (не премиум пользователь)");
            service.GetPremiumContent(premiumUser);

            Console.WriteLine("\nНе пытаемся обойти прокси для проверки премиума (премиум пользователь)");
            proxy.GetPremiumContent(premiumUser);

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
