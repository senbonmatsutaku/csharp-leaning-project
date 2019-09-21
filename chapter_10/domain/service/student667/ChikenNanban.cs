using System;
using System.Collections.Generic;
using System.Text;
using static chapter_10.domain.service.student667.ABento;
using static chapter_10.domain.service.student667.menu;

namespace chapter_10.domain.service.student667
{
    class ChikenNanban : ABento
    {
        public override string name => BentoMenu.チキン南蛮.ToString();
        public override int FishUsage => 0;
        public override int MeatUsage => 20;
        public override int SidedishUsage => 20;
        public override int Rice => 10;
        public override int Price => 450;
    }
}
