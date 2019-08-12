using System;
using System.Collections.Generic;
using System.Text;
using chapter_09.domain.service._667;

namespace chapter_09.domain.service.student667
{
    class HighschoolBoy667 : boy667
    {
        string SignatureMove;
        public string getSignatureMove()
        {
            return this.SignatureMove;
        }
        public string SetSignatureMove(string SignatureMove)
        {
            this.SignatureMove = SignatureMove;
            return this.SignatureMove;
        }
        public void rememberMyDream()
        {
            boy667 boy = new boy667();
            boy.SetName("a");
            boy.SetAge(1);
            boy.prologue();
        }
        public void specialTraining()
        {
            boy667 boy = new boy667();
            string seltraining;
            Console.WriteLine("トレーニングを実施　1:高校時代 2:少年時代");
            seltraining = Console.ReadLine();
            if (seltraining == "1")
            {
                specialTrainingplus(3);
            }
            else if (seltraining == "2")
            {
                boy.specialTraining(5);
            }
            else
            {
                Console.WriteLine("1.2のどちらでもありません");

            }
        }
        public void boast(string SignatureMove)
        {
            Console.WriteLine("得意技は" + SignatureMove + "です");
        }
        public void specialTrainingplus(int battingbnt)
        {
            int course;
            int hitcnt = 0;
            int strikhit = 0;
            Console.WriteLine("まずは素振り" + battingbnt + "回！");
            for (int i = 0; i < battingbnt; i++)
            {
                System.Random r = new System.Random();
                int courseRand = r.Next(1, 3);
                Console.WriteLine("ビュッ！");
                Console.WriteLine("1:内角、2:外角、3:ド真ん中");
                course = int.Parse(Console.ReadLine());
                if (course == courseRand)
                {
                    Console.WriteLine("HIT！");
                    hitcnt = hitcnt + 1;
                }
                else
                {
                    Console.WriteLine("ストライク！");
                    strikhit = strikhit + 1;
                }
                Console.WriteLine("ループを強制的に抜けるにはqを入力してください");
                string loopbreak;
                loopbreak = Console.ReadLine();
                if (loopbreak == "q")
                {
                    break;
                }
            }
            Console.WriteLine("HIT数" + hitcnt);
            Console.WriteLine("ストライク数" + strikhit);
        }
    }
}
