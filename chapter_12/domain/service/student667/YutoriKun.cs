using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_12.domain.service.student667
{
    public class YutoriKun
    {
        int area;
        public void study()
        {
            AreaCalculation<int> calc = new AreaCalculation<int>();
            Console.WriteLine("半径10の円の面積は" + calc.CalcCircleArea(10, 3) + "です。");
        }
    }
}
