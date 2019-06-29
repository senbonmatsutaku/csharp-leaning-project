using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_06.domain.service
{
    public class Human092
    {
        readonly string name = "鈴木 一郎";
        readonly int age = 41;
        readonly string sex = "man";
        readonly string sexJa = "男";

        public void SelfIntroduction()
        {
            Console.WriteLine($"");
            Console.WriteLine($"==================================");
            Console.WriteLine($"             自己紹介             ");
            Console.WriteLine($"==================================");
            Console.WriteLine($"名前は{name}といいます。");
            Console.WriteLine($"年は{age}歳です。");
            Console.WriteLine($"性別は{sexJa}({sex})です。");
            Console.WriteLine($"将来の夢は素敵な女性とめぐり逢い、結婚して幸せな家庭を築くことです！");
            Console.WriteLine($"よろしくお願いいたします。");
            Console.WriteLine($"");
        }
    }
}
