using System;

namespace Example_2
{
    class ClassStudy1
    {
        static void Main12()
        {
            Person person1 = new Person(); // new 키워드의 의미 : 실체화, 객체화, 인스턴싱

            person1.name = "김정완";
            // person1.age = 26;

            person1.Greet();
            person1.Walk();
            person1.Run();

            bool isOK = person1.Greet("이치호", 28);
            Console.WriteLine(isOK ? "맞습니다." : "아닙니다.");

            // 정적 메소드 활용
            float result = Util.Add(3, 5.6f);
            Console.WriteLine(result);

            Person person2 = new Person();
            // person2.name = "김하늘";
            // person2.age = 25;
            person2.Greet();
            person2.Walk();
            person2.Run();

            Person person3 = new Person("한수현", 50);
            Console.WriteLine(person3.Name); // get Property 사용
            person3.Name = "김연아"; // set property 사용


            Animal dog = new Animal();

            dog.greet("강아지", 4, "망고");
            dog.Walk();
            dog.Bark();
            dog.Run();
        }
    }

    // 접근 제한자 (접근 지정자) : public, private, protected
    public class Person
    {
        public string name;

        public String Name // 속성 get-set property
        {
            get { return name; }
            set { name = value; }
        }

        private string id;
        public String ID // 속성 get-set property
        {
            get { return id; }
            // set { name = value; }
        }

        private int age;
        public int Age { get; } // 나이는 확인만 가능
        public int Age1 { get; set; } // 나이를 확인과 변경 둘 다 가능    

        public Person()
        {
            Console.WriteLine("태어났다!");
        }

        public Person(string _name, int _age)
        {
            name = _name;
            age = _age;

            Console.WriteLine("이름을 가지고 태어났다!");
        }

        public void Greet()
        {
            Console.WriteLine($"안녕하세요. 제 이름은 {name}이고 나이는 {age}살 입니다.");
        }

        public void Walk()
        {
            Console.WriteLine("걷는 중입니다");
        }

        public void Run()
        {
            Console.WriteLine("달리는 중입니다");
        }

        public bool Greet(string _name, int _age)
        {
            Console.WriteLine($"저는 {_name}이고 나이는 {_age}살 입니다.");

            if (_name == name && _age == age) return true;

            else return false;
        }
    }

    /*
    정적 메소드 : 인스턴싱(객체 생성) 하지 않고 사용할 수 있는 메소드
    보통 기능만 정의할 때 사용함
    */

    public class Util
    {
        public static float Add(float a, float b)
        {
            return a + b;
        }
    }

    public class Animal
    {
        private string breed;
        private int leg_Count;
        private string animal_name;

        public void greet(string type, int legCnt, String name)
        {
            breed = type;
            leg_Count = legCnt;
            animal_name = name;

            Console.WriteLine($"종은 {breed}이고, 다리 개수는 {leg_Count}개 이며, 이름은 {animal_name}입니다.");
        }

        public void Walk()
        {
            Console.WriteLine("산책중입니다!");
        }

        public void Bark()
        {
            Console.WriteLine("짖는중입니다!");
        }

        public void Run()
        {
            Console.WriteLine("뛰는중입니다!");
        }

        void Shoutout(string _breed, int _leg_Count, string _animal_name)
        {
            Console.WriteLine(_breed, _leg_Count, _animal_name);
        }
    }
}