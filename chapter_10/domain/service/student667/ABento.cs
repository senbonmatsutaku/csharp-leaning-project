using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_10.domain.service.student667
{
    public abstract class ABento
    {
        abstract public string name { get; }
        abstract public int FishUsage { get; }
        abstract public int MeatUsage { get; }
        abstract public int SidedishUsage { get; }
        abstract public int Rice { get; }
        abstract public int Price { get; }
    }
}
