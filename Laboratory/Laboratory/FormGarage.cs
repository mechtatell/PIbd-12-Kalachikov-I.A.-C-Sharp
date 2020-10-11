using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormGarage : Form
    {
        private readonly Garage<Truck> garage;

        public FormGarage()
        {
            InitializeComponent();
            garage = new Garage<Truck>(pictureBoxGarage.Width, pictureBoxGarage.Height);
            Render();
        }

        private void Render()
        {
            Bitmap bitmap = new Bitmap(pictureBoxGarage.Width, pictureBoxGarage.Height);
            Graphics g = Graphics.FromImage(bitmap);
            garage.Render(g);
            pictureBoxGarage.Image = bitmap;
        }

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                var truck = new Truck(100, 1000, colorDialog.Color);
                if (garage + truck)
                {
                    Render();
                }
                else
                {
                    MessageBox.Show("Гараж переполнен");
                }
            }
        }

        private void buttonCreateTanker_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog otherColorDialog = new ColorDialog();
                if (otherColorDialog.ShowDialog() == DialogResult.OK)
                {
                    var truck = new Tanker(100, 1000, colorDialog.Color, otherColorDialog.Color, true, true, true, true);
                    if (garage + truck)
                    {
                        Render();
                    }
                    else
                    {
                        MessageBox.Show("Гараж переполнен");
                    }
                }
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxPlace.Text != "")
            {
                var truck = garage - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (truck != null)
                {
                    FormTruck formTransport = new FormTruck();
                    formTransport.SetTruck(truck);
                    Render();
                    formTransport.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Грузовика с таким индексом нет!");
                }
            }
        }
    }
}
