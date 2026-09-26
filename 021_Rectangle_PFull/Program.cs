namespace _021_Rectangle_PFull
{
    class Rectangle
    {//propfull하고 탭
        private double width;
        private double height;

        public double Height
        {
            get { return height; }
            set
            {
                if (value >= 0)
                    height = value;
                else
                    throw new ArgumentException("Height는 음수일수 없습니다");

            }
        }


        public double Width
        {
            get { return width; }
            set
            {
                if (value >= 0) //비주얼스튜디오를 쓸때는 이게 편함
                    width = value;
                else
                    throw new ArgumentException("Width는 음수일수 없습니다");

            }
        }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }
        public double GetPerimeter()
        {
            return 2 * (Width + Height);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(5, 3);
            Console.WriteLine($"넓이: {r.GetArea()}");
            Console.WriteLine($"둘레: {r.GetPerimeter()}");
        }
    }
}
