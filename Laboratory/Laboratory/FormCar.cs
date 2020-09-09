using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormCar : Form
    {
        private Tanker car;
        public FormCar()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            car = new Tanker(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite, Color.Red, true, true, true, true);
            car.SetPosition(random.Next(10, 100), random.Next(10, 100), pictureBoxTanker.Width, pictureBoxTanker.Height);
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
                        car.MoveCar(Direction.Up);
                        break;
                    case "buttonDown":
                        car.MoveCar(Direction.Down);
                        break;
                    case "buttonLeft":
                        car.MoveCar(Direction.Left);
                        break;
                    case "buttonRight":
                        car.MoveCar(Direction.Right);
                        break;
                }
                Render();
            }
        }

        private void Render()
        {
            Bitmap map = new Bitmap(pictureBoxTanker.Width, pictureBoxTanker.Height);
            Graphics g = Graphics.FromImage(map);
            car.Render(g);
            pictureBoxTanker.Image = map;
        }
    }
}
