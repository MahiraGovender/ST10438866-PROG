namespace ICE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle("Rectangle", 1, 3);
            Circle cir = new Circle("Circle", 4, 3);

            rec.Display();
            cir.Display();
        }
    }
}
