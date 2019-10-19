using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_12.domain.service.student667
{
    class Task667 : ITask
    {
        public void Task1()
        {
            StrongBox<int> box = new StrongBox<int>();
            box.put(2);
            Console.WriteLine(box.get());
        }

        public void Task2()
        {
            return;
        }
    }
    
}
