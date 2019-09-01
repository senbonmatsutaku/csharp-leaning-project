using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    interface IManagement
    {
        void story();
        void Stocking();
        void Order();
        void TodaySales();
    }
    enum Menu
    {
        のり弁当,
        チキン南蛮,
        カツカレー
    }
    class AManagement : Foodstuff,IManagement
    {
        int sales;
        public void story()
        {
            Console.WriteLine("あれから１０年、俺は夢だったプロ野球選手にはなれなかった。 ");
            Console.WriteLine("けれど今は高校近くの弁当屋で甲子園を目指す球児を応援している。  ");
            Console.WriteLine("今日もたくさんの学生が弁当を買いに来るはずだ。  ");
            Console.WriteLine("高校生がお腹をすかせないよう、しっかり仕込んで、たくさん売るぞ！。  ");
        }
        public void Stocking()
        {
            Console.WriteLine("魚を調達した。");
            Fish = 100;
            Console.WriteLine("肉を調達した。");
            Meat = 100;
            Console.WriteLine("惣菜を調達した。");
            SideDish = 200;
            Console.WriteLine("ごはんを調達した。");
            Rice = 300;

        }
        public void Order()
        {
            while (true)
            {
                System.Random r = new System.Random();
                int random = r.Next(1, 3);
                switch (random)
                {
                    case (int)Menu.のり弁当:
                        Console.WriteLine("のり弁当が注文されました。");
                        Rice = Rice - 100;
                        Fish = Fish - 50;
                        Meat = Meat - 50;
                        sales = sales + 500;
                        break;
                    case (int)Menu.チキン南蛮:
                        Console.WriteLine("チキン南蛮が注文されました。");
                        Rice = Rice - 100;
                        SideDish = SideDish - 50;
                        Meat = Meat - 50;
                        sales = sales + 600;
                        break;
                    case (int)Menu.カツカレー:
                        Console.WriteLine("カツカレーが注文されました。");
                        Rice = Rice - 100;
                        SideDish = SideDish - 50;
                        Meat = Meat - 50;
                        sales = sales + 700;
                        break;
                }
                if (Rice <= 0 || SideDish <= 0 || Meat <= 0 || Fish <= 0)
                {
                    break;
                }
            }
        }
        public void TodaySales()
        {
            AManagement Management = new AManagement();
            Console.WriteLine("本日の売り上げは" + sales + "円です。");
        }
    }
    class MyManagement : AManagement
    {
        
    }
}
