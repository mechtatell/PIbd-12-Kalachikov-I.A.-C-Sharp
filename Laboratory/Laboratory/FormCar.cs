using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormCar : Form
    {
        private ITransport car;
        public FormCar()
        {
            InitializeComponent();
        }

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            car = new Truck(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite);
            car.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            Render();
        }

        private void buttonCreateTanker_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            car = new Tanker(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite, Color.Red, true, true, true, true);
            car.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            Render();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (car != null)
            {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        car.MoveTransport(Direction.Up);
                        break;
                    case "buttonDown":
                        car.MoveTransport(Direction.Down);
                        break;
                    case "buttonLeft":
                        car.MoveTransport(Direction.Left);
                        break;
                    case "buttonRight":
                        car.MoveTransport(Direction.Right);
                        break;
                }
                Render();
            }
        }

        private void Render()
        {
            Bitmap map = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics g = Graphics.FromImage(map);
            car.Render(g);
            pictureBoxCar.Image = map;
        }
    }
}
