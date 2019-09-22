using System;
using System.Collections.Generic;
using System.Text;
using static chapter_10.domain.service.student667.ABento;
using static chapter_10.domain.service.student667.menu;

namespace chapter_10.domain.service.student667
{
    class NoriBen : ABento
    {
        public override string name => BentoMenu.のり弁当.ToString();
        public override int FishUsage => 5;
        public override int MeatUsage => 2;
        public override int SidedishUsage => 10;
        public override int Rice => 20;
        public override int Price => 420;
    }
}
