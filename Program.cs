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
            public int _posX; //멤버 변수 또는 필드 또는 구성요소
            public int _posY;// public 접근지정자
            public float _maxSpeed;
            private int _carNumber; //private는 안쓰면 자동으로 사용됨

            //기능, 메소드mothod
            public void MoveForward(int posX)//함수내에서의 private도 메소드를 이용해서 접근가능
            {
                this._posX += posX;//this. 은 이 메소드 바깥의 클래스 내부의 변수를
                //지정해주는 연산자?
            }
            public int GetCarNumber()//객체가 반환도 할 수 있다.
            {
                return _carNumber;
            }
        }
        static void MoveForward(Car car, int toMove)
        {
            car._posX += toMove;
        }
        static void Main(string[] args)
        {
            Car car = new Car();//참조형 Car car;만 있을 경우 주소를 담을
            //그릇만 담을 경우
            //int myNum = 4;//값
            //int[] intArray = new int[10];//참조
            car._maxSpeed = 1.0f;
            car._posX = 14;
            //가비지 콜렉터가 힙에서 안쓰는 메모리를 회수해서 감
            //가비지 콜렉터가 많이 일할 수록랙이 걸리기 때문에 이를 막는 여러 기법이 존재
            //car = new Car();
            //Car car2 = car;//참조형은 주소를 복사한다.
            car.MoveForward(10);// 자동차와 관련된 함수를 사용
                




        }
    }
}
