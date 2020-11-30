using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Laboratory
{
    public partial class FormGarages : Form
    {
        private readonly GarageCollection garageCollection;

        private readonly Logger logger;

        public FormGarages()
        {
            InitializeComponent();
            garageCollection = new GarageCollection(pictureBoxGarage.Width, pictureBoxGarage.Height);

            ToolStripMenuItem saveFileMenuItem = new ToolStripMenuItem("Сохранить");
            ToolStripMenuItem loadFileMenuItem = new ToolStripMenuItem("Загрузить");
            menuItemFile.DropDownItems.Add(saveFileMenuItem);
            menuItemFile.DropDownItems.Add(loadFileMenuItem);
            saveFileMenuItem.Click += saveFileMenuItem_Click;
            loadFileMenuItem.Click += loadFileMenuItem_Click;

            logger = LogManager.GetCurrentClassLogger();
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
                logger.Info("Добавили гараж " + textBoxGarageName.Text);
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
                    logger.Info("Удалили гараж " + listBoxGarages.SelectedItem.ToString());
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
            if (listBoxGarages.SelectedIndex >= 0)
            {
                var formTruckConfig = new FormTruckCongif();
                formTruckConfig.AddEvent(AddTruck);
                formTruckConfig.ShowDialog();
            }
            else
            {
                MessageBox.Show("Гараж не выбран", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTruck(Truck truck)
        {
            try
            {
                if (garageCollection[listBoxGarages.SelectedItem.ToString()] + truck)
                {
                    Render();
                    logger.Info("Добавили грузовик " + truck);
                }
                else
                {
                    MessageBox.Show("Гараж переполнен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (GarageOverflowException ex)
            {
                MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn(ex.Message);
            }
        }

        private void buttonTake_Click(object sender, EventArgs e)
        {
            try
            {
                var truck = garageCollection[listBoxGarages.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxPlace.Text);
                if (truck != null)
                {
                    FormTruck formTransport = new FormTruck();
                    formTransport.SetTruck(truck);
                    Render();
                    formTransport.ShowDialog();
                    logger.Info("Изъят грузовик " + truck + " с места " + maskedTextBoxPlace.Text);
                }
            }
            catch (GarageNotFoundException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Неизвестная ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Warn(ex.Message);
            }
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            logger.Info("Перешли на гараж " + listBoxGarages.SelectedItem.ToString());
            Render();
        }

        private void saveFileMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "txt file | *.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    garageCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }

        private void loadFileMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt file | *.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    garageCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    ReloadLevels();
                    Render();
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                }
                catch (GarageOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Занятое место", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    logger.Warn(ex.Message);
                }
            }
        }
    }
}
