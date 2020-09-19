using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormTanker : Form
    {
        private Tanker tanker;
        public FormTanker()
        {
            InitializeComponent();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            tanker = new Tanker(random.Next(100, 300), random.Next(1000, 2000), Color.GhostWhite, Color.Red, true, true, true, true);
            tanker.SetPosition(random.Next(10, 100), random.Next(10, 100), pictureBoxTanker.Width, pictureBoxTanker.Height);
            Render();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (tanker != null)
            {
                string name = (sender as Button).Name;
                switch (name)
                {
                    case "buttonUp":
                        tanker.MoveTanker(Direction.Up);
                        break;
                    case "buttonDown":
                        tanker.MoveTanker(Direction.Down);
                        break;
                    case "buttonLeft":
                        tanker.MoveTanker(Direction.Left);
                        break;
                    case "buttonRight":
                        tanker.MoveTanker(Direction.Right);
                        break;
                }
                Render();
            }
        }

        private void Render()
        {
            Bitmap map = new Bitmap(pictureBoxTanker.Width, pictureBoxTanker.Height);
            Graphics g = Graphics.FromImage(map);
            tanker.Render(g);
            pictureBoxTanker.Image = map;
        }
    }
}
