namespace StructsApp
{
    public struct Point
    {

        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) 
        { 
            X = x;
            Y = y;
        }

        public void Diplay()
        {
            Console.WriteLine($"Point x:{X} and y:{Y}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(10, 20);
           p.Diplay();
        }
    }
}
