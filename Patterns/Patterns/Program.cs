using Factory_method;

namespace Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите тип растения: 0 - дыня, 1 - картофель");
            int i = Convert.ToInt32(Console.ReadLine());

            try
            {
                Creator creator = Initializator.init((Initializator.PlantType)i);
                IPlant plant = creator.CreatePlant();
                plant.Grow();
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Неверный параметр инициализации");
            }
        }

    }


    internal class Initializator 
    {
        public enum PlantType { Melon, Potato }

        internal static Creator init(PlantType type)
        {
            switch (type)
            {
                case PlantType.Melon:
                    return new MelonCreator();

                case PlantType.Potato:
                    return new PotatoCreator();

                default:
                    return null;
            }
        }
    }
}
