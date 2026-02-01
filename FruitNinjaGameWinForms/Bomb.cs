using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Bomb : Fruit
    {
        public Bomb(Form form) : base(form)
        {
            radius = 60;
            color = Brushes.Black;
        }
    }
}
