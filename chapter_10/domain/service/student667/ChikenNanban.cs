using System;
using System.Collections.Generic;
using System.Text;
using static chapter_10.domain.service.student667.ABento;
using static chapter_10.domain.service.student667.menu;

namespace chapter_10.domain.service.student667
{
    class ChikenNanban : ABento
    {
        public override int FishUsage
        {
            get
            {
                return 0;
            }
        }

        public override int MeatUsage
        {
            get
            {
                return 50;
            }
        }

        public override string name
        {
            get
            {
                return BentoMenu.チキン南蛮.ToString();
            }
        }

        public override int Price
        {
            get
            {
                return 500;
            }
        }

        public override int Rice
        {
            get
            {
                return 100;
            }
        }

        public override int SidedishUsage
        {
            get
            {
                return 50;
            }
        }
    }
}
