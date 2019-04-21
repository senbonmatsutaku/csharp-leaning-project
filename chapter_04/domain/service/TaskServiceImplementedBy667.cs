using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_04.domain.service
{
    public class TaskServiceImplementedBy667 : ITask
    {
        public void CountGame()
        {
        }

        public void LearnArrayDeclaration()
        {
        }

        public void LearnArrayFactorDisplay()
        {
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
            //Console.WriteLine(heights[2]);
        }
    }
}
