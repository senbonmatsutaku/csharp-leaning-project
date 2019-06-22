using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_06.domain.service
{
    public class Human667
    {
        string name = "name";
        int age = 0;
        string sex = "man";

        public void selfIntroduction()
        {
            Console.Write("私の名前は"+name+"です。年齢は"+age+"歳です。性別は"+sex+"です。将来の夢はプロ野球選手です。");
        }
    }
}
