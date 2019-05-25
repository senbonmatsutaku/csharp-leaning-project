using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_04.domain.service
{
    public class TaskServiceImplementedBy667 : ITask
    {
        public void CountGame()
        {
            int[] numbers = { 3, 4, 9 };
            Console.Write("１桁の数字を入力してください >");
            var input = int.Parse(Console.ReadLine());
            for(int i=0; i<2; i++)
            {
                for (int j = 0; j <= 2; j++)
                {
                    if (numbers[j] == input)
                    {
                        Console.WriteLine("アタリ");
                        return;
                    }
                }
                Console.WriteLine("ハズレ");
                Console.Write("１桁の数字を入力してください >");
                input = int.Parse(Console.ReadLine());
            }
        }

        public void LearnArrayDeclaration()
        {
            int[] points = new int[4];
            double[] weights = new double[4];
            bool[] answers = new bool[4];
            String[] names = new String[4];
        }

        public void LearnArrayFactorDisplay()
        {
            int[] moneyList = { 121902, 8302, 55100 };
            for(int i = 0; i<3; i++)
            {
                Console.WriteLine(moneyList[i]);
            }
        }

        // 下記のコードを実行すると、29行目と30行目で例外が発生する
        // それぞれの例外をコード中にコメントで記述せよ
        // ex. 「ここでは～～という例外が発生します」
        // ヒント デバッグモードで動作検証するとわかりやすい
        public void WhatKindOfArraysException()
        {
            int[] count = null;
            float[] heights = { 171.3F, 175.0F };
            //Console.WriteLine(count[1]);
            Console.WriteLine("ここではSystem.NullReferenceExceptionという例外が発生"); 
            //Console.WriteLine(heights[2]);
            Console.WriteLine("ここではSystem.IndexOutOfRangeExceptionという例外が発生");
        }
    }
}
