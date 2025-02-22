using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 변수의 선언과 데이터 타입
            // 변수의 선언하는 방법
            // (데이터 타입) (변수 이름) = (값)
            Console.WriteLine("Hello World");

            string myName = "Hello";
            Console.WriteLine(myName);

            int age = 25;
            Console.WriteLine(age);

            // 정수형 데이터
            int myInt = 25;
            short myShort = 25;
            long myLong = 25;
            byte myByte = 25;

            Console.WriteLine(myByte);
            Console.WriteLine(myShort);
            Console.WriteLine(myLong);
            Console.WriteLine(myInt);
        }
    }
}
