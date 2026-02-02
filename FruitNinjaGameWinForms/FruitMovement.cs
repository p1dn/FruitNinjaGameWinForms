using System;
using System.Collections.Generic;
using System.Text;

namespace FruitNinjaGameWinForms
{
    public class FruitMovement
    {
        private Fruit fruit;
        private Form form;

        public System.Windows.Forms.Timer timer;

        private float xFall;
        private float yFall;

        private float g = 0.2f;

        public FruitMovement(Fruit fruit, Form form)
        {
            this.fruit = fruit;
            this.form = form;

            xFall = FruitNinjaForm.rnd.Next(-5, 5);
            yFall = -FruitNinjaForm.rnd.Next(12, 18);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = 10;
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e) => Move();

        public void StopMoving() => timer.Stop();

        public void StartMoving() => timer.Start();

        public void HideLastFruit()
        {
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
        }

        private void Go()
        {
            fruit.centerX += xFall;
            fruit.centerY += yFall;
            yFall += g;
        }

        private void Show() => Draw(fruit.color);

        private void Move()
        {
            HideLastFruit();
            Go();
            Show();
        }

        private void Draw(Brush color)
        {
            var graphics = form.CreateGraphics();
            var rectangle = new RectangleF(fruit.centerX - fruit.radius, fruit.centerY - fruit.radius, 2 * fruit.radius, 2 * fruit.radius);

            graphics.FillEllipse(color, rectangle);
        }

        public bool IsCursorInBall(MouseEventArgs e)
        {
            float mx = e.X - fruit.centerX;
            float my = e.Y - fruit.centerY;

            return mx * mx + my * my <= fruit.radius * fruit.radius && IsMoving();
        }

        public void HideFruit()
        {
            timer.Stop();
            HideLastFruit();
        }

        public bool IsMoving()
        {
            return timer.Enabled;
        }
    }
}
