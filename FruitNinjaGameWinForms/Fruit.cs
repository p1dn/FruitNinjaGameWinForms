using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class Fruit
    {
        private Form form;
        public FruitMovement movement { get; set; }

        public float centerX { get; set; }
        public float centerY { get; set; }

        public int radius { get; protected set; }
        public Brush color { get; protected set; }

        public Fruit(Form form)
        {
            this.form = form;
            movement = new FruitMovement(this, form);

            centerX = FruitNinjaForm.rnd.Next(form.ClientSize.Width / 2 - 150, form.ClientSize.Width / 2 + 150);
            centerY = form.ClientSize.Height - 50;
        }
    }
}
