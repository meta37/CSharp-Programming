namespace Cording_Test
{
    internal class Program 
    {               /* 객체 지향 프로그래밍 다루기 */
                     // 드라이버, 차 클래스 객체 생성
                     //드라이버 <-> 차
                     // 차의 속도 변화
    class Driver
        {
            public string name;

            public void Ride(Car Car)
            {
                Console.WriteLine($"{this.name} 이/가 {Car.name}을/를 타고 운전합니다.");
                Car.Move();
            }
        }
    class Car
        {
            public string name;
            public int speed = 0;

            public void Move()
            {
                speed += 10;
                Console.WriteLine($"차가 가속하여 {speed} 속도가 되었습니다. ");
            }

            public void Brake()
            {
                speed += 10;
                Console.WriteLine($"차가 감속하여 {speed} 속도가 되었습니다. ");
            }
        }

        static void Main1()
        {
            Driver driver = new Driver() { name = "진우" }; // 드라이버 객체 생성
            Car stroller = new Car() { name = "유모차" };   //  차      객체 생성

            driver.Ride(stroller);      // 드라이버 객체가 Ride 기능으로 차 객체와 상호작용
        }

       // 캡슐화 : 몬스터를 정의
       // 몬스터에 이름 체력 데미지 받기
       // 상속 : 여러 몬스터 종류 생성
       // 오크 : 분노 슬라임 : 분열  드래곤 : 브레스

        class Man
        {
            public string name;
        }
         class Monster
        {
            protected string name;
            protected int hp;

            public void Dash(Man target)
            {
                Console.WriteLine($"{name} 이/가 {target.name}에게 대쉬 합니다.");
            }
            public void TakeHit(int damage)
            {
                hp -= damage;
                Console.WriteLine($"{name} 이/가 {damage}를 받아 체력이 {hp}이 되었습니다.");
            }
        }

        class Dragon : Monster
        {
            public Dragon()
            {
                name = "드래곤";
                hp = 1000;
            }

            public void Breath()
            {
                Console.WriteLine($"{name}이/가 브레스를 뿜습니다.");
            }
        }

        class Slime : Monster
        {
            public Slime()
            {
                name = "슬라임";
                hp = 150;
            }

            public void Split()
            {
                Console.WriteLine($"{name}이/가 분열합니다.");
            }
        }

        class Ork : Monster
        {
            public Ork()
            {
                name = "오크";
                hp = 650;
            }

            public void Angry()
            {
                Console.WriteLine($"{name}이/가 분노합니다.");
            }
        }

        class Hero : Man
        {
            public Hero()
                {
                name = "만렙! 최강전사 찌눙이 ";
                }
            int damage = 100;

            public void Attack(Monster monster)
            {
                monster.TakeHit(damage);
            }
        }

        static void Main2()
        {
            Hero hero = new Hero();
            Dragon dragon = new Dragon();
            Slime slime = new Slime();
            Ork ork = new Ork();
            // 부모 클래스 Monster를 상속한 자식 클래스들은 부모클래스의 기능을 가지고 있음.
            dragon.Dash(hero); slime.Dash(hero); ork.Dash(hero);
            // 자식 클래스는 부모클래스의 기능에 자식만의 기능을 추가하여 구현 가능.
            dragon.Breath(); slime.Split(); ork.Angry();

            // 업 캐스팅 : 자식클래스는 부모클래스 자료형으로 묵시적 형변환 가능
            
            hero.Attack(dragon);
            hero.Attack(slime);
            hero.Attack(ork);

            Monster monster1 = new Dragon();
            Monster monster2 = new Slime();
            Monster monster3 = new Ork();

            hero.Attack(dragon);
            hero.Attack(slime);
            hero.Attack(ork);

            // 다운캐스팅 : 부모클래스는 자식클래스 자료형으로 명시적 형변환 가능 (단, 가능할 경우)
            Dragon d = (Dragon)monster1;
            Slime s = (Slime)monster2;
            Ork o = (Ork)monster3;

            if (monster1 is Dragon)
            {
                Dragon isDragon = (Dragon)monster1;
            }
            Dragon asDragon = monster1 as Dragon;
        }
    }
} 

