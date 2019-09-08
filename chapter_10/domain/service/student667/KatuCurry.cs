using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    class KatuCurry : ABento
    {
        internal int Cook(Foodstuff f)
        {
            try
            {
                f.Rice -= 100;
                f.SideDish -= 50;
                f.Meat -= 50;
            }
            catch
            {
                Console.WriteLine("材料が切れました。");
                return 0;
            }
            Console.WriteLine("カツカレーが売れました。");
            return 700;
        }
    }
}
