using System;
using System.Collections.Generic;
using System.Text;
using chapter_09.domain.service._667;

namespace chapter_09.domain.service.student667
{
    class HighschoolBoy667 : boy667
    {
        string SignatureMove;
        public string GetSignatureMove()
        {
            return this.SignatureMove;
        }
        public void SetSignatureMove(string SignatureMove)
        {
            this.SignatureMove = SignatureMove;
        }
        public void RememberMyDream()
        {
            SetName("sss");
            SetAge(10);
            prologue();
        }
        public void SpecialTraining()
        {
            string seltraining;
            string trainingcnt;
            int trainingcnt1;
            Console.WriteLine("トレーニングを実施　1:高校時代 2:少年時代");
            seltraining = Console.ReadLine();
            if (seltraining == "1")
            {
                Console.WriteLine("数値を入力してください");
                trainingcnt = Console.ReadLine();
                if (int.TryParse(trainingcnt, out trainingcnt1))
                {
                    SpecialTrainingPlus(int.Parse(trainingcnt));
                }
                else
                {
                    Console.WriteLine("数値を代入してください");
                }
            }
            else if (seltraining == "2")
            {
                Console.WriteLine("トレーニング回数を入力してください");
                trainingcnt = Console.ReadLine();
                if (int.TryParse(trainingcnt, out trainingcnt1))
                {
                    specialTraining(int.Parse(trainingcnt));
                }
                else
                {
                    Console.WriteLine("数値を代入してください");
                }
            }
            else
            {
                Console.WriteLine("1.2のどちらでもありません");
            }
        }
        public void SpecialTrainingPlus(int tracnt)
        {
            System.Random r = new System.Random();
            Console.WriteLine("まずは素振り" + tracnt + "回！");
            int runrange = r.Next(1, 10);
            Console.WriteLine("終わったら" + tracnt + "kmの走り込みだ！");
            Console.WriteLine("～～走り込み中～～");
            if (runrange % 2 == 0)
            {
                Console.WriteLine("達成できなかったから明日こそは頑張ろう！");
            }
            else
            {
                Console.WriteLine("達成できたから明日は今日よりもいっぱい走ろう");
            }
            Console.WriteLine("今日もいっぱい頑張ったしそろそろ終わろうかな！");
        }
        public void Boast()
        {
            Console.WriteLine("得意技は" + GetSignatureMove() + "です");
        }
    }
}
