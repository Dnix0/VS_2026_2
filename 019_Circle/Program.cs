namespace _019_Circle
{
    internal class Program
    {
        class Circle
        {
            string? color;
            double radius;

            public Circle(string Color, double Radius)//생성자
            {
                this.color = Color;//필드
                this.radius = Radius;
            }
            public double GetArea()//게터
            {
                return 3.14 * (radius * radius);
            }

            public void PrCircle()//출력
            {
                Console.WriteLine($"{color}, {radius},{GetArea()}");
            }

        }
        static void Main(string[] args)
        {
            Circle c = new Circle("red", 10);//객체생성
            c.PrCircle();//출력
        }
    }
}
