using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    public abstract class ABento
    {
        protected string Name { get; set; }
        protected int FishUsage { get; set; }
        protected int MeatUsage { get; set; }
        protected int SidedishUsage { get; set; }
        protected int Price { get; set; }
    }
}
