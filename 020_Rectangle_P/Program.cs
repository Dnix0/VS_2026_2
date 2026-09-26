namespace _020_Rectangle_P
{
    internal class Program
    {
        class Rectangle
        {
            //Width 속성(Property)
            //밖에서 잘못고치지 않게 해주는 기능이 이미 속성에 있다.
            public int Width { get; set; }//정수타입의 MyProperty 겟, 셋과 함께 선언
            public int Height { get; set; }//속성
            //겟, 셋을 굳이 안만들어도됨
            //값을 가져오는건 가능한데 셋의 값을 변경할수있는게 단점
            //이를 보완해기 위해서 속성에서 조건을 달아줌

            public int GetArea()
            {
                return Width * Height;
            }
        }
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            r.Width = 10;
            r.Height = 5;

            Console.WriteLine("면적:" + r.GetArea());
        }
    }
}
