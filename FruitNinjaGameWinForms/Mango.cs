using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Mango : Fruit
    {
        public Mango(Form form) : base(form)
        {
            radius = 55;
            color = Brushes.Orange;
        }
    }
}
