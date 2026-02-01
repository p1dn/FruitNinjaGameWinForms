using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Apple : Fruit
    {
        public Apple(Form form) : base(form)
        {
            radius = 50;
            color = Brushes.DarkRed;
            point = 2;
        }
    }
}
