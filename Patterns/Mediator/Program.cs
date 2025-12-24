namespace Mediator
{
    internal class Program
    {
        //Окно анкеты
        static void Main(string[] args)
        {
            IMediator mediator = new Mediator();
            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
