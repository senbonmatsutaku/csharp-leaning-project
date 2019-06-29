using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_03.domain.service
{
    public class TaskServiceImplementedBy092 : ITask
    {
        // 問６
        // 次の条件に従ってプログラムを作成せよ
        // 1. 画面に【数当てゲーム】と表示
        // 2. ０から９までの整数の中からランダムな数を１つ生成して変数answerに格納
        // 3. for文を用いて5回のループ処理を作成
        // (以下4-7はループ中の処理)
        // 4. 画面に「0 ～ 9 の数字を入力してください」を表示
        // 5. 数字を入力し変数numに格納
        // 6. 入力した数字がanswerと一致したら「アタリ！」と画面に表示して繰り返しを終了
        // 7. もし不一致ならば「ハズレ！」と画面に表示
        // 8. 「ゲームを終了します」を表示
        public void CountGame()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("==             【数当てゲーム】           ==");
            Console.WriteLine("============================================");
            Console.WriteLine("「ルール説明」");
            Console.WriteLine("・０～９のランダムな数字が生成されます。");
            Console.WriteLine("・５回の回答チャンスのうちに数字を当ててください。");
            Console.WriteLine("・０～９の範囲外、数字以外を入力しても１回の回答にカウントされます。");

            int answer = new Random().Next(10);
            // for debug
            //        Console.WriteLine("カンニング：" + answer);

            int chance = 5;
            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"数字を入力してください（あと {chance} 回）：");
                try
                {
                    string strNum = Console.ReadLine();
                    if (int.TryParse(strNum, out int num))
                    {
                        if (num == answer)
                        {
                            Console.WriteLine("アタリ！");
                            break;
                        }
                        throw new FormatException();
                    }
                    else { throw new FormatException(); }
                }
                catch (FormatException)
                {
                    Console.WriteLine("ハズレ！");
                }
                chance--;
            }
            Console.WriteLine("ゲームを終了します。");
        }

        // 問３
        // 下記の内容に沿ったプログラムを作成せよ
        // 1. int型の変数sexを定義し、０か１を格納
        //    またint型変数ageを定義し、適当な数字を格納
        // 2. 画面に「こんにちは」と表示
        // 3. もし変数sexが0なら「私は男です」、そうでなければ「私は女です」と表示
        // 4. もし変数sexが男ならage変数の中身を表示して「(age)歳です」と表示
        // 5. 最後に「よろしくお願いします」と表示
        public void LearnIfStatement1()
        {
            const int MAN = 0;
            const int WOMAN = 1;

            Console.Write("性別を０か１で入力してください。（０：男、１：女）> ");
            int sex;
            try
            {
                string strSex = Console.ReadLine();
                if (int.TryParse(strSex, out sex))
                {
                    if (sex != MAN && sex != WOMAN)
                    {
                        throw new FormatException();
                    }
                }
                else { throw new FormatException(); }
            }
            catch (FormatException)
            {
                Console.WriteLine("０か１で入力してください。");
                return;
            }

            Console.Write("年齢を入力してください。> ");
            string strAge = Console.ReadLine();
            if (!int.TryParse(strAge, out int age))
            {
                Console.WriteLine("整数で入力してください。");
                return;
            }

            Console.WriteLine("こんにちは");
            if (sex == MAN)
            {
                Console.WriteLine("私は男です。");
                Console.WriteLine($"{age} 歳です。");
            }
            else
            {
                Console.WriteLine("私は女です。");
            }
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

        // 問１
        // 下記の条件式を記述せよ
        // 構文が正しければ良い
        // 画面に何かを出力する必要なし
        // 1. 変数weightの値が60に等しい
        // 2. 変数age1とage2の合計を2倍したものが60を超えている
        // 3. 変数ageが奇数である
        // 4. 変数jobの中身の文字列が「プログラマー」と等しい
        public void LearnIfSyntax1()
        {
            const int GENERATION_RANGE_MAX = 100;

            int weight = new Random().Next(GENERATION_RANGE_MAX);
            if (weight == 60)
            {
                Console.WriteLine("weight = " + weight);
            }

            int age1 = new Random().Next(GENERATION_RANGE_MAX);
            int age2 = new Random().Next(GENERATION_RANGE_MAX);
            if ((age1 + age2) * 2 > 60)
            {
                Console.WriteLine("age1 = " + age1);
                Console.WriteLine("age2 = " + age2);
            }

            int age = new Random().Next(GENERATION_RANGE_MAX);
            if (age % 2 == 1)
            {
                Console.WriteLine("age % 2 = " + (age % 2));
            }

            int jobType = new Random().Next(GENERATION_RANGE_MAX);
            String job;
            if (jobType % 2 == 1)
            {
                job = "プログラマー";
            }
            else
            {
                job = "大工";
            }
            if (job.Equals("プログラマー"))
            {
                Console.WriteLine("job = " + job);
            }
        }

        // 問２
        // 下記の中から条件式として正しいものを表示せよ
        // A. cost = 300 * 1.08
        // B. 3
        // C. age != 30
        // D. true
        // E. b + 5 < 20
        // F. gender = true
        public void LearnIfSyntax2()
        {
            Console.WriteLine("条件式として正しいのは C, D, E です。");
        }

        // 問５
        // switch文を用いて以下のプログラムを作成せよ
        // 1. 画面に「[メニュー] 1:検索 2:登録 3:削除 4:変更 >」と表示
        // 2. 数字を入力し、変数selectedに格納
        // 3. 変数が1-4の間であれば「(選択内容)します」と表示
        //    ex. 1選択時、「検索します」
        // 4. 1-4のいずれでもない場合、「メニューにありません」と表示
        public void LearnSwitchStatement()
        {
            Console.Write("[メニュー] 1:検索 2:登録 3:削除 4:変更 > ");
            String selected = Console.ReadLine();
            switch (selected)
            {
                case "1":
                    Console.WriteLine("検索します。");
                    break;
                case "2":
                    Console.WriteLine("登録します。");
                    break;
                case "3":
                    Console.WriteLine("削除します。");
                    break;
                case "4":
                    Console.WriteLine("変更します。");
                    break;
                default:
                    Console.WriteLine("メニューにありません。");
                    break;
            }
        }
    }
}
