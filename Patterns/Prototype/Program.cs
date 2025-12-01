namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPaper paper = new Paper("fkjhbdfsbjkhfdkbjh");

            IPaper paper2 = paper.Clone();
            IPaper paper3 = new Paper(paper2);

            paper = null;

            Console.WriteLine(paper2.Text);
        }
    }
}
