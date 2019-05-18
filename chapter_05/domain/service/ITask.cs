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
namespace chapter_05.domain.service
{
    interface ITask
    {
        // 問１
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：selfIntroduction
        // 戻り値    ：なし
        // 引数      ：なし
        // 処理内容  ：名前、年齢、身長、性別(男/女)を入力させ、入力値をそれぞれ変数に格納して結果を画面に表示
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        void LearnMethod1();

        // 問２
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：multiplication
        // 戻り値    ：なし
        // 引数      ：１から９の整数
        // 処理内容  ：引数で受け取った数字の段の九九を画面に表示
        // 九九の結果を配列に格納した後で結果を表示すること
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        void LearnMethod2();

        // 問３
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：yearToEra
        // 戻り値    ：元号
        // 引数      ：西暦(1900-2020)
        // 処理内容  ：西暦を入力させ、その年の元号を表示
        // 西暦別の年号は下記の通りとする
        // 1911年まで:明治, 1925年まで:大正, 1988年まで:昭和, 2018年まで:平成, 2019年以降:令和
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        void LearnMethod3();

        // 問４
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：taxCalculation
        // 戻り値    ：なし
        // 引数      ：西暦(1900-2020), 商品価格
        // 処理内容  ：西暦、商品の価格を入力させ、その年の元号、消費税率、消費税を加味した代金を表示
        // 西暦別の消費税は下記の通りとする
        // 1988年まで:0%, 1989年以降:3%, 1997年以降:5%, 2014年以降:8%, 2019年以降:10%
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        void LearnMethod4();

        // 問５
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：yourName
        // 戻り値    ：任意
        // 引数      ：任意
        // 処理内容  ：オーバーロードの概念を用いてそれぞれ下記の処理を実装せよ
        // 1. 君の名は何回見た？と質問 → 映画「君の名は」を見た回数を表示
        // 2. 君の名は？と質問 → 私は〇〇です。と表示
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        void LearnMethod5();
    }
}