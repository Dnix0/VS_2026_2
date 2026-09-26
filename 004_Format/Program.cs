namespace _004_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double x;

            i = 5;
            x = 3.141592;

            Console.WriteLine("i = " + i + ", x = " + x);//Console.WriteLine은 문자열과 변수를 연결하여 출력하는 방법
            Console.WriteLine("i = {0}, x = {1}", i, x);//{0}은 i의 값을, {1}은 x의 값을 나타냄
            Console.WriteLine("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);

            string p;
            p = string.Format("10 이하의 소수 : {0}, {1}, {2}, {3}", 2, 3, 5, 7);//.Format은 문자열을 형식화하여 반환하는 메서드
            Console.WriteLine(p);

            int v1 = 100;
            double v2 = 1.234;

            //Console.WriteLine(v1, v2);
            Console.WriteLine(v1 + ", " + v2);
            Console.WriteLine("v1 = {0}, v2 = {1}", v1, v2);
            Console.WriteLine($"v1 = {v1}, v2 = {v2}");
            Console.WriteLine("{0:N2}", 1234.5678);
        }
    }
}
