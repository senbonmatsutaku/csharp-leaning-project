using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    interface IManagement
    {
        void story();
        void Stocking(Foodstuff food);
        void Order(Foodstuff food);
        void TodaySales();
    }
    class AManagement : IManagement
    {
        int sales;
        public void story()
        {
            Console.WriteLine("あれから１０年、俺は夢だったプロ野球選手にはなれなかった。 ");
            Console.WriteLine("けれど今は高校近くの弁当屋で甲子園を目指す球児を応援している。  ");
            Console.WriteLine("今日もたくさんの学生が弁当を買いに来るはずだ。  ");
            Console.WriteLine("高校生がお腹をすかせないよう、しっかり仕込んで、たくさん売るぞ！。  ");
        }
        public void Stocking(Foodstuff food)
        {
            System.Random r = new System.Random();
            int random = r.Next(1, 100);
            Console.WriteLine("魚を調達した。");
            food.Fish = random;
            Console.WriteLine("肉を調達した。");
            food.Meat = random;
            Console.WriteLine("惣菜を調達した。");
            random = r.Next(1, 200);
            food.SideDish = random;
            Console.WriteLine("ごはんを調達した。");
            random = r.Next(1, 300);
            food.Rice = random;
        }
        public void Order(Foodstuff food)
        {
            while (true)
            {
                System.Random r = new System.Random();
                int random = r.Next(1, 3);

                switch (random)
                {
                    case 1:
                        Console.WriteLine("のり弁当が注文されました。");
                        NoriBento noriben = new NoriBento();
                        sales = noriben.Cook(food);
                        break;
                    case 2:
                        Console.WriteLine("チキン南蛮が注文されました。");
                        ChikenNanban nanban = new ChikenNanban();
                        sales = nanban.Cook(food);
                        break;
                    case 3:
                        Console.WriteLine("カツカレーが注文されました。");
                        KatuCurry curry = new KatuCurry();
                        sales = curry.Cook(food);
                        break;
                }
                if (food.Rice <= 0 || food.Meat <= 0 || food.Fish <= 0 || food.SideDish <= 0)
                {
                    break;
                }
            }
        }
        public void TodaySales()
        {
            Console.WriteLine("本日の売り上げは" + sales + "円です。");
        }
    }
    class MyManagement : AManagement
    {
        
    }
}
