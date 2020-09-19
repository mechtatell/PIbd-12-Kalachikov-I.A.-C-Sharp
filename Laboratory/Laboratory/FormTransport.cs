using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormTransport : Form
    {
        private ITransport transport;

        public FormTransport()
        {
            InitializeComponent();
        }

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            transport = new Truck(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite);
            transport.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            Render();
        }

        private void buttonCreateTanker_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            transport = new Tanker(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite, Color.Red, true, true, true, true);
            transport.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            Render();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (transport != null)
            {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        transport.MoveTransport(Direction.Up);
                        break;
                    case "buttonDown":
                        transport.MoveTransport(Direction.Down);
                        break;
                    case "buttonLeft":
                        transport.MoveTransport(Direction.Left);
                        break;
                    case "buttonRight":
                        transport.MoveTransport(Direction.Right);
                        break;
                }
                Render();
            }
        }

        private void Render()
        {
            Bitmap map = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
            Graphics g = Graphics.FromImage(map);
            transport.Render(g);
            pictureBoxCar.Image = map;
        }
    }
}
