using System.Windows.Forms;

namespace FruitNinjaGameWinForms
{
    public partial class FruitNinjaForm : Form
    {
        public static Random rnd { get; } = new Random();
        private List<Fruit> fruits = new List<Fruit>();
        private int score = 0;

        public FruitNinjaForm()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < rnd.Next(2, 7); i++)
            {
                SpawnFruit();
            }
        }

        private void ShowFruit(Fruit fruit)
        {
            fruit.movement.StartMoving();
            fruits.Add(fruit);
        }

        private void SpawnFruit()
        {
            switch (rnd.Next(0, 7))
            {
                case 0:
                    var watermelon = new Watermelon(this);
                    ShowFruit(watermelon);
                    break;
                case 1:
                    var apple = new Apple(this);
                    ShowFruit(apple);
                    break;
                case 2:
                    var kiwi = new Kiwi(this);
                    ShowFruit(kiwi);
                    break;
                case 3:
                    var coconut = new Coconut(this);
                    ShowFruit(coconut);
                    break;
                case 4:
                    var mango = new Mango(this);
                    ShowFruit(mango);
                    break;
                case 5:
                    var bomb = new Bomb(this);
                    ShowFruit(bomb);
                    break;
                case 6:
                    var pineapple = new Pineapple(this);
                    ShowFruit(pineapple);
                    break;
                default:
                    throw new Exception("Unknown Fruit");
            }
        }

        private void FruitNinjaForm_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (var fruit in fruits)
            {
                if (fruit.movement.IsCursorInBall(e))
                {
                    if (fruit is Bomb)
                    {
                        MessageBox.Show("Вы проиграли");
                        Close();
                    }
                    fruit.movement.HideFruit();
                    score += fruit.point;
                    scoreLabel.Text = score.ToString();
                    fruits.Remove(fruit);
                    return;
                }
            }
        }
    }
}
