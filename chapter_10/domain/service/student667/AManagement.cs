using System;
using System.Collections.Generic;
using System.Text;
using static chapter_10.domain.service.student667.menu;

namespace chapter_10.domain.service.student667
{
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
        public Foodstuff Stocking()
        {
            Foodstuff food = new Foodstuff();
            System.Random r = new System.Random();
            int random = r.Next(100, 100);
            Console.WriteLine("魚を調達した。");
            food.Fish = random;
            Console.WriteLine("肉を調達した。");
            food.Meat = random;
            Console.WriteLine("惣菜を調達した。");
            random = r.Next(200, 200);
            food.SideDish = random;
            Console.WriteLine("ごはんを調達した。");
            random = r.Next(300, 300);
            food.Rice = random;
            return food;
        }
        public void Order(Foodstuff food)
        {
            while (true)
            {
                System.Random r = new System.Random();
                int random = r.Next(1, 3);
                switch (random)
                {
                    case (int)BentoMenu.のり弁当:
                        NoriBen noriben = new NoriBen();
                        food.Rice -= noriben.Rice;
                        food.SideDish -= noriben.SidedishUsage;
                        food.Fish -= noriben.FishUsage;
                        sales += noriben.Price;
                        Console.WriteLine(noriben.name + "が注文されました");
                        break;
                    case (int)BentoMenu.チキン南蛮:
                        ChikenNanban nanban = new ChikenNanban();
                        food.Rice -= nanban.Rice;
                        food.SideDish -= nanban.SidedishUsage;
                        food.Meat -= nanban.MeatUsage;
                        sales += nanban.Price;
                        Console.WriteLine(nanban.name + "が注文されました");
                        break;
                    case (int)BentoMenu.カツカレー:
                        KatuCurry curry = new KatuCurry();
                        food.Rice -= curry.Rice;
                        food.SideDish -= curry.SidedishUsage;
                        sales += curry.Price;
                        Console.WriteLine(curry.name + "が注文されました");
                        break;
                }
                if (food.Rice <= 0 || food.Meat <= 0 || food.Fish <= 0 || food.SideDish <= 0)
                {
                    Console.WriteLine("材料がなくなりました。");
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
