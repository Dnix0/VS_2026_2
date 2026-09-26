using System.ComponentModel;

namespace _18_calcul
{
    class calculator
    {
        public static double Add(double a, double b)
        {
            return a + b;
        }

        public static double Subtract(double a, double b)
        {
            return a - b;
        }
        public static double Multiply(double a, double b)
        {
            return a * b;
        }
        public static double Divide(double a, double b)
        {
            if(b == 0)
            {
                Console.WriteLine("0으로 나눌수 없습니다.");
                return 0;
            }
            
            else
            {
                return a / b;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = 10;
            double num2 = 5;

            //calculator 클래스는 static메소드를 가지고있으므로
            //객체를 만들지 않고, 클래스 이름으로 메소드를 호출
            double sum = calculator.Add(num1, num2);
            double differece = calculator.Subtract(num1, num2);
            double product = calculator.Multiply(num1, num2);
            double quotient = calculator.Divide(num1, num2);

            Console.WriteLine("덧셈: " + sum);
            Console.WriteLine("뺄셈: " + differece);
            Console.WriteLine("곱셉: " + product);
            Console.WriteLine("나눗셈: " + quotient);
        }
    }
}
