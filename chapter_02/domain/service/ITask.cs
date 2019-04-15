﻿using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// 課題インターフェース
/// 
/// ここにコメント形式で課題内容とメソッドが定義されるので
/// 学習者はメソッド内容を実装することで学習を進める
/// </summary>
/// <remarks>
/// @author kanekos
/// </remarks>
namespace chapter_02.domain.service
{
    interface ITask
    {
        // 問１
        // 現在すでに処理は実装されている。
        // しかし、動作させると「x + y = 23」と表示されてしまう。
        // 「x + y = 5」と表示されるように修正せよ。
        void LearnOperatorPriority();

        // 問２
        // 次の中で文法として正しいものをすべて表示せよ。
        // 回答例. 「正しい文は①, ②, ③です。」
        // ①int x = 1 + 2.0;
        // ②double d = 4.0F
        // ③int i = "9";
        // ④String s = 3 + " days";
        // ⑤byte b = 7;
        // ⑥double d = true;
        // ⑦short s = (byte)2;
        void LearnTypeConversion();

        // 問３
        // 以下の内容のプログラムを作成せよ。
        // 1. 画面に「ようこそ占いの館へ」と表示
        // 2. 画面に「あなたの名前を入力してください」と表示
        // 3. キーボードから１行の文字入力を受け付け、String型の変数nameに格納
        // 4. 画面に「あなたの年齢を入力してください」と表示
        // 5. キーボードから１行の文字入力を受け付け、String型の変数ageStringに格納
        // 6. 変数ageStringの内容をint型に変換し、int型の変数ageに代入
        // 7. ０から３までの乱数を生成し、int型の変数fortuneに代入
        // 8. fortuneの数値をインクリメント演算子で１増やし、１から４の乱数する
        // 9. 画面に「占いの結果が出ました！」と表示
        // 10. 画面に「(年齢)歳の(名前)さん、あなたの運気番号は(乱数)です。」と表示 ※カッコの中身は変数
        // 11. 画面に「1:大吉 2:中吉 3:吉 4:凶」と表示
        // ヒント：
        //   文字入力受付  Console.ReadLine();
        //   ランダム生成  new System.Random();
        void FortuneGame();
    }
}
