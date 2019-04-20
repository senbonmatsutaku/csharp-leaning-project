using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_01.domain.service
{
    /// <summary>
    /// 課題実装部
    /// </summary>
    public class TaskServiceImplementedBy667 : ITask
    {
        // 問3
        public void LearnConstant()
        {
            int price = 100;
            double Tax = 1.08;
            double result = price * Tax;
            Console.WriteLine("商品お買い上げありがとうございます"+result+"円になります");
        }

        // 問4
        public void LearnDataType()
        {
            char moji = '侍';
            bool flg = true;
            double syosuu = 3.14;
            long largeValue = 314159265853979L;
            string moji2 = "為せば成る 為さねば成らぬ 何事も 成らぬは人の 為さぬなりけり";
            Console.WriteLine(moji);
            Console.WriteLine(flg);
            Console.WriteLine(syosuu);
            Console.WriteLine(largeValue);
            Console.WriteLine(moji2);　
        }

        // 問1
        public void LearnCsharpMechanism()
        {
            Console.WriteLine("C#は共通言語基盤（共通言語ランタイムなど）が解釈する共通中間言語にコンパイルされて実行される。自動ボックス化、デリゲート、 プロパティ、インデクサ、カスタム属性、ポインタ演算操作、構造体（値型オブジェクト）、多次元配列、可変長引数、などの機能を持つ。また、Javaと同様に大規模ライブラリ、プロセッサ・アーキテクチャに依存しない実行形態、ガベージコレクション、JITコンパイルによる実行の高速化、などが実現されている（もっともこれらはC#の機能というより.NET Frameworkによるものである）。");
        }

        // 問4
        public void LearnVariable()
        {
            int x = 3;
            int y = 5;
            int z = x * y;
            Console.WriteLine("縦"+x+"横"+y+"の長方形の面積は"+z);
        }
    }
}
