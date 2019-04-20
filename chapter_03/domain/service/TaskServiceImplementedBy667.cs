using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_03.domain.service
{
    class TaskServiceImplementedBy667 : ITask
    {
        public void CountGame()
        {
        }

        public void LearnIfStatement1()
        {
        }

        /// <summary>
        /// 問４
        /// 下記のような実装が行われている
        /// weatherがfalseの場合、「家でゲーム」の後に「寝る」と表示
        /// のつもりで書いたが意図したように動かない
        /// 正しく動くように修正せよ
        /// </summary>
        public void LearnIfStatement2()
        {
            Console.Write("今日の天気は？(0:晴れ 1:くもり 2:雨) > ");
            var input = Console.ReadLine();
            if (!int.TryParse(input, out int inputValue))
            {
                throw new FormatException("入力文字列が正しい形式ではありませんでした。");
            }
            bool weather = inputValue == 0;
            if (weather)
            {
                Console.WriteLine("洗濯をする");
                Console.WriteLine("彼女or彼氏とデート");
            }
            else
                Console.WriteLine("家でゲーム");
                Console.WriteLine("寝る");
        }

        public void LearnIfSyntax1()
        {
        }

        public void LearnIfSyntax2()
        {
        }

        public void LearnSwitchStatement()
        {
        }
    }
}
