namespace CT_23_12_28
{
    internal class fight
    {
        /* 레인보우 식스 시즈 2
         설계		        // 총게임이다 보니.. 느낌만 내보는 걸로.. 하자..

         공격팀, 방어팀       // 공격팀을 player로 방어팀을 computer로 지정.
         캐릭터 스텟 3속 3방어력 분배   // 랜덤 사용해서 3속이면 1방어 1속이면 3방어.
         특수능력(스킬)       // 구현 힘들것같으니 패스..

         게임룰은 그냥 가위바위보로 두고
         player과 computer 이 스탯을 랜덤값으로 받고 게임에 들어간다.
         기본체력(100)에 방어 1당 +10 을 받고(운빨겜이네..) 가위바위보를 시작한다.

         한번 이길떄마다 상대에게 10의 피해를 입히고
         또 이길 시에 10 += 10 피해를 입힌다.
         또 이길 시에 20+= 10피해(중첩데미지) 를 입힌다.중첩데미지 max값은 30으로 두자.

         두 팀중 피가 0으로 내려가면 이긴사람, 대사 출력.. 해보자.. */

        class Player
        {
            public string name;
            public int hp = 100;
            public int damage = 10;

            public void TakeHit1(Computer target)
            {
                hp -= damage;
                Console.WriteLine($"{this.name}이 {target.name}에게 *파괴탄*을 쏩니다.");
                Console.WriteLine($"{target.name}의 체력이 {target.hp}남았습니다.");
            }
        }

        class Computer
        {
            public string name;
            public int hp = 100;
            public int damage = 10;

            public void TakeHit2(Player target)
            {
                hp -= damage;
                Console.WriteLine($"{this.name}이 {target.name}에게 *충격수류탄*을 던집니다.");
                Console.WriteLine($"{target.name}의 체력이 {target.hp}남았습니다.");
            }
        }

        class Ash : Player
        {
            public Ash()
            {
                name = "공격팀 애쉬";
            }

        }

        class Rock : Computer
        {
            public Rock()
            {
                name = "방어팀 룩";
            }
        }

        static void Main()
        {
            Console.WriteLine("레인보우 식스 시즈2");

            Ash ash = new Ash();
            Rock rock = new Rock();

            
        }
    }
}
