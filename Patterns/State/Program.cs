namespace State
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Context context = new Context(new IdleState());

            context.Move();



            context.Stop();
        }
    }
}
