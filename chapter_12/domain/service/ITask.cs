﻿using System;
using System.Collections.Generic;
using System.Text;

/**
 * 課題インターフェース
 *
 * ここにコメント形式で課題内容とメソッドが定義されるので
 * 学習者はメソッド内容を実装することで学習を進める
 *
 * @author kanekos
 *
 */
namespace chapter_12.domain.service
{
    interface ITask
    {
        // 問１
        // 以下の仕様に従った金庫をStrongBoxクラスとして定義せよ
        // ・金庫クラスに格納するインスタンスの型は開発時には未定である
        // ・金庫には、１つのインスタンスを保存できる必要がある
        // ・put()でインスタンスを保存し、get()でインスタンスを取得できる
        // ・get()で取得する際、キャストを使わなくても格納前の型に代入できる
        void Task1();

        // 問2
        // 以下の仕様に従ったクラスたちを定義せよ
        // ・面積を計算するクラスをAreaCalculationクラスとして定義せよ
        // ・面積計算クラスに円の面積を求めるメソッドとしてCalcCircleAreaを用意せよ
        // ・円の面積を求めるメソッドは引数に半径、円周率を持つ
        // ・円周率は３．１４と３のどちらも扱えるようにしておき、最適な型を割り当てることが出来るものとする
        // ・面積を計算するクラスを利用するものとしてゆとりくんクラス（YutoriKun）と脱ゆとりさんクラス（ExitYutoriSan）を定義せよ
        // ・ゆとりくんクラス（YutoriKun）と脱ゆとりさんクラス（ExitYutoriSan）に勉強メソッドとしてStudyを用意せよ
        // ・勉強メソッドを実行するとAreaCalculationクラスから円の面積を求めるものとする。
        // ・ゆとりくんクラス（YutoriKun）が勉強メソッドを実行すると半径は任意の値、円周率は３で計算される。
        // ・脱ゆとりさんクラス（ExitYutoriSan）が勉強メソッドを実行すると半径は任意の値、円周率は３。１４で計算される。
        void Task2();
    }
}
