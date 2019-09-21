using System;
using System.Collections.Generic;
using System.Text;
using static chapter_10.domain.service.student667.ABento;
using static chapter_10.domain.service.student667.menu;

namespace chapter_10.domain.service.student667
{
    class KatuCurry : ABento
    {
        public override string name => BentoMenu.カツカレー.ToString();
        public override int FishUsage => 10;
        public override int MeatUsage => 10;
        public override int Price => 510;
        public override int Rice => 30;
        public override int SidedishUsage => 30;
    }
}
