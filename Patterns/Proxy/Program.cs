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

            service.GetPremiumContent(user);
            proxy.GetPremiumContent(user);

            User premiumUser = new User(true);
            service.GetPremiumContent(premiumUser);
            proxy.GetPremiumContent(premiumUser);
        }
    }
}
