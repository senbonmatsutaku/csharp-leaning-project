using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_01.domain.service
{
    /// <summary>
    /// 課題実装部
    /// </summary>
    public class TaskServiceImplementedBy092 : ITask
    {
        // 問３
        public void LearnConstant()
        {
            const decimal TAX = 1.08m;
            int price = 100;
            int cost = decimal.ToInt16(price * TAX);
            Console.WriteLine("商品お買い上げありがとうございます。");
            Console.WriteLine($"{cost}円になります。");
        }

        // 問４
        public void LearnDataType()
        {
            bool flag = true;
            char character = '侍';
            double pi = 3.14;
            long largeValue = 314159265853979L;
            string saying = "為せば成る 為さねば成らぬ 何事も 成らぬは人の 為さぬなりけり";
            Console.WriteLine($"flag: {flag}");
            Console.WriteLine($"character: {character}");
            Console.WriteLine($"pi: {pi}");
            Console.WriteLine($"largeValue: {largeValue}");
            Console.WriteLine($"saying: {saying}");
        }

        // 問１
        public void LearnCsharpMechanism()
        {
            string whatsCSharp = @"
C#は共通言語基盤（共通言語ランタイムなど）が解釈する
共通中間言語にコンパイルされて実行される。
自動ボックス化、デリゲート、 プロパティ、インデクサ、
カスタム属性、ポインタ演算操作、構造体（値型オブジェクト）、
多次元配列、可変長引数、などの機能を持つ。

また、Javaと同様に大規模ライブラリ、
プロセッサ・アーキテクチャに依存しない実行形態、
ガベージコレクション、JITコンパイルによる実行の高速化、
などが実現されている
（もっともこれらはC#の機能というより.NET Frameworkによるものである）。
";
            Console.WriteLine(whatsCSharp);
        }

        // 問２
        public void LearnVariable()
        {
            int x = 3;
            int y = 5;
            int answer = x * y;
            Console.WriteLine($"縦幅 {x} 横幅 {y} の長方形の面積は、{answer}");
        }
    }
}
