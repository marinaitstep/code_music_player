using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace MusicBiBit
{
    public partial class FormMain : Form
    {
        string list = "list.txt";
        private Point mouseOffset;
        private bool isMouseDown = false;

        #region считывание и запись списка треков из/в файл при открытии/закрытии плеера
        public FormMain()
        {
            InitializeComponent();

            timer1.Interval = 1000;
            WMP.settings.volume = 20;
            Volume.Value = 20;
            VolumeOn.Checked = true;
            VolumeOf.Checked = false;
            if (File.Exists(list))
            {
                using (FileStream fs = new FileStream(list, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader(fs, Encoding.Unicode))
                    {
                        listBox.Items.AddRange(sr.ReadToEnd().Split(new string[] { "\n" }, StringSplitOptions.RemoveEmptyEntries));
                    }
                }
            }
            listBox.Items.Remove("\r"); //не удаляется куча абзацев пустых
        }

        private void BiBit_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (FileStream fs = new FileStream(list, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs, Encoding.Unicode))
                {
                    foreach (var item in listBox.Items)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }
        #endregion

        #region проигрывание треков из файла/списка
        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                WMP.URL = openFileDialog1.FileName;
                CurrentFileName.Text = WMP.currentMedia.name;
                Play.Checked = true;
                Stop.Checked = false;
                Pause.Checked = false;
                timer1.Start();
            }
            else
                MessageBox.Show("Вы ничего не выбрали!");

            //достаём обложку альбома, если она есть
            string dir = Path.GetDirectoryName(WMP.currentMedia.sourceURL);
            dir = dir + "\\cover.jpg";
            if (File.Exists(dir))
            {
                Image image = Image.FromFile(dir);
                Bitmap bitmap = new Bitmap(image, pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bitmap;
            }
            else
                pictureBox.Image = default;

            //активируем и деактивируем нужные кнопки
            Play.Checked = true;
            Stop.Checked = false;
            Pause.Checked = false;
        }
        private void Prev_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0)
            {
                MessageBox.Show("Вы ничего не выбрали!");
            }
            //если трек не первый в списке, то переходим к предыдущему треку
            else if (listBox.SelectedIndex != 0)
            {
                WMP.URL = listBox.Items[listBox.SelectedIndex - 1].ToString();
                listBox.SelectedIndex = listBox.SelectedIndex - 1;
                CurrentFileName.Text = WMP.currentMedia.name;

            }
            //если выбран первый трек в списке, то возвращаемся в конец списка
            else if (listBox.SelectedIndex == 0)
            {
                WMP.URL = listBox.Items[listBox.Items.Count - 1].ToString();
                listBox.SelectedIndex = listBox.Items.Count - 1;
                CurrentFileName.Text = WMP.currentMedia.name;
            }

            //достаём обложку альбома, если она есть
            string dir = Path.GetDirectoryName(WMP.currentMedia.sourceURL);
            dir = dir + "\\cover.jpg";
            if (File.Exists(dir))
            {
                Image image = Image.FromFile(dir);
                Bitmap bitmap = new Bitmap(image, pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bitmap;
            }
            else
                pictureBox.Image = default;

            //активируем и деактивируем нужные кнопки
            Play.Checked = true;
            Stop.Checked = false;
            Pause.Checked = false;
        }
        private void Next_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex < 0)
            {
                MessageBox.Show("Вы ничего не выбрали!");
            }
            //если трек выбран не последний в списке, то переходим к следующему
            else if (listBox.SelectedIndex != listBox.Items.Count - 1)
            {
                WMP.URL = listBox.Items[listBox.SelectedIndex + 1].ToString();
                listBox.SelectedIndex = listBox.SelectedIndex + 1;
                CurrentFileName.Text = WMP.currentMedia.name;

            }
            //если трек выбран последний в списке, то переходим к началу
            else if (listBox.SelectedIndex == listBox.Items.Count - 1)
            {
                WMP.URL = listBox.Items[0].ToString();
                listBox.SelectedIndex = 0;
                CurrentFileName.Text = WMP.currentMedia.name;
            }

            //достаём обложку альбома, если она есть
            string dir = Path.GetDirectoryName(WMP.currentMedia.sourceURL);
            dir = dir + "\\cover.jpg";
            if (File.Exists(dir))
            {
                Image image = Image.FromFile(dir);
                Bitmap bitmap = new Bitmap(image, pictureBox.Width, pictureBox.Height);
                pictureBox.Image = bitmap;
            }
            else
                pictureBox.Image = default;

            //активируем и деактивируем нужные кнопки
            Play.Checked = true;
            Stop.Checked = false;
            Pause.Checked = false;
        }
        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                WMP.URL = listBox.SelectedItem.ToString();
                CurrentFileName.Text = WMP.currentMedia.name;

                //достаём обложку альбома, если она есть
                string dir = Path.GetDirectoryName(WMP.currentMedia.sourceURL);
                dir = dir + "\\cover.jpg";
                if (File.Exists(dir))
                {
                    Image image = Image.FromFile(dir);
                    Bitmap bitmap = new Bitmap(image, pictureBox.Width, pictureBox.Height);
                    pictureBox.Image = bitmap;
                }
                else
                    pictureBox.Image = default;

                //активируем и деактивируем нужные кнопки
                Play.Checked = true;
                Stop.Checked = false;
                Pause.Checked = false;
                timer1.Start();
            }
        }
        #endregion

        #region работа со списком треков кнопками сердечки
        private void AddToList_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    listBox.Items.Add(openFileDialog1.FileNames[i]);
                }

            }
            else
                MessageBox.Show("Вы ничего не выбрали!");

        }
        private void DelFromList_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex >= 0)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Вы ничего не выбрали!");
            }
        }
        private void ClearList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }
        #endregion

        #region кнопки старт, стоп, пауза, закрытие громкость и прокрутки
        private void Play_Click(object sender, EventArgs e)
        {
            if (WMP.URL != "")
            {
                WMP.Ctlcontrols.play();
                Play.Checked = true;
                Pause.Checked = false;
                Stop.Checked = false;
                timer1.Start();
            }
            else
                MessageBox.Show("Вы ничего не выбрали!");
        }
        private void Pause_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.pause();
            Play.Checked = false;
            Pause.Checked = true;
            Stop.Checked = false;
            timer1.Stop();
        }
        private void Stop_Click(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.stop();
            Play.Checked = false;
            Pause.Checked = false;
            Stop.Checked = true;
            timer1.Stop();
        }
        private void Volume_Scroll(object sender, EventArgs e)
        {
            WMP.settings.volume = Volume.Value;
            if (Volume.Value == 0)
            {
                VolumeOn.Checked = false;
                VolumeOf.Checked = true;
            }
            if (Volume.Value != 0)
            {
                VolumeOn.Checked = true;
                VolumeOf.Checked = false;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //запуск перемотки трека
            rewind.Maximum = Convert.ToInt32(WMP.currentMedia.duration);
            rewind.Value = Convert.ToInt32(WMP.Ctlcontrols.currentPosition);
            durat.Text = WMP.Ctlcontrols.currentPositionString;
            duratAll.Text = "/ " + WMP.currentMedia.durationString;
            //если трек доиграет до конца, он автоматически перейдёт на след трек
            if (rewind.Value == rewind.Maximum)
                Next_Click(sender, e);
        }
        private void rewind_Scroll(object sender, EventArgs e)
        {
            WMP.Ctlcontrols.currentPosition = rewind.Value;
        }
        private void VolumeOn_Click(object sender, EventArgs e)
        {
            WMP.settings.mute = false;
            VolumeOf.Checked = false;
            VolumeOn.Checked = true;
        }
        private void VolumeOf_Click(object sender, EventArgs e)
        {
            WMP.settings.mute = true;
            VolumeOf.Checked = true;
            VolumeOn.Checked = false;
        }
        private void Out_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region перевод окна в системный трей и обратно кнопкой _
        private void buttonMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
        #endregion

        #region регулировка звука с шагом 5 кнопками - и +
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (Volume.Value <= 100)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Volume.Value <= 95 + i)
                        Volume.Value += 5 - i;
                    else if (Volume.Value < 95)
                        Volume.Value += 5;
                    WMP.settings.volume = Volume.Value;
                }
            }
            if (Volume.Value != 0)
            {
                VolumeOf.Checked = false;
                VolumeOn.Checked = true;
            }
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (Volume.Value >= 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (Volume.Value >= 5 - i)
                        Volume.Value -= 5 - i;
                    else if (Volume.Value > 5)
                        Volume.Value -= 5;
                    WMP.settings.volume = Volume.Value;
                }
            }
            if (Volume.Value == 0)
            {
                VolumeOf.Checked = true;
                VolumeOn.Checked = false;
            }
        }
        #endregion

        #region перемещение формы
        private void MusicBiBit_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void MusicBiBit_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void MusicBiBit_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        #endregion
    }
}
