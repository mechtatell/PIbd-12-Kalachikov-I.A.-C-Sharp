using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormTruck : Form
    {
        private ITransport truck;

        public FormTruck()
        {
            InitializeComponent();
        }

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            truck = new Truck(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite);
            truck.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            Render();
        }

        private void buttonCreateTanker_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            truck = new Tanker(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite, Color.Red, true, true, true, true);
            truck.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            Render();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        truck?.MoveTransport(Direction.Up);
                        break;
                    case "buttonDown":
                        truck?.MoveTransport(Direction.Down);
                        break;
                    case "buttonLeft":
                        truck?.MoveTransport(Direction.Left);
                        break;
                    case "buttonRight":
                        truck?.MoveTransport(Direction.Right);
                        break;
                }
                Render();
        }

        private void Render()
        {
            Bitmap map = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics g = Graphics.FromImage(map);
            truck?.Render(g);
            pictureBoxCar.Image = map;
        }
    }
}
