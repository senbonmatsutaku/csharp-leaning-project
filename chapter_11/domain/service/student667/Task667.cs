using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace chapter_11.domain.service.student667
{
    class Task667 : ITask
    {
        public void Task1()
        {
            string s;
            s = null;
            //Console.WriteLine(s.Length);
        }

        public void Task2()
        {
            try
            {
                string s;
                s = null;
                Console.WriteLine(s.Length);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("NullReferenceException例外をcatchしました。");
                Console.WriteLine("－－スタックトレース（ここから）－－");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("－－スタックトレース（ここまで）－－");
            }
        }

        public void Task3()
        {
            try
            {
                int result = Int32.Parse("三");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException例外をcatchしました。");
                Console.WriteLine("－－スタックトレース（ここから）－－");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine("－－スタックトレース（ここまで）－－");
            }
        }

        public void Task4()
        {
            throw new FileNotFoundException();
        }
    }
}
