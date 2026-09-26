namespace _015_class2
{
    class Ract
    {
        //필드로 선언 -> getter setter 필요
        double width;//디폴트로 private이다
        double height;
    }

    class Ractangle
    {
        //속성(property)으로 만든다
        public double Width { get; set; }//속성은 대문자로 한다
        public double Height { get; set; }//조건은 못달음
    }

    class Rectangle2
    {
        private double width;
        public double Width
        {
            get { return width; }
            set { if (value > 0) width = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}
