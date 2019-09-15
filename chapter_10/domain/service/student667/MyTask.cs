using System;
using System.Collections.Generic;
using System.Text;
using static chapter_10.domain.service.student667.interface_;

namespace chapter_10.domain.service.student667
{
    class MyTask : ITask
    {
        public void Run()
        {
            IManagement management = new AManagement();
            Foodstuff food = new Foodstuff();
            management.story();
            management.Stocking();
            management.Order(food);
            management.TodaySales();

        }
    }
}
