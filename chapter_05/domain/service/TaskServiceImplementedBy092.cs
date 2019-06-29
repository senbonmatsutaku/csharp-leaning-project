using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_05.domain.service
{
    public class TaskServiceImplementedBy092 : ITask
    {
        // 問１
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：selfIntroduction
        // 戻り値    ：なし
        // 引数      ：なし
        // 処理内容  ：名前、年齢、身長、性別(男/女)を入力させ、入力値をそれぞれ変数に格納して結果を画面に表示
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        public void LearnMethod1()
        {
            SelfIntroduction();
        }

        /// <summary>
        /// 自己紹介関数
        /// </summary>
        private void SelfIntroduction()
        {
            Console.Write("名前を入力してください。 > ");
            string name = Console.ReadLine();

            Console.Write("年齢を入力してください。 > ");
            string inputAge = Console.ReadLine();
            if (!int.TryParse(inputAge, out int age))
            {
                Console.WriteLine("整数で入力してください。");
                return;
            }

            Console.Write("身長を入力してください。 > ");
            string inputHeight = Console.ReadLine();
            if (!double.TryParse(inputHeight, out double height))
            {
                Console.WriteLine("数値(少数OK)で入力してください。");
                return;
            }

            Console.Write("性別(男/女)を入力してください。 > ");
            string sex = Console.ReadLine();
            if (!sex.Equals("男") && !sex.Equals("女"))
            {
                Console.WriteLine("男か女で入力してください。");
                return;
            }

            Console.WriteLine("[結果]");
            Console.WriteLine($"名前：{name}さん");
            Console.WriteLine($"年齢：{age}歳");
            Console.WriteLine($"身長：{height}cm");
            Console.WriteLine($"性別：{sex}");
        }

        // 問２
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：Multiplication
        // 戻り値    ：なし
        // 引数      ：１から９の整数
        // 処理内容  ：引数で受け取った数字の段の九九を画面に表示
        // 九九の結果を配列に格納した後で結果を表示すること
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        public void LearnMethod2()
        {
            Console.WriteLine("引数で受け取った数字で九九を表示します。");
            Console.Write("１から９の整数を入力してください。 > ");
            string inputValue = Console.ReadLine();
            if (!IsLearnMethod2Validation(inputValue))
            {
                return;
            }
            Multiplication(inputValue);
        }

        /// <summary>
        /// 問２の検証関数
        /// </summary>
        /// <param name="value">判定する値</param>
        /// <returns>検証ＯＫならTure、検証ＮＧならfalseを返す</returns>
        private bool IsLearnMethod2Validation(string value)
        {
            if (!int.TryParse(value, out int v))
            {
                Console.WriteLine("整数で入力してください。");
                return false;
            }
            const int RANGE_MIN = 1;
            const int RANGE_MAX = 9;
            return IsRangeIn(v, RANGE_MIN, RANGE_MAX);
        }

        /// <summary>
        /// 範囲内判定関数
        /// </summary>
        /// <param name="value">判定する値</param>
        /// <param name="rangeMin">最小範囲</param>
        /// <param name="rangeMax">最大範囲</param>
        /// <returns>範囲内ならtrue、範囲外ならfalseを返す</returns>
        private bool IsRangeIn(int value, int rangeMin, int rangeMax)
        {
            if (value < rangeMin || value > rangeMax)
            {
                Console.WriteLine($"{rangeMin}から{rangeMax}の範囲の整数で入力してください。");
                return false;
            }
            return true;
        }

        /**
         * 九九表示関数
         * @param value 掛け算の段（１の段から９の段まで）
         */
        private void Multiplication(string value)
        {
            const int ELEMENT_COUNT = 9;
            // 掛ける数
            int multiplier = int.Parse(value);
            int[] answers = new int[ELEMENT_COUNT];
            for (int i = 0; i < ELEMENT_COUNT; i++)
            {
                answers[i] = multiplier * (i + 1);
            }
            // 掛けられる数
            int multiplicand = 0;
            foreach (int answer in answers)
            {
                multiplicand++;
                Console.WriteLine(multiplier + " × " + multiplicand + " = " + answer);
            }
        }

        // 問３
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：YearToEra
        // 戻り値    ：元号
        // 引数      ：西暦(1900-2020)
        // 処理内容  ：西暦を入力させ、その年の元号を表示
        // 西暦別の年号は下記の通りとする
        // 1911年まで:明治, 1925年まで:大正, 1988年まで:昭和, 2018年まで:平成, 2019年以降:令和
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        public void LearnMethod3()
        {
            Console.WriteLine("引数で受け取った西暦の元号を判定します。");
            Console.Write("西暦(1900-2020)を入力してください。 > ");
            string inputValue = Console.ReadLine();
            string era = YearToEra(inputValue);
            if (era != null)
            {
                Console.WriteLine(inputValue + "年の元号は" + era + "です。");
            }
        }

        /// <summary>
        /// 問３の検証関数
        /// </summary>
        /// <param name="value">判定する値</param>
        /// <returns>検証ＯＫならTure、検証ＮＧならfalseを返す</returns>
        private bool IsLearnMethod3Validation(string value)
        {
            if (!int.TryParse(value,out int v))
            {
                Console.WriteLine("整数で入力してください。");
                return false;
            }
            const int RANGE_MIN = 1900;
            const int RANGE_MAX = 2020;
            return IsRangeIn(v, RANGE_MIN, RANGE_MAX);
        }

        /// <summary>
        /// 西暦→年号変換関数
        /// </summary>
        /// <param name="value">判定する値</param>
        /// <returns>西暦を判定して年号を返す。正常に判定できない場合、nullを返す</returns>
        private string YearToEra(string value)
        {
            if (!IsLearnMethod3Validation(value))
            {
                return null;
            }
            int year = int.Parse(value);
            string era;
            const int MEIJI = 1911;
            const int TAISHO = 1925;
            const int SHOWA = 1988;
            const int HEISEI = 2018;
            if (year <= MEIJI)
            {
                era = "明治";
            }
            else if (year <= TAISHO)
            {
                era = "大正";
            }
            else if (year <= SHOWA)
            {
                era = "昭和";
            }
            else if (year <= HEISEI)
            {
                era = "平成";
            }
            else
            {
                era = "令和";
            }
            return era;
        }

        // 問４
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：TaxCalculation
        // 戻り値    ：なし
        // 引数      ：西暦(1900-2020), 商品価格
        // 処理内容  ：西暦、商品の価格を入力させ、その年の元号、消費税率、消費税を加味した代金を表示
        // 西暦別の消費税は下記の通りとする
        // 1988年まで:0%, 1989年以降:3%, 1997年以降:5%, 2014年以降:8%, 2019年以降:10%
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        public void LearnMethod4()
        {
            Console.WriteLine("引数で受け取った西暦の元号及び消費税を判定します。");
            Console.Write("西暦(1900-2020)を入力してください。 > ");
            string year = Console.ReadLine();
            Console.Write("商品価格を入力してください。 > ");
            string price = Console.ReadLine();
            TaxCalculation(year, price);
        }

        /**
         * 西暦、商品の価格を入力させ、その年の元号、消費税率、消費税を加味した代金を表示する関数
         * @param year 西暦
         * @param price 商品価格
         */
        private void TaxCalculation(string year, string price)
        {
            string era = YearToEra(year);
            if (era == null)
            {
                Console.WriteLine("西暦入力が誤っています。");
                return;
            }
            double? tax = getTax(year);
            if (tax == null)
            {
                Console.WriteLine("西暦入力が誤っています。");
                return;
            }
            if (!int.TryParse(price,out int _price))
            {
                Console.WriteLine("商品価格入力が誤っています。");
                return;
            }
            int taxPercent = (int)(tax * 100);
            int cost = (int)(_price * (1+ tax));
            Console.WriteLine("[結果]");
            Console.WriteLine("西暦：" + year + "年");
            Console.WriteLine("元号：" + era);
            Console.WriteLine("価格：" + price + "円");
            Console.WriteLine("税率：" + taxPercent + "%");
            Console.WriteLine("税込：" + cost + "円");
        }

        /// <summary>
        /// 消費税取得関数
        /// </summary>
        /// <param name="year">西暦</param>
        /// <returns>入力した西暦を判定して消費税を返す、エラー時はnullを返す</returns>
        private double? getTax(string year)
        {
            if (!int.TryParse(year, out int y)) { return null; }

            // 1988年まで:0%, 1989年以降:3%, 1997年以降:5%, 2014年以降:8%, 2019年以降:10%
            const int TAX10_START_YEAR = 2019;
            const int TAX8_START_YEAR = 2014;
            const int TAX5_START_YEAR = 1997;
            const int TAX3_START_YEAR = 1989;
            const double TAX10 = 0.1;
            const double TAX8 = 0.08;
            const double TAX5 = 0.05;
            const double TAX3 = 0.03;
            const double TAX_FREE = 0;
            if (y >= TAX10_START_YEAR)
            {
                return TAX10;
            }
            else if (y >= TAX8_START_YEAR)
            {
                return TAX8;
            }
            else if (y >= TAX5_START_YEAR)
            {
                return TAX5;
            }
            else if (y >= TAX3_START_YEAR)
            {
                return TAX3;
            }
            else
            {
                return TAX_FREE;
            }
        }

        // 問５
        // 下記のメソッドを作成せよ
        // 適用範囲  ：private
        // メソッド名：YourName
        // 戻り値    ：任意
        // 引数      ：任意
        // 処理内容  ：オーバーロードの概念を用いてそれぞれ下記の処理を実装せよ
        // 1. 君の名は何回見た？と質問 → 映画「君の名は」を見た回数を表示
        // 2. 君の名は？と質問 → 私は〇〇です。と表示
        // 変数の型はふさわしいものを定義すること、最低限の入力チェックは行うこと
        public void LearnMethod5()
        {
            Console.Write("君の名は何回見た？ > ");
            string value = Console.ReadLine();
            if (!int.TryParse(value,out int watchingTimes))
            {
                Console.WriteLine("整数で入力してください。");
                return;
            }
            YourName(watchingTimes);

            Console.Write("君の名は？ > ");
            string name = Console.ReadLine();
            YourName(name);
        }

        /// <summary>
        /// 映画「君の名は」の視聴回数を表示する
        /// </summary>
        /// <param name="watchingTimes">視聴回数</param>
        private void YourName(int watchingTimes)
        {
            Console.WriteLine($"自慢じゃないが、もう{watchingTimes}回は見たね！");
        }

        /// <summary>
        /// 名前を表示する
        /// </summary>
        /// <param name="name">名前</param>
        private void YourName(string name)
        {
            Console.WriteLine($"私の名は{name}です。");
        }
    }
}
