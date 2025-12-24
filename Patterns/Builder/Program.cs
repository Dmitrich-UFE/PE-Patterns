namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();

            PCBuilder pcbuilder = new PCBuilder();
            LaptopBuilder laptopbuilder = new LaptopBuilder();

            director.ConstructComputer(pcbuilder);
            director.ConstructComputer(laptopbuilder);

            PC strongPC = pcbuilder.getResult();
            Laptop weakLaptop = laptopbuilder.getResult();

            Console.WriteLine("laptopbuilder собрал слабый ноутбук:");
            Console.WriteLine(weakLaptop.ToString());


            Console.WriteLine("pcbuilder собрал мощный ПК:");
            Console.WriteLine(strongPC.ToString());

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
