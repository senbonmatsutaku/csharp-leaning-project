using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace chapter_13.domain.service.student667
{
    public class Task667 : ITask
    {
        public bool Task1(string s)
        {
            if (Regex.IsMatch(s, @".*"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Task2(string s)
        {
           if (Regex.IsMatch(s, @"A\d{1,2}"))
           {
               return true;
           }
           else
           {
               return false;
           }
        }

        public bool Task3(string s)
        {
            if (Regex.IsMatch(s, "^U[A-Z]{3}"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
