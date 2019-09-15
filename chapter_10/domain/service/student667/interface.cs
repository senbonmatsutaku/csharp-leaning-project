using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    public static class interface_
    {
        public interface IManagement
        {
            void story();
            Foodstuff Stocking();
            void Order(Foodstuff food);
            void TodaySales();
        }
        public interface ITask
        {
            void Run();
        }
    }
}
