using System;
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
namespace chapter_13.domain.service
{
    public interface ITask
    {
        // 以下の条件とマッチする正規表現パターンを作成して、引数の文字列がマッチ/アンマッチかをtrue/falseで判定するメソッドを作成せよ

        // 問１
        // すべての文字列
        bool Task1(String s);

        // 問２
        // 最初の１文字はＡ、２文字目は数字、３文字目は数字か無し
        bool Task2(String s);

        // 問３
        // 最初の１文字はＵ、２～４文字目は英大文字
        bool Task3(String s);
    }
}
