using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_06.domain.service
{
    public class Human667
    {
        string name = "千本松拓";
        int age = 21;
        string sex = "男(man)";

        public void selfIntroduction()
        {
            Console.WriteLine("自己紹介します。");
            Console.WriteLine("私の名前は"+name+"です。");
            Console.WriteLine("年齢は" + age + "歳です。");
            Console.WriteLine("性別は" + sex + "です。");
            Console.WriteLine("将来の夢はプロ野球選手です。");
        }
    }
}
