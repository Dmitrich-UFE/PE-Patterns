namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMessage msg = new Message("fkjhbdfsbjkhfdkbjh");

            IMessage msg2 = msg.Clone();
            IMessage msg3 = new Message(msg2);
            Console.WriteLine("Создали сообщение msg. Скопировали его в msg2. msg2 скопировали в msg3");

            Console.WriteLine("Исходный msg занулили");
            msg = null;

            Console.WriteLine("\nПытаемся вывести msg2");
            Console.WriteLine(msg2.Text);

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
