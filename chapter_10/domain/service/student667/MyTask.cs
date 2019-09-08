using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    interface ITask
    {
        void Run();
    }
    class MyTask : ITask
    {
        public void Run()
        {
            IManagement management = new AManagement();
            Foodstuff food = new Foodstuff();
            management.story();
            management.Stocking(food);
            management.Order(food);
            management.TodaySales();

        }
    }
}
