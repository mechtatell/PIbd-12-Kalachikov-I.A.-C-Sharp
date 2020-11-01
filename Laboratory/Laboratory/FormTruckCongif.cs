using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormTruckCongif : Form
    {
        private Truck truck = null;

        public Action<Truck> eventAddTruck;

        public void AddEvent(Action<Truck> e)
        {
            if (eventAddTruck == null)
            {
                eventAddTruck = new Action<Truck>(e);
            }
            else
            {
                eventAddTruck += e;
            }
        }

        public FormTruckCongif()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelPink.MouseDown += panelColor_MouseDown;
            panelPurple.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            buttonCancel.Click += (object Sender, EventArgs e) => Close();
        }

        private void RenderTruck()
        {
            if (truck != null)
            {
                Bitmap bitmap = new Bitmap(pictureBoxTruck.Width, pictureBoxTruck.Height);
                Graphics g = Graphics.FromImage(bitmap);
                truck.SetPosition(30, 20, pictureBoxTruck.Width, pictureBoxTruck.Height);
                truck.Render(g);
                pictureBoxTruck.Image = bitmap;
            }
        }
        private void labelTruck_MouseDown(object sender, MouseEventArgs e)
        {
            labelTruck.DoDragDrop(labelTruck.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelTanker_MouseDown(object sender, MouseEventArgs e)
        {
            labelTanker.DoDragDrop(labelTanker.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelTruck_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Грузовик":
                    truck = new Truck(100, 500, Color.White);
                    break;
                case "Бензовоз":
                    truck = new Tanker(100, 500, Color.White, Color.Black, true, true, true, true);
                    break;
            }
            RenderTruck();
        }

        private void panelTruck_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object Sender, MouseEventArgs e)
        {
            Control panelColor = (Control)Sender;
            panelColor.DoDragDrop(panelColor.BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMainColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMainColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck != null)
            {
                truck.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                RenderTruck();
            }
        }

        private void labelOtherColor_DragDrop(object sender, DragEventArgs e)
        {
            if (truck is Tanker)
            {
                Tanker tanker = (Tanker)truck;
                tanker.SetOtherColor((Color)e.Data.GetData(typeof(Color)));
                RenderTruck();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddTruck?.Invoke(truck);
            Close();
        }
    }
}
