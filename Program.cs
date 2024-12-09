using System.Threading.Channels;
using static day14.AboutCar;

namespace day14
{ 


    /// <summary>
    /// 필드명=> _ 또는 소문자로 표시, 지역변수, 매개변수, => 소문자로 인터페이스 =>|로? I로? 나머지는 모두 대문자 시작
    /// 프로그램에 필요한 요소와 기능들만 추려서 담는 것을 보고 추상화 라고 함
    /// 요소 +기능으로 만들어진 자료형이 클래스 따라서 클래스를 할당해야 하고 
    /// 할당한 순간 객체가 된다.
    /// 클래스로 만들어진 결과물이 객체
    /// 구조체와 클래스의 차이는 값타입이냐 참조타입이냐
    /// 구조체는 값타입, 클래스는 참조타입이다
    /// 구조체는 크기가 작고 간단한 객체를 정의할 때 사용
    /// 클래스는 복잡한 객체를 정의할때
    /// 16바이트 미만일 경우에 구조체 사용할 것을 권장이지만 int 하나가 8바이트이기 때문에
    /// int 2개면 권장 사양을 넘음
    /// 가비지 콜렉터 
    /// 
    /// 
    /// stack
    /// 스택 매개변수, 지역변수등을 저장, 함수가 끝날 때 쯤에 스택에 저장한 정보가 날아가는
    /// 경우가 존재
    /// 
    /// 
    /// 
    /// heap
    /// 클래스, 배열같은 큰 객체가 잡힌다
    /// 배열은 큰 객체는 아니다.
    /// 여기를 사용할 경우 동적할당 했다고 함
    /// 
    /// data, code 영역
    /// 프로그램이 실행되는 코드는 code 영역에 
    /// 전역변수나 static같은 프로그램이 실행되는동안 유지되는 메모리 공간을 말함
    /// 
    /// 객체: 클래스를 바탕으로 구현한 실체
    /// 
    /// 
    /// </summary>
    internal class Program
    {

        
       /*static void MoveForward(Car car, int toMove)
        {
            car._posX += toMove;
        }*/
        static void Main(string[] args)
        {
            /*
            Car car = new Car();//참조형 Car car;만 있을 경우 주소를 담을
            car.PosX = 10;
            Console.WriteLine(car.PosX);
            car.MyName = "Bugahti";
            Console.WriteLine(car.MyName);
              */
            
            Pet pet = new Pet();
            Console.WriteLine("type petname");
            pet.petName=Console.ReadLine();
            Console.WriteLine(pet.petName);
            Console.WriteLine(pet.PetLevel);
            pet.PetLevelUp();
            Console.WriteLine(pet.PetLevel);
            pet.ShowPetRare();
            pet.RandomSkillGiver();
            pet.ShowPetSkill();
            pet.RandomSkillGiver();
            pet.ShowPetSkill();
            pet.RandomSkillGiver();
            pet.ShowPetSkill();
            bool sw = true;
            Pet.petTypeEnum petType;
            petType = pet.petType;
            while (sw)
            {
                Console.WriteLine("type pettype (speed,critical,specialize");
                Enum.TryParse(Console.ReadLine(),out petType);
                switch (petType)
                {
                    case Pet.petTypeEnum.speed:
                        pet.petType = Pet.petTypeEnum.speed;
                        sw = false;
                        break;
                    case Pet.petTypeEnum.critical:
                        pet.petType = Pet.petTypeEnum.critical;
                        sw = false;
                        break;
                    case Pet.petTypeEnum.specialize:
                        pet.petType = Pet.petTypeEnum.specialize;
                        sw = false;
                        break;
                    default:
                        Console.WriteLine("speed, critical, specialize");
                        break;

                }
            }
            Console.WriteLine(pet.petType);
            
            //그릇만 담을 경우
            //int myNum = 4;//값
            //int[] intArray = new int[10];//참조
            //car._maxSpeed = 1.0f;
            //car._posX = 14;
            //가비지 콜렉터가 힙에서 안쓰는 메모리를 회수해서 감
            //가비지 콜렉터가 많이 일할 수록랙이 걸리기 때문에 이를 막는 여러 기법이 존재
            //car = new Car();
            //Car car2 = car;//참조형은 주소를 복사한다.
            //car.MoveForward(10);// 자동차와 관련된 함수를 사용
            //car.SetCarNum(-10);
            /// 음수가 들어가도 작동함 이런 이유로 다른 개발자가
            //사용할 때 실수할 수 있음
            //Console.WriteLine(car.GetCarNumber());




        }
    }
}
