using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Banana : Fruit
    {
        public Banana(Form form) : base(form)
        {
            radius = 30;
            color = Brushes.Yellow;
            point = 50;
        }
    }
}
