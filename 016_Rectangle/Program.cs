using System.Xml.Linq;

namespace _016_Rectangle
{
    class Rectangle
    {
        private int width;//필드에서 프라이빗으로 선언
        private int height;// 필드

        //생성자 메소드는 객체와 같은이름에 리턴값X
        //객체선언할때 값을줘야함
        public Rectangle(int width, int height)//생성자 선언, 초기화 시킴, 객체가 만들어질때 선언되는 값으로 초기화
        {//괄호 안에는 두개의 값으로 초기화 하는 생성자 함수는 클래스 이름과 같다, 이를 메소드라고도 한다
            this.width = width;//this.width는 private width
            this.height = height;//this.height는 private height
        }

        public int GetArea()//메서드 GetArea , 면적
        {
            return width * height;
        }
        public int GetPerimeter()//메서드 GetPerimeter, 둘레
        {
            return 2 * (width + height);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5, 3);//객체 선언

            int area = rect.GetArea();
            int peri = rect.GetPerimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + peri);
        }
    }
}
