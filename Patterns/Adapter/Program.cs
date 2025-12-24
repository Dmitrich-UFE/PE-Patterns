namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EuroFork euroFork = new EuroFork();
            ChinaFork chinaFork = new ChinaFork();
            ChinaSocket chinaSocket = new ChinaSocket();

            EuroToChinaAdapter euroToChina = new EuroToChinaAdapter(euroFork);

            //chinaSocket.Connect(euroFork);
            chinaSocket.Connect(euroToChina);

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);

        }
    }
}
