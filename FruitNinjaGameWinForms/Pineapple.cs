using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Pineapple : Fruit
    {
        public Pineapple(Form form) : base(form)
        {
            radius = 70;
            color = Brushes.LightGoldenrodYellow;
            point = 20;
        }
    }
}
