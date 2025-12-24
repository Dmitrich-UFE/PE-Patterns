namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Context context = new Context(new IdleState());

            context.Move();
            context.Stop();

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
