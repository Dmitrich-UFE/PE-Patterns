namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Стратегия подмены ходьбы и бега игрока в движке");
            Console.WriteLine("Жмите E для смены стратегии, WASD для перемещения, ESC для завершения");
            bool is_run = false;

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            while (keyInfo.Key != ConsoleKey.Escape) 
            {
                if (keyInfo.Key == ConsoleKey.W || keyInfo.Key == ConsoleKey.A || keyInfo.Key == ConsoleKey.S || keyInfo.Key == ConsoleKey.D )
                    RunHandler.Do();

                if (keyInfo.Key == ConsoleKey.E) 
                {
                    is_run = !is_run;
                    RunHandler.SetStrategy(is_run);
                }
                   

                keyInfo = Console.ReadKey(true);
            }
        }
    }
}
