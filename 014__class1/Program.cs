namespace _014__class1
{
    class date
    {
        private int year, month, day;//private가 붙으면 class date안에서만 사용가능
        //위코드는 field(필드)라고 한다. 보통 private로 써야한다
        //30월 ㅇㅈㄹ안하게 private라고 쓰낟
        //생성자 메소드: 리턴 값이 없고 클래스와 이름이 같다
        public date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        
        //오버로딩
        public date()
        {
            year = 1;
            month = 1;
            day = 1;
        }
        
        //setter
        public void Setyear(int year)
        {
            if (year < 0)
            {
                Console.WriteLine("year must be larger than 0");
                return;
            }
            this.year = year;//첫번쨰 year는 private 두번쨰는 public
        }
        //getter
        public int Getyear()
        {
            return this.year;
        }

        //출력 메소드
        public void PrintDate()
        {
            Console.WriteLine("{0}년 {1}월 {2}일", year, month, day);
            Console.WriteLine($"{year}년 {month}월 {day}일");

            string s = string.Format("{0}년 {1}월 {2}일", year, month, day);
            string t = string.Format($"{year}년 {month}월 {day}일");

            Console.WriteLine(s);
            Console.WriteLine(t);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //date클래스으 객체의 a를 만들자
            date a = new date();

            a.Setyear(2026);// 안전한 프로그램을 위해서
            Console.WriteLine("a의 년도는 {0}입니다,", a.Getyear());
            //생성자 함수(메소드) = 생성자 메소드 지정
            date myBirthday = new date(2004, 06, 11);

            Console.WriteLine("mtBirthday");
            myBirthday.PrintDate();

            //date myBirthday = new date();
            //myBirthday.SetYear(2004);
            //myBirthday.SetMonth(6);
            //myBirthday.Setday(11);
        }
    }
}
