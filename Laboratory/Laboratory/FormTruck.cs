using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormTruck : Form
    {
        private ITransport truck;

        public void SetTruck(ITransport truck)
        {
            Random random = new Random();
            truck.SetPosition(random.Next(10, 100), random.Next(100, 200), pictureBoxCar.Width, pictureBoxCar.Height);
            this.truck = truck;
            Render();
        }

        public FormTruck()
        {
            InitializeComponent();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (truck != null)
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
