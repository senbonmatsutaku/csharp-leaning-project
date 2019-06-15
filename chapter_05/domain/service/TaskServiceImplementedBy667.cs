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
            if (number > 0 && number < 10)
            {
                multiplication(number);
            }
            else
            {
                Console.Write("有効範囲外です");
            }
            
        }

        public void LearnMethod3()
        {
            int year;
            Console.Write("年数をを入力してください>");
            year = int.Parse(Console.ReadLine());
            if (year > 1899 && year < 2021)
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
            if (year > 1899 && year < 2021)
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
            double height;
            string sex;
            string age1;
            string height1;
            Console.WriteLine("名前を入力してください");
            name = Console.ReadLine();
            Console.WriteLine("年齢を入力してください");
            age1 = Console.ReadLine();
            if (int.TryParse(age1, out age))
            {
            }
            else
            {
                Console.WriteLine("数値以外が入力されています");
            }
            Console.WriteLine("身長を入力してください");
            height1 = Console.ReadLine();
            if (double.TryParse(height1, out height))
            {  
            }
            else
            {
                Console.WriteLine("数値以外が入力されています");
            }
            Console.WriteLine("性別を入力してください");
            sex = Console.ReadLine();
            if (sex.Equals("男") || sex.Equals("女"))
            {
            }
            else
            {
                Console.WriteLine("男か女以外が入力されています");
            }
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

            if (year <= 1988)
            {
                Console.WriteLine(Era);
                Console.WriteLine("0%");
                Console.WriteLine(price);
            }
            else if (year >= 1989 && year < 1997)
            {
                Console.WriteLine(Era);
                Console.WriteLine("3%");
                contax = Math.Floor(price * 0.03);
                Console.WriteLine(price + contax);
            }
            else if (year >= 1997 && year < 2014)
            {
                Console.WriteLine(Era);
                Console.WriteLine("5%");
                contax = Math.Floor(price * 0.05);
                Console.WriteLine(price + contax);
            }
            else if (year >= 2014 && year < 2019)
            {
                Console.WriteLine(Era);
                Console.WriteLine("8%");
                contax = Math.Floor(price * 0.08);
                Console.WriteLine(price + contax);
            }
            else if (year >= 2015)
            {
                Console.WriteLine(Era);
                Console.WriteLine("10%");
                contax = Math.Floor(price * 0.1);
                Console.WriteLine(price + contax);
            }

        }
        private void yourName()
        {
            string count;
            int num;
            Console.WriteLine("君の名は何回見た？");
            count = Console.ReadLine();
            if(int.TryParse(count,out num))
            {
                Console.WriteLine(count + "回");
            }
            else
            {
                Console.WriteLine("数値以外が入力されています");
            }
            

        }
        private void yourName(string name)
        {
            Console.WriteLine("私は"+ name + "です");
        }
    }
}
