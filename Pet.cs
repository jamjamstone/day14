using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day14
{
    class Pet
    {
        /// <summary>
        /// 랜덤 지정은 여기서 하는게 가능 프로퍼티를 public으로 했다면 거기에
        /// 들어가는 변수도 public으로 설정해야 함
        /// 
        /// </summary>
        //public string petName;
        private enum petRareEnum {
            Rare, Epic, Legendary
        };
        petRareEnum petRare=petRareEnum.Legendary;
        
        private int petLevel=1;
        public enum petTypeEnum {//enum 같은 열거형은 클래스 바깥으로 빼는게 쉬울것
            speed, critical, specialize
        };
        //petTypeEnum petType;
        private enum petSkillEnum {
            mamaRestore, healthRestore, attSpeedUp, none

        };
        petSkillEnum petSkill;
        public string petName
        {
            get; set;
        }
        public string ShowPetName()
        {
            return petName;
        }
        public void ShowPetRare()
        {
            switch (petRare)
            {
                case petRareEnum.Rare:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Rare");
                    Console.ResetColor();
                    break;
                case petRareEnum.Epic:
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("Epic");
                    Console.ResetColor();
                    break;
                case petRareEnum.Legendary:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Legendary");
                    Console.ResetColor();
                    break;
                default:
                    break;
            }
        }
        public int PetLevel// 프로퍼티니까 _소문자
        {
            get { return petLevel; }
        }
        public void PetLevelUp()
        {
            if (petLevel < 30)
            {
                petLevel += 1;
            }
            else
            {
                petLevel = 30;
            }
        }


        public petTypeEnum petType// 스택 오버플로우
        {

            get;set;
            /*
            get { 
                return petType;
            } set
            {
                petType = value;
                /*
                switch (petType)
                {
                    case petTypeEnum.speed:
                        break;
                    case petTypeEnum.specialize:
                        break;
                    case petTypeEnum.critical:
                        break;
                        default:
                        break;
                }
            }*/
        }
        public void RandomSkillGiver()
        {
            Random random = new Random();
            if (petRare == petRareEnum.Legendary)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        petSkill = petSkillEnum.mamaRestore;
                        break;
                        case 2:
                        petSkill = petSkillEnum.healthRestore;
                        break;
                        case 3:
                        petSkill = petSkillEnum.attSpeedUp;
                        break;
                        default:
                        break;
                }
            }
            else
            {
                petSkill=petSkillEnum.none;
            }
        }
        public void ShowPetSkill()
        {
            Console.WriteLine(petSkill);
        }
            



    }
}
