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
    /// 
    /// 
    /// 
    /// </summary>
    internal class Program
    {

        class Car
        {

            //변수
            //string _carName;
            public int _posX; //멤버 변수 또는 필드 또는 구성요소
            public int _posY;// public 접근지정자
            public float _maxSpeed;
            private int _carNumber; //private는 안쓰면 자동으로 사용됨
            // 외부에 공개할 필요 없는 변수를 private로 숨기고 
            //외부에서 직접 접근하지 못하도록 숨기고 메소드를 통해서만 조작하게 하는걸
            //정보 은닉이라고 한다. 
            ///객체 내부데이터 변경을 실수로부터 지킬 수 있음
            ///_posX 변수는 차의 위치일수도 있지만 주차장의 위치 콘솔창의 넓이인지 타인은
            ///알 수 없기 때문에 그러한 실수를 줄이기 위해서 
            //기능, 메소드mothod
            /*
            public void MoveForward(int posX)//함수내에서의 private도 메소드를 이용해서 접근가능
            {
                this._posX += posX;//this. 은 이 메소드 바깥의 클래스 내부의 변수를
                //지정해주는 연산자?
            }
            public int GetCarNumber()//객체가 반환도 할 수 있다.
            {
                return _carNumber;// 외부에서 념겨준 인자값으로 세팅할 예정


            }

            public void SetCarNum(int carNumber)// 0보다 작은 값이 들어오면 0으로 리셋 아니면 값 변화
            {
                if (carNumber < 0)
                {
                    _carNumber = 0;
                }
                else
                {
                    _carNumber = carNumber;
                }
            }*/

            /// 프로퍼티 -> 속성 
            /// 프로퍼티는 외부에 노출될 필요가 없는 맴버변수들을 정보은닉시켜준다
            /// 또한 외부와 소통할 일이 있을 경우 직접 맴버변수와 소통하는 것이 아니라
            /// 필터의 역활로도 기능한다.
            public int PosX
            {
                //get;set;//접근자
                get//get을 지우면 보는것이 불가능해짐
                {
                    return _posX;
                }
                set// set을 지우면 보는것만 가능
                {
                    if (value > 1920)
                    {
                        _posX = 1920;
                    }
                    else
                    {
                        _posX = value;// value에는 대입하는 값을 받는다.

                    }
                }
            }
            ///자동구현 프로퍼티
            ///클래스에 변수가 없어도 자동으로 생성해줌 <summary>
            ///제약이 필요하면 자동구현으로 하면 안됨
            ///제약이 필요 없으면 자동구현 프로퍼티 사용가능
            /// </summary>
            public string MyName
            {
                get;set;
            }



        }
        static void MoveForward(Car car, int toMove)
        {
            car._posX += toMove;
        }
        static void Main(string[] args)
        {
            Car car = new Car();//참조형 Car car;만 있을 경우 주소를 담을
            car.PosX = 10;
            Console.WriteLine(car.PosX);
            car.MyName = "Bugahti";
            Console.WriteLine(car.MyName);
                



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
