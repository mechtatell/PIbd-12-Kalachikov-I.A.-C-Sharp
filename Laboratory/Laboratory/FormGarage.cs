using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormGarages : Form
    {
        private readonly GarageCollection garageCollection;

        public FormGarages()
        {
            InitializeComponent();
            garageCollection = new GarageCollection(pictureBoxGarage.Width, pictureBoxGarage.Height);
            Render();
        }

        private void ReloadLevels()
        {
            int currentIndex = listBoxGarages.SelectedIndex;

            listBoxGarages.Items.Clear();
            for (int i = 0; i < garageCollection.Keys.Count; i++)
            {
                listBoxGarages.Items.Add(garageCollection.Keys[i]);
            }

            if (listBoxGarages.Items.Count > 0 && (currentIndex < 0 || currentIndex >= listBoxGarages.Items.Count))
            {
                listBoxGarages.SelectedIndex = 0;
            }
            else if (listBoxGarages.Items.Count > 0 && currentIndex >= 0 && currentIndex < listBoxGarages.Items.Count)
            {
                listBoxGarages.SelectedIndex = currentIndex;
            }
        }

        private void Render()
        {
            Bitmap bitmap = new Bitmap(pictureBoxGarage.Width, pictureBoxGarage.Height);
            Graphics g = Graphics.FromImage(bitmap);
            if (listBoxGarages.SelectedIndex >= 0)
            {
                garageCollection[listBoxGarages.SelectedItem.ToString()].Render(g);
            }
            else
            {
                g.FillRectangle(new SolidBrush(Color.Transparent), 0, 0, pictureBoxGarage.Width, pictureBoxGarage.Height);
            }
            pictureBoxGarage.Image = bitmap;
        }

        private void buttonAddGarage_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxGarageName.Text))
            {
                garageCollection.AddGarage(textBoxGarageName.Text);
                ReloadLevels();
                Render();
            }
            else
            {
                MessageBox.Show("Введите название гаража", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveGarage_Click(object sender, EventArgs e)
        {
            if (listBoxGarages.SelectedIndex >= 0)
            {
                if (MessageBox.Show($"Удалить гараж {listBoxGarages.SelectedItem}?", "Удаление",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    garageCollection.RemoveGarage(listBoxGarages.SelectedItem.ToString());
                    ReloadLevels();
                    Render();
                }
            }
            else
            {
                MessageBox.Show("Гараж не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCreateTruck_Click(object sender, EventArgs e)
        {
            var formTruckConfig = new FormTruckCongif();
            formTruckConfig.AddEvent(AddTruck);
            formTruckConfig.ShowDialog();
        }

        private void AddTruck(Truck truck)
        {
            if (truck != null && listBoxGarages.SelectedIndex >= 0)
            {
                if (garageCollection[listBoxGarages.SelectedItem.ToString()] + truck)
                {
                    Render();
                }
                else
                {
                    MessageBox.Show("Гараж переполнен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Гараж не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            if (listBoxGarages.SelectedIndex >= 0)
            {
                if (maskedTextBoxPlace.Text != "")
                {
                    var truck = garageCollection[listBoxGarages.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                    if (truck != null)
                    {
                        FormTruck formTransport = new FormTruck();
                        formTransport.SetTruck(truck);
                        Render();
                        formTransport.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Грузовика с таким индексом нет!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Гараж не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Render();
        }
    }
}
