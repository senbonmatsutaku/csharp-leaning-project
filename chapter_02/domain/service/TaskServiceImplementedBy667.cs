using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_02.domain.service
{
    public class TaskServiceImplementedBy667 : ITask
    {
        public void FortuneGame()
        {
            Console.WriteLine("ようこそ占いの館へ");
            Console.WriteLine("あなたの名前を入力して下さい");
            string name = Console.ReadLine();
            Console.WriteLine("あなたの年齢を入力してください");
            string ageString = Console.ReadLine();
            int age = Convert.ToInt32(ageString);
            System.Random r = new System.Random();
            int fortune = r.Next(0, 4);
            fortune++;
            Console.WriteLine("占いの結果が出ました");
            Console.WriteLine(age + "歳の" + name + "さん、あなたの運気番号は" + fortune + "です。");
            Console.WriteLine("1:大吉 2:中吉 3:吉 4:凶");
        }

        public void LearnOperatorPriority()
        {
            int x = 2;
            int y = 3;
            int z = x + y;
            String answer = "x + y = " + z;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine(answer);
        }

        public void LearnTypeConversion()
        {
            Console.WriteLine("正しい文は2,4,5,7です。");
        }
    }
}
