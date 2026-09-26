namespace _017_student
{
    class student
    {
        private string? name, major;//?를 붙이면 nullable이라고 값이 없을수도 있다는 뜻
        private int age;

        public student(string? name, int age, string? major)
        {//생성자 클래스와 이름이 같으며 리턴값이 없다
            //세터를 안만들어 줘도됨, 값을 초기화 시켜줄때 사용
            //생성자 규칙에 맞춰서 객체에 값을 줘야함
            // setter는 SetName("양희원") 그러면 3개다 세터를 만들어줘야함
            this.name = name;
            this.major = major;
            this.age = age;
        }

        public void DisplayInfo()// 출력
        {
            //Student s = new Student("홍길동", 19, "전공")
            //s.Display(); 실행시키는 방법임 매우중요
            Console.WriteLine("이름 : {0}\n나이: {1}\n전공: {2}", name, age, major);
            Console.WriteLine($"이름 : {name}\n나이: {age}\n전공: {major}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            student stu = new student("양희원", 23, "의료IT공학");
            stu.DisplayInfo();
        }
    }
}
