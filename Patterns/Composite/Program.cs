namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Log log1 = new Log();
            Box box1 = new Box();

            IPhysicalObject compositor1 = Program.GroupPhysicalObjects(log1, box1);

            Log log2 = new Log();

            IPhysicalObject compositor2 = Program.GroupPhysicalObjects(log2, box1, compositor1);

            Console.WriteLine("Просчёт физики объектов в иерархии");
            compositor2.CalculatePhysics();

            Console.WriteLine("\nПрограмма завершила работу. Поток заснул на 100 секунд");
            Thread.Sleep(100000);
        }

        static IPhysicalObject GroupPhysicalObjects(params IPhysicalObject[] objs) 
        {
            PhysicalObjectsCompositor compositor = new PhysicalObjectsCompositor();

            foreach (var obj in objs) 
            {
                compositor.Add(obj);
            }

            return compositor;
        }
    }
}
