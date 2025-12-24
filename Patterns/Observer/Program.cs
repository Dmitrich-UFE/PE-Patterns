namespace Observer
{
    internal class Program
    {
        //реакция на новые сообщения
        static void Main(string[] args)
        {
            Console.WriteLine("\nПодписчики реагируют на изменение свойства \"Hour\"");
            Publisher publisher = new Publisher();

            ISubscriber msgSub = new MessageCountSubscriber();
            ISubscriber msgSub2 = new MessageCountSubscriber();

            publisher.AddSubscriber(msgSub);
            publisher.AddSubscriber(msgSub2);

            publisher.Hour = 1;

            publisher.Hour = 0;

            Thread.Sleep(1000);

            publisher.Hour = 2;

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
