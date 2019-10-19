using System;
using System.Collections.Generic;
using System.Text;

namespace chapter_12.domain.service.student667
{
    public class ExitYutoriSan
    {
        public void study()
        {
            AreaCalculation<double> calc = new AreaCalculation<double>();
            Console.WriteLine("半径10の円の面積は" + calc.CalcCircleArea(10, 3.14) + "です。");
        }
    }
}
