using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Coconut : Fruit
    {
        public Coconut(Form form) : base(form)
        {
            radius = 65;
            color = Brushes.Peru;
        }
    }
}
