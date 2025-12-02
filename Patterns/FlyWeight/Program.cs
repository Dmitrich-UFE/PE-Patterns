namespace FlyWeight
{
    internal class Program
    {
        //отрисовка травы в Unity примерно
        static void Main(string[] args)
        {
            Sprite sprite = new Sprite();
            GrassFlyWeight gFW = GrassFactory.getGrassFlyWeight(sprite);
            FillGrassList(new Grass(gFW, new Transform(2, 5, -7)), new Grass(gFW, new Transform(6, 8, 13.3)));

            foreach (var item in grassList)
                item.DrawOnMap();
        }


        static List<Grass> grassList = new List<Grass>();

        static internal void FillGrassList(params Grass[] grass) 
        {
            foreach (var grassItem in grass) 
            {
                grassList.Add(grassItem);
            }
        }

    }
}
