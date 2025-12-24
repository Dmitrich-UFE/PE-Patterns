namespace Abstract_Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер завода: 0 или 1");
            int num = Convert.ToInt32(Console.ReadLine());

            Factory factory = FactoryInitializator.GetFactory(num);

            Bag myBag = factory.CreateBag();
            Shirt myShirt = factory.CreateShirt();

            myBag.Zip();
            myShirt.Wear();

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }

    internal class FactoryInitializator 
    {
        internal static Factory GetFactory(int i) 
        {
            switch (i) 
            {
                case 0: return new FactoryESS();
                case 1: return new FactoryBelarusTextile();
                default: throw new ArgumentException("Для этого номера нет завода");
            
            }
        }
    }
}
