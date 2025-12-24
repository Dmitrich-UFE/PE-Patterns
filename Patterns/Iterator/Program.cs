using System.Security.Authentication;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IterableCollection itCollection = new ConcreteCollection();

            Iterator it = new ConcreteIterator(itCollection);

            itCollection.Add(2.4);
            itCollection.Add(2.9);
            itCollection.Add(-3.1);

            Console.WriteLine("Обходим итератором коллекцию");
            Console.WriteLine(it.getNext());
            Console.WriteLine(it.getNext());

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
