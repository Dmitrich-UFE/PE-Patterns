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

            Console.WriteLine(weakLaptop.ToString());
            Console.WriteLine(strongPC.ToString());
        }
    }
}
