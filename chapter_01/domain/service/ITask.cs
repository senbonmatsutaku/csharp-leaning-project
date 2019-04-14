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
namespace chapter_01.domain.service
{
    interface ITask
    {
        // 問１
        // Java WikipediaのサイトからJavaの仕組みをコンソールに出力せよ。
        // なお、出力する文章は「Javaプログラムは～～仕組みとなっている。」の部分とする。
        // url: https://ja.wikipedia.org/wiki/Java
        void learnJavaMechanism();

        // 問２
        // 画面に３×５を表示するコードを作成せよ。
        // ロジック内で変数 x に３、変数 y に５、変数 z に解を設定して下記のように表示すること。
        // 縦幅 3 横幅 5 の長方形の面積は、15
        void learnVariable();

        // 問３
        // １００円の商品を買ったときに支払う料金を表示するコードを作成せよ。
        // 消費税率は８％で、定数名は TAX と定義すること。
        // 表示内容は下記とする。
        // 商品お買い上げありがとうございます。108円になります。
        void learnConstant();

        // 問４
        // 以下に示した値を格納するために適した型を考え定義して表示せよ。
        // 格納用の変数名は任意とする。(ただしJavaのルールに従うこと)
        // ２つ以上の型が考えられる場合は、どちらでも良いこととする。
        // 1. true
        // 2. '侍'
        // 3. 3.14
        // 4. 314159265853979L
        // 5. "為せば成る 為さねば成らぬ 何事も 成らぬは人の 為さぬなりけり"
        void learnDataType();
    }
}
