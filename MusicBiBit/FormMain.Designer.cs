namespace MusicBiBit
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Open = new System.Windows.Forms.ToolStripButton();
            this.Play = new System.Windows.Forms.ToolStripButton();
            this.Pause = new System.Windows.Forms.ToolStripButton();
            this.Stop = new System.Windows.Forms.ToolStripButton();
            this.Prev = new System.Windows.Forms.ToolStripButton();
            this.Next = new System.Windows.Forms.ToolStripButton();
            this.VolumeOn = new System.Windows.Forms.ToolStripButton();
            this.VolumeOf = new System.Windows.Forms.ToolStripButton();
            this.CurrentFileName = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.CurrentPosition = new System.Windows.Forms.Label();
            this.listBox = new System.Windows.Forms.ListBox();
            this.favor = new System.Windows.Forms.Label();
            this.AddToList = new System.Windows.Forms.Button();
            this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
            this.Out = new System.Windows.Forms.Button();
            this.DelFromList = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.ClearList = new System.Windows.Forms.Button();
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.rewind = new System.Windows.Forms.TrackBar();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.durat = new System.Windows.Forms.Label();
            this.buttonMin = new System.Windows.Forms.Button();
            this.toolTip6 = new System.Windows.Forms.ToolTip(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.duratAll = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "(*.mp3)|*.mp3|(*.wmv)|*.wmv";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Open,
            this.Play,
            this.Pause,
            this.Stop,
            this.Prev,
            this.Next,
            this.VolumeOn,
            this.VolumeOf});
            this.toolStrip1.Location = new System.Drawing.Point(0, 133);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(337, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Open
            // 
            this.Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
            this.Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(23, 22);
            this.Open.Text = "Открыть файл";
            this.Open.Click += new System.EventHandler(this.Open_Click);
            // 
            // Play
            // 
            this.Play.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Play.Image = ((System.Drawing.Image)(resources.GetObject("Play.Image")));
            this.Play.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(23, 22);
            this.Play.Text = "Запуск";
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Pause.Image = ((System.Drawing.Image)(resources.GetObject("Pause.Image")));
            this.Pause.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(23, 22);
            this.Pause.Text = "Пауза";
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Stop.Image = ((System.Drawing.Image)(resources.GetObject("Stop.Image")));
            this.Stop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(23, 22);
            this.Stop.Text = "Стоп";
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Prev
            // 
            this.Prev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Prev.Image = ((System.Drawing.Image)(resources.GetObject("Prev.Image")));
            this.Prev.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(23, 22);
            this.Prev.Text = "Предыдущая";
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Next
            // 
            this.Next.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Next.Image = ((System.Drawing.Image)(resources.GetObject("Next.Image")));
            this.Next.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(23, 22);
            this.Next.Text = "Следующая";
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // VolumeOn
            // 
            this.VolumeOn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VolumeOn.Image = ((System.Drawing.Image)(resources.GetObject("VolumeOn.Image")));
            this.VolumeOn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VolumeOn.Name = "VolumeOn";
            this.VolumeOn.Size = new System.Drawing.Size(23, 22);
            this.VolumeOn.Text = "Включить звук";
            this.VolumeOn.Click += new System.EventHandler(this.VolumeOn_Click);
            // 
            // VolumeOf
            // 
            this.VolumeOf.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.VolumeOf.Image = ((System.Drawing.Image)(resources.GetObject("VolumeOf.Image")));
            this.VolumeOf.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.VolumeOf.Name = "VolumeOf";
            this.VolumeOf.Size = new System.Drawing.Size(23, 22);
            this.VolumeOf.Text = "Выключить звук";
            this.VolumeOf.Click += new System.EventHandler(this.VolumeOf_Click);
            // 
            // CurrentFileName
            // 
            this.CurrentFileName.AutoSize = true;
            this.CurrentFileName.BackColor = System.Drawing.Color.Transparent;
            this.CurrentFileName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CurrentFileName.ForeColor = System.Drawing.Color.AliceBlue;
            this.CurrentFileName.Location = new System.Drawing.Point(0, 120);
            this.CurrentFileName.Name = "CurrentFileName";
            this.CurrentFileName.Size = new System.Drawing.Size(0, 13);
            this.CurrentFileName.TabIndex = 6;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox.ErrorImage = null;
            this.pictureBox.InitialImage = null;
            this.pictureBox.Location = new System.Drawing.Point(4, 47);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(86, 73);
            this.pictureBox.TabIndex = 7;
            this.pictureBox.TabStop = false;
            // 
            // CurrentPosition
            // 
            this.CurrentPosition.AutoSize = true;
            this.CurrentPosition.Location = new System.Drawing.Point(332, 78);
            this.CurrentPosition.Name = "CurrentPosition";
            this.CurrentPosition.Size = new System.Drawing.Size(0, 13);
            this.CurrentPosition.TabIndex = 8;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox.ForeColor = System.Drawing.Color.DodgerBlue;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(92, 49);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(240, 56);
            this.listBox.TabIndex = 9;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // favor
            // 
            this.favor.AutoSize = true;
            this.favor.BackColor = System.Drawing.Color.Transparent;
            this.favor.ForeColor = System.Drawing.Color.AliceBlue;
            this.favor.Location = new System.Drawing.Point(89, 33);
            this.favor.Name = "favor";
            this.favor.Size = new System.Drawing.Size(140, 13);
            this.favor.TabIndex = 10;
            this.favor.Text = "Список воспроизведения:\r\n";
            // 
            // AddToList
            // 
            this.AddToList.BackColor = System.Drawing.Color.AliceBlue;
            this.AddToList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddToList.BackgroundImage")));
            this.AddToList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddToList.Location = new System.Drawing.Point(15, 22);
            this.AddToList.Name = "AddToList";
            this.AddToList.Size = new System.Drawing.Size(23, 22);
            this.AddToList.TabIndex = 11;
            this.toolTip1.SetToolTip(this.AddToList, "Добавить в список");
            this.AddToList.UseVisualStyleBackColor = false;
            this.AddToList.Click += new System.EventHandler(this.AddToList_Click);
            // 
            // WMP
            // 
            this.WMP.Enabled = true;
            this.WMP.Location = new System.Drawing.Point(396, 146);
            this.WMP.Name = "WMP";
            this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
            this.WMP.Size = new System.Drawing.Size(184, 105);
            this.WMP.TabIndex = 4;
            this.WMP.Visible = false;
            // 
            // Out
            // 
            this.Out.BackColor = System.Drawing.Color.Transparent;
            this.Out.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Out.BackgroundImage")));
            this.Out.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Out.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Out.Location = new System.Drawing.Point(305, 5);
            this.Out.Name = "Out";
            this.Out.Size = new System.Drawing.Size(29, 23);
            this.Out.TabIndex = 12;
            this.Out.Text = "\r\n";
            this.toolTip5.SetToolTip(this.Out, "Закрыть BiBit");
            this.Out.UseVisualStyleBackColor = false;
            this.Out.Click += new System.EventHandler(this.Out_Click);
            // 
            // DelFromList
            // 
            this.DelFromList.BackColor = System.Drawing.Color.AliceBlue;
            this.DelFromList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DelFromList.BackgroundImage")));
            this.DelFromList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DelFromList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DelFromList.Location = new System.Drawing.Point(37, 22);
            this.DelFromList.Name = "DelFromList";
            this.DelFromList.Size = new System.Drawing.Size(23, 22);
            this.DelFromList.TabIndex = 13;
            this.toolTip2.SetToolTip(this.DelFromList, "Убрать из списка");
            this.DelFromList.UseVisualStyleBackColor = false;
            this.DelFromList.Click += new System.EventHandler(this.DelFromList_Click);
            // 
            // ClearList
            // 
            this.ClearList.BackColor = System.Drawing.Color.AliceBlue;
            this.ClearList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearList.BackgroundImage")));
            this.ClearList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClearList.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ClearList.Location = new System.Drawing.Point(58, 22);
            this.ClearList.Name = "ClearList";
            this.ClearList.Size = new System.Drawing.Size(23, 22);
            this.ClearList.TabIndex = 18;
            this.toolTip2.SetToolTip(this.ClearList, "Очистить список");
            this.ClearList.UseVisualStyleBackColor = false;
            this.ClearList.Click += new System.EventHandler(this.ClearList_Click);
            // 
            // rewind
            // 
            this.rewind.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.rewind.AutoSize = false;
            this.rewind.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rewind.Location = new System.Drawing.Point(92, 102);
            this.rewind.Maximum = 100;
            this.rewind.Name = "rewind";
            this.rewind.Size = new System.Drawing.Size(238, 15);
            this.rewind.TabIndex = 14;
            this.rewind.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.toolTip4.SetToolTip(this.rewind, "Перемотка трека");
            this.rewind.Scroll += new System.EventHandler(this.rewind_Scroll);
            // 
            // Volume
            // 
            this.Volume.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Volume.AutoSize = false;
            this.Volume.BackColor = System.Drawing.Color.AliceBlue;
            this.Volume.Location = new System.Drawing.Point(208, 139);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(98, 32);
            this.Volume.TabIndex = 5;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.toolTip4.SetToolTip(this.Volume, "Регулировка громкости");
            this.Volume.Scroll += new System.EventHandler(this.Volume_Scroll);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // durat
            // 
            this.durat.AutoSize = true;
            this.durat.BackColor = System.Drawing.Color.Transparent;
            this.durat.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.durat.Location = new System.Drawing.Point(251, 120);
            this.durat.Name = "durat";
            this.durat.Size = new System.Drawing.Size(0, 13);
            this.durat.TabIndex = 15;
            // 
            // buttonMin
            // 
            this.buttonMin.BackColor = System.Drawing.Color.Transparent;
            this.buttonMin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMin.BackgroundImage")));
            this.buttonMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonMin.Location = new System.Drawing.Point(271, 5);
            this.buttonMin.Name = "buttonMin";
            this.buttonMin.Size = new System.Drawing.Size(28, 23);
            this.buttonMin.TabIndex = 19;
            this.toolTip6.SetToolTip(this.buttonMin, "Минимизировать");
            this.buttonMin.UseVisualStyleBackColor = false;
            this.buttonMin.Click += new System.EventHandler(this.buttonMin_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MusicBiBit";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonPlus.FlatAppearance.BorderSize = 0;
            this.buttonPlus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonPlus.Location = new System.Drawing.Point(301, 136);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(20, 20);
            this.buttonPlus.TabIndex = 20;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.AliceBlue;
            this.buttonMinus.FlatAppearance.BorderSize = 0;
            this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinus.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonMinus.Location = new System.Drawing.Point(191, 136);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(20, 20);
            this.buttonMinus.TabIndex = 21;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click);
            // 
            // duratAll
            // 
            this.duratAll.AutoSize = true;
            this.duratAll.BackColor = System.Drawing.Color.Transparent;
            this.duratAll.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.duratAll.Location = new System.Drawing.Point(282, 120);
            this.duratAll.Name = "duratAll";
            this.duratAll.Size = new System.Drawing.Size(0, 13);
            this.duratAll.TabIndex = 22;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(337, 158);
            this.Controls.Add(this.duratAll);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.buttonMin);
            this.Controls.Add(this.ClearList);
            this.Controls.Add(this.durat);
            this.Controls.Add(this.rewind);
            this.Controls.Add(this.DelFromList);
            this.Controls.Add(this.Out);
            this.Controls.Add(this.AddToList);
            this.Controls.Add(this.favor);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.CurrentPosition);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.CurrentFileName);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.WMP);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BiBit v. 2.0";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BiBit_FormClosing);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MusicBiBit_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MusicBiBit_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MusicBiBit_MouseUp);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Open;
        private System.Windows.Forms.ToolStripButton Play;
        private System.Windows.Forms.ToolStripButton Pause;
        private System.Windows.Forms.ToolStripButton Stop;
        private System.Windows.Forms.ToolStripButton VolumeOn;
        private System.Windows.Forms.ToolStripButton VolumeOf;
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        private System.Windows.Forms.ToolStripButton Next;
        private System.Windows.Forms.ToolStripButton Prev;
        private System.Windows.Forms.Label CurrentFileName;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label CurrentPosition;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label favor;
        private System.Windows.Forms.Button AddToList;
        private System.Windows.Forms.Button Out;
        private System.Windows.Forms.Button DelFromList;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TrackBar rewind;
        private System.Windows.Forms.Label durat;
        private System.Windows.Forms.TrackBar Volume;
        private System.Windows.Forms.Button ClearList;
        private System.Windows.Forms.Button buttonMin;
        private System.Windows.Forms.ToolTip toolTip6;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Label duratAll;
    }
}

