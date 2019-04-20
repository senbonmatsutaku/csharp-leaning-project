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
            Console.WriteLine("問３実行したつもり");
        }

        // 問4
        public void LearnDataType()
        {
            Console.WriteLine("問４実行したつもり");
        }

        // 問1
        public void LearnCsharpMechanism()
        {
            Console.WriteLine("C#は共通言語基盤（共通言語ランタイムなど）が解釈する共通中間言語にコンパイルされて実行される。

自動ボックス化、デリゲート、 プロパティ、インデクサ、カスタム属性、ポインタ演算操作、構造体（値型オブジェクト）、多次元配列、可変長引数、などの機能を持つ。また、Javaと同様に大規模ライブラリ、プロセッサ・アーキテクチャに依存しない実行形態、ガベージコレクション、JITコンパイルによる実行の高速化、などが実現されている（もっともこれらはC#の機能というより.NET Frameworkによるものである）。");
        }

        // 問4
        public void LearnVariable()
        {
            Console.WriteLine("問２実行したつもり");
        }
    }
}
