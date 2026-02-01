namespace FruitNinjaGameWinForms
{
    public partial class FruitNinjaForm : Form
    {
        public static Random rnd { get; } = new Random();
        public List<Fruit> fruits = new List<Fruit>();

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

        private void SpawnFruit()
        {
            switch (rnd.Next(0, 6))
            {
                case 0:
                    var watermelon = new Watermelon(this);
                    watermelon.movement.StartMoving();
                    fruits.Add(watermelon);
                    break;
                case 1:
                    var apple = new Apple(this);
                    apple.movement.StartMoving();
                    fruits.Add(apple);
                    break;
                case 2:
                    var kiwi = new Kiwi(this);
                    kiwi.movement.StartMoving();
                    fruits.Add(kiwi);
                    break;
                case 3:
                    var coconut = new Coconut(this);
                    coconut.movement.StartMoving();
                    fruits.Add(coconut);
                    break;
                case 4:
                    var mango = new Mango(this);
                    mango.movement.StartMoving();
                    fruits.Add(mango);
                    break;
                default:
                    var pineapple = new Pineapple(this);
                    pineapple.movement.StartMoving();
                    fruits.Add(pineapple);
                    break;
            }
        }
    }
}
