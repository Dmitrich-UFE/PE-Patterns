namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            Banana banana = shop.GetBanana();
        }
    }
}
