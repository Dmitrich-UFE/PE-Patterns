namespace Template_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject monster = new GameObject();

            Console.WriteLine("Атакует слизень");
            monster.Do(new SlimeAI());

            Console.WriteLine("\nАтакует скелет");
            monster.Do(new SkeletonAI());

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }
    }
}
