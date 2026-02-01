using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Kiwi : Fruit
    {
        public Kiwi(Form form) : base(form)
        {
            radius = 45;
            color = Brushes.LimeGreen;
        }
    }
}
