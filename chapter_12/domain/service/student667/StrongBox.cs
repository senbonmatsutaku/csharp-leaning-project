using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_12.domain.service.student667
{
    public class StrongBox<type>
    {
        type val;
        public void put(type val)
        {
            this.val = val;
        }
        public type get()
        {
            return val;
        }
    }
}
