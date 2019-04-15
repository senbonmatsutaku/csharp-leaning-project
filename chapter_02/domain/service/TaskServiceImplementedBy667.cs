using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_02.domain.service
{
    public class TaskServiceImplementedBy667 : ITask
    {
        public void FortuneGame()
        {
        }

        public void LearnOperatorPriority()
        {
            int x = 2;
            int y = 3;
            String answer = "x + y = " + x + y;
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
            Console.WriteLine(answer);
        }

        public void LearnTypeConversion()
        {
        }
    }
}
