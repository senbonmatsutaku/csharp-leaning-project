using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_04.domain.service
{
    public class TaskServiceImplementedBy092 : ITask
    {
        // 問４
        // 下記の仕様で「数当てゲーム」を作成せよ
        // 1. int型で要素数３の配列 numbers を準備、このとき初期値は 3,4,9 とする
        // 2. 画面に「１桁の数字を入力してください > 」と表示
        // 3. 数字の入力を受付、変数 input に格納
        // 4. ループで回しながら、いずれかの要素と等しければ「アタリ！」と表示
        // 5. 回答権は３回までとし、それまでに当たらなければ「ハズレ！」と表示
        public void CountGame()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("==             【数当てゲーム】           ==");
            Console.WriteLine("============================================");
            Console.WriteLine("「ルール説明」");
            Console.WriteLine("・３つの数字が配列に格納されています。");
            Console.WriteLine("・数字は０～９の何れか３つです。");
            Console.WriteLine("・３回の回答チャンスのうちに数字を当ててください。");
            Console.WriteLine("・０～９の範囲外、数字以外を入力しても１回の回答にカウントされます。");
            int[] numbers = { 3, 4, 9 };
            int chance = 3;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("１桁の数字を入力してください（あと " + chance + " 回） > ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int num))
                {
                    foreach(int number in numbers)
                    {
                        if (number.Equals(num))
                        {
                            Console.WriteLine("アタリ！");
                            Console.WriteLine("ゲームを終了します。");
                            return;
                        }
                    }
                    Console.WriteLine("ハズレ！");
                }
                else { Console.WriteLine("ハズレ！"); }
                chance--;
            }
            Console.WriteLine("ゲームを終了します。");
        }

        // 問１
        // 下記の配列を宣言せよ
        // また値の初期化は不要とする
        // 1. int 型の値を４個まとめて格納できる配列 points
        // 2. double 型の値を４個まとめて格納できる配列 weights
        // 3. boolean 型の値を４個まとめて格納できる配列 answers
        // 4. String 型の値を４個まとめて格納できる配列 names
        public void LearnArrayDeclaration()
        {
            int[] points = new int[4];
            double[] weights = new double[4];
            bool[] answers = new bool[4];
            string[] names = new string[4];
        }

        // 問２
        // 下記のプログラムを作成せよ
        // 1. ３つの口座残高「121902」「8302」「55100」が格納されている moneyList を宣言
        // 2. その配列の要素を１つずつfor文で取り出して画面に表示
        // 3. 同じ配列の要素を拡張for文で１つずつ取り出して画面に表示
        public void LearnArrayFactorDisplay()
        {
            int[] moneyList = { 121902, 8302, 55100 };
            Console.WriteLine("配列の要素を１つずつfor文で取り出して画面に表示");
            for (int i = 0; i < moneyList.Length; i++)
            {
                Console.WriteLine($"{i}番目の値：{moneyList[i]}");
            }
            Console.WriteLine("配列の要素をforeach文で１つずつ取り出して画面に表示");
            int n = 0;
            foreach (int value in moneyList)
            {
                Console.WriteLine($"{n}番目の値：{value}");
                n++;
            }
        }

        // 下記のコードを実行すると、int[]～行目とfloat[]～行目で例外が発生する
        // それぞれの例外をコード中にコメントで記述せよ
        // ex. 「ここでは～～という例外が発生します」
        // ヒント デバッグモードで動作検証するとわかりやすい
        public void WhatKindOfArraysException()
        {
            try
            {
                Console.WriteLine("下記のような処理を実行。すると…");
                Console.WriteLine("int[] count = null;");
                Console.WriteLine("Console.WriteLine(count[1]);");
                int[] count = null;
                Console.WriteLine(count[1]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ここでは {e.Message} という例外が発生します。");
            }
            try
            {
                Console.WriteLine("下記のような処理を実行。すると…");
                Console.WriteLine("float[] heights = { 171.3F, 175.0F };");
                Console.WriteLine("Console.WriteLine(heights[2]);");
                float[] heights = { 171.3F, 175.0F };
                Console.WriteLine(heights[2]);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ここでは {e.Message} という例外が発生します。");
            }
        }
    }
}
