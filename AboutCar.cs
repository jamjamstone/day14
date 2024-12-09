using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    internal class AboutCar// 이게 있으면 별도 과정을 거처야 하는듯?
    {
        ///d
        ///
       public class Car
        {
            /// <summary>
            /// 주석에 기호같은걸 붙여서 정리하는 사람도 있음
            /// 예시 
            /// ▽ 변수
            /// 
            /// </summary>
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
                get; set;
            }



        }


    }
}
