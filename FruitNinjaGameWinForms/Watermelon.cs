using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Watermelon : Fruit
    {
        public Watermelon(Form form) : base(form)
        {
            radius = 100;
            color = Brushes.DarkGreen;
        }
    }
}
