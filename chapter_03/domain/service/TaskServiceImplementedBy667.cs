using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_03.domain.service
{
    class TaskServiceImplementedBy667 : ITask
    {
        public void CountGame()
        {
            Console.WriteLine("数当てゲーム");
            System.Random r = new System.Random();
            int answer = r.Next(0, 9);
            Console.WriteLine("0 ～ 9 の数字を入力してください");
            var num = Console.ReadLine();
            while (answer != int.Parse(num))
            {
                Console.WriteLine("ハズレ！");
                Console.WriteLine("0 ～ 9 の数字を入力してください");
                num = Console.ReadLine();
            }
            Console.WriteLine("アタリ！");

        }

        public void LearnIfStatement1()
        {
            int sex = 0;
            int age = 10;
            Console.WriteLine("こんにちは");
            if (sex == 0)
            {
                Console.WriteLine("私は男です");
                Console.WriteLine(age + "歳です");
            }
            else if (sex == 1)
            {
                Console.WriteLine("私は女です");
            }
            Console.WriteLine("よろしくお願いします");
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
            {
                Console.WriteLine("家でゲーム");
                Console.WriteLine("寝る");
            }
        }

        public void LearnIfSyntax1()
        {
            int weight = 0;
            int age = 0;
            int age1 = 0;
            int age2 = 0;
            String job = "";
            if(weight ==60)
            {

            }
            if ((age1 + age2) * 2 > 60)
            {
            }
            if((age/2) >0)
            {

            }
            if(job == "プログラマー")
            {

            }

        }

        public void LearnIfSyntax2()
        {
            Console.Write("条件式として正しいのはC,D,E,F");
        }

        public void LearnSwitchStatement()
        {
            Console.Write("[メニュー] 1:検索 2:登録 3:削除 4:変更 > ");
            var selected = Console.ReadLine();
            switch (selected)
            {
                case "1":
                    Console.Write("検索します");
                    break;
                case "2":
                    Console.Write("登録します");
                    break;
                case "3":
                    Console.Write("削除します");
                    break;
                case "4":
                    Console.Write("変更します");
                    break;
                default:
                    Console.Write("メニューにありません");
                    break;
            }
        }
    }
}
