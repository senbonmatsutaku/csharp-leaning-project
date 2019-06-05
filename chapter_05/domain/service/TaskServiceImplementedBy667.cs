using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_05.domain.service
{
    public class TaskServiceImplementedBy667 : ITask
    {
        public void LearnMethod1()
        {
            selfIntroduction();
        }

        public void LearnMethod2()
        {
            int number;
            Console.Write("数字を入力してください>");
            number = int.Parse(Console.ReadLine());
            multiplication(number);
        }

        public void LearnMethod3()
        {
            int year;
            Console.Write("年数をを入力してください>");
            year = int.Parse(Console.ReadLine());
            if (year > 1900 && year < 2021)
            {
                Console.WriteLine(yearToEra(year));
            }
            else
            {
                Console.WriteLine("1900-2020の間ではありません");
            }
        }

        public void LearnMethod4()
        {
            int year;
            int price;
            Console.Write("西暦を入力してください>");
            year = int.Parse(Console.ReadLine());
            Console.Write("値段を入力してください>");
            price = int.Parse(Console.ReadLine());
            if (year > 1900 && year < 2021)
            {
                taxCalculation(year, price);
            }
            else
            {
                Console.WriteLine("1900-2020の間ではありません。");
            }
        }

        public void LearnMethod5()
        {
            string name;
            yourName();
            Console.Write("君の名は？>");
            name = Console.ReadLine();
            yourName(name);
        }
        private void selfIntroduction()
        {
            string name;
            int age;
            float height;
            string sex;
            Console.WriteLine("名前を入力してください");
            name = Console.ReadLine();
            Console.WriteLine("年齢を入力してください");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("身長を入力してください");
            height = float.Parse(Console.ReadLine());
            Console.WriteLine("性別を入力してください");
            sex = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(height);
            Console.WriteLine(sex);
        }
        private void multiplication(int num)
        {
            int[] result = new int[9];
            for (int i = 1; i<=9; i++)
            {
                result[i-1] = num * i;
            }
            for(int j=1; j <= 9; j++)
            {
                Console.WriteLine(num + "の段の計算結果→" + num + "×" + j + "=" + result[j - 1]);
            }
        }
        private string yearToEra(int year)
        {
            if (year <= 1911)
            {
                return "明治";
            }
            else if (year <= 1925)
            {
                return "大正";
            }
            else if (year <= 1988)
            {
                return "昭和";
            }
            else if (year <= 2018)
            {
                return "平成";
            }
            else
            {
                return "令和";
            }

        }
        private void taxCalculation(int year,float price)
        {
            double contax;
            string Era = yearToEra(year);

            if (Era == "明治")
            {
                Console.WriteLine("明治");
                Console.WriteLine("0%");
                Console.WriteLine(price);
            }
            else if (Era == "大正")
            {
                Console.WriteLine("大正");
                Console.WriteLine("3%");
                contax = Math.Ceiling(price * 0.03);
                Console.WriteLine(price + contax);
            }
            else if(Era == "昭和")
            {
                Console.WriteLine("昭和");
                Console.WriteLine("5%");
                contax = Math.Ceiling(price * 0.05);
                Console.WriteLine(price + contax);
            }
            else if(Era == "平成")
            {
                Console.WriteLine("平成");
                Console.WriteLine("8%");
                contax = Math.Ceiling(price * 0.08);
                Console.WriteLine(price + contax);
            }
            else
            {
                Console.WriteLine("令和");
                Console.WriteLine("10%");
                contax = Math.Ceiling(price * 0.1);
                Console.WriteLine(price + contax);
            }

        }
        private void yourName()
        {
            int count;
            Console.WriteLine("君の名は何回見た？");
            count = int.Parse(Console.ReadLine());
            Console.WriteLine(count + "回");

        }
        private void yourName(string name)
        {
            Console.WriteLine("私は"+ name + "です");
        }
    }
}
