namespace WinFormApp
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            Explorebtn = new Button();
            Nextbtn = new Button();
            Restbtn = new Button();
            Locationlbl = new Label();
            Returnbtn = new Button();
            Inventorybtn = new Button();
            Dialoguelbl = new Label();
            Continuebtn = new Button();
            YoPicturebox = new PictureBox();
            pictureBox2 = new PictureBox();
            Attackbtn = new Button();
            Healbtn = new Button();
            Defensebtn = new Button();
            EnemyBox = new ListBox();
            MCBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)YoPicturebox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Explorebtn
            // 
            Explorebtn.BackColor = Color.PapayaWhip;
            Explorebtn.FlatStyle = FlatStyle.Popup;
            Explorebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Explorebtn.Location = new Point(452, 341);
            Explorebtn.Name = "Explorebtn";
            Explorebtn.Size = new Size(156, 61);
            Explorebtn.TabIndex = 0;
            Explorebtn.Text = "Мандрувати";
            Explorebtn.UseVisualStyleBackColor = false;
            Explorebtn.Click += Explorebtn_Click;
            // 
            // Nextbtn
            // 
            Nextbtn.BackColor = Color.PapayaWhip;
            Nextbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Nextbtn.FlatStyle = FlatStyle.Popup;
            Nextbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nextbtn.Location = new Point(614, 341);
            Nextbtn.Name = "Nextbtn";
            Nextbtn.Size = new Size(156, 61);
            Nextbtn.TabIndex = 1;
            Nextbtn.Text = "Наступна локація";
            Nextbtn.UseVisualStyleBackColor = false;
            Nextbtn.Visible = false;
            Nextbtn.Click += Nextbtn_Click;
            // 
            // Restbtn
            // 
            Restbtn.BackColor = Color.PapayaWhip;
            Restbtn.FlatStyle = FlatStyle.Popup;
            Restbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Restbtn.Location = new Point(614, 430);
            Restbtn.Name = "Restbtn";
            Restbtn.Size = new Size(156, 61);
            Restbtn.TabIndex = 3;
            Restbtn.Text = "Відпочинок";
            Restbtn.UseVisualStyleBackColor = false;
            Restbtn.Click += Restbtn_Click;
            // 
            // Locationlbl
            // 
            Locationlbl.AutoSize = true;
            Locationlbl.BackColor = Color.NavajoWhite;
            Locationlbl.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Locationlbl.ForeColor = SystemColors.ActiveCaptionText;
            Locationlbl.Location = new Point(492, 153);
            Locationlbl.Name = "Locationlbl";
            Locationlbl.Size = new Size(236, 40);
            Locationlbl.TabIndex = 1;
            Locationlbl.Text = "Зореплаве Поле";
            // 
            // Returnbtn
            // 
            Returnbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Returnbtn.BackColor = Color.Transparent;
            Returnbtn.BackgroundImage = Sweet_Pudding.Properties.Resources.Return;
            Returnbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Returnbtn.FlatAppearance.BorderSize = 0;
            Returnbtn.FlatStyle = FlatStyle.Flat;
            Returnbtn.Location = new Point(1159, 12);
            Returnbtn.Name = "Returnbtn";
            Returnbtn.Size = new Size(91, 93);
            Returnbtn.TabIndex = 5;
            Returnbtn.UseVisualStyleBackColor = false;
            Returnbtn.Click += Returnbtn_Click;
            // 
            // Inventorybtn
            // 
            Inventorybtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Inventorybtn.BackColor = Color.Transparent;
            Inventorybtn.BackgroundImage = Sweet_Pudding.Properties.Resources.inventory1;
            Inventorybtn.BackgroundImageLayout = ImageLayout.Stretch;
            Inventorybtn.FlatAppearance.BorderSize = 0;
            Inventorybtn.FlatStyle = FlatStyle.Flat;
            Inventorybtn.Location = new Point(12, 629);
            Inventorybtn.Name = "Inventorybtn";
            Inventorybtn.Size = new Size(110, 112);
            Inventorybtn.TabIndex = 6;
            Inventorybtn.UseVisualStyleBackColor = false;
            Inventorybtn.Click += Inventorybtn_Click;
            // 
            // Dialoguelbl
            // 
            Dialoguelbl.AutoEllipsis = true;
            Dialoguelbl.AutoSize = true;
            Dialoguelbl.BackColor = Color.NavajoWhite;
            Dialoguelbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Dialoguelbl.Location = new Point(90, 266);
            Dialoguelbl.Name = "Dialoguelbl";
            Dialoguelbl.Size = new Size(0, 24);
            Dialoguelbl.TabIndex = 7;
            Dialoguelbl.Visible = false;
            // 
            // Continuebtn
            // 
            Continuebtn.BackColor = Color.PapayaWhip;
            Continuebtn.FlatStyle = FlatStyle.Popup;
            Continuebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Continuebtn.ForeColor = SystemColors.ControlText;
            Continuebtn.Location = new Point(452, 430);
            Continuebtn.Name = "Continuebtn";
            Continuebtn.Size = new Size(156, 61);
            Continuebtn.TabIndex = 8;
            Continuebtn.Text = "Продовжити";
            Continuebtn.UseVisualStyleBackColor = false;
            Continuebtn.Visible = false;
            Continuebtn.Click += Continuebtn_Click;
            // 
            // YoPicturebox
            // 
            YoPicturebox.BackColor = Color.PapayaWhip;
            YoPicturebox.BackgroundImageLayout = ImageLayout.Zoom;
            YoPicturebox.Location = new Point(12, 67);
            YoPicturebox.Name = "YoPicturebox";
            YoPicturebox.Size = new Size(371, 448);
            YoPicturebox.TabIndex = 9;
            YoPicturebox.TabStop = false;
            YoPicturebox.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.BackColor = Color.PapayaWhip;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(879, 67);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(371, 329);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Attackbtn
            // 
            Attackbtn.BackColor = Color.PapayaWhip;
            Attackbtn.FlatStyle = FlatStyle.Popup;
            Attackbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Attackbtn.Location = new Point(452, 375);
            Attackbtn.Name = "Attackbtn";
            Attackbtn.Size = new Size(156, 61);
            Attackbtn.TabIndex = 11;
            Attackbtn.Text = "Атакувати";
            Attackbtn.UseVisualStyleBackColor = false;
            Attackbtn.Visible = false;
            Attackbtn.Click += Attackbtn_Click;
            // 
            // Healbtn
            // 
            Healbtn.BackColor = Color.PapayaWhip;
            Healbtn.FlatStyle = FlatStyle.Popup;
            Healbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Healbtn.Location = new Point(537, 454);
            Healbtn.Name = "Healbtn";
            Healbtn.Size = new Size(156, 61);
            Healbtn.TabIndex = 12;
            Healbtn.Text = "Випити зілля";
            Healbtn.UseVisualStyleBackColor = false;
            Healbtn.Visible = false;
            Healbtn.Click += Healbtn_Click;
            // 
            // Defensebtn
            // 
            Defensebtn.BackColor = Color.PapayaWhip;
            Defensebtn.FlatStyle = FlatStyle.Popup;
            Defensebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Defensebtn.Location = new Point(614, 375);
            Defensebtn.Name = "Defensebtn";
            Defensebtn.Size = new Size(156, 61);
            Defensebtn.TabIndex = 14;
            Defensebtn.Text = "Захищатися";
            Defensebtn.UseVisualStyleBackColor = false;
            Defensebtn.Visible = false;
            Defensebtn.Click += Defensebtn_Click;
            // 
            // EnemyBox
            // 
            EnemyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnemyBox.BackColor = Color.PapayaWhip;
            EnemyBox.FormattingEnabled = true;
            EnemyBox.ItemHeight = 20;
            EnemyBox.Location = new Point(879, 521);
            EnemyBox.Name = "EnemyBox";
            EnemyBox.Size = new Size(371, 104);
            EnemyBox.TabIndex = 15;
            EnemyBox.Visible = false;
            // 
            // MCBox
            // 
            MCBox.BackColor = Color.PapayaWhip;
            MCBox.FormattingEnabled = true;
            MCBox.ItemHeight = 20;
            MCBox.Location = new Point(12, 521);
            MCBox.Name = "MCBox";
            MCBox.Size = new Size(371, 104);
            MCBox.TabIndex = 16;
            MCBox.Visible = false;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 753);
            Controls.Add(MCBox);
            Controls.Add(EnemyBox);
            Controls.Add(Defensebtn);
            Controls.Add(Healbtn);
            Controls.Add(Attackbtn);
            Controls.Add(pictureBox2);
            Controls.Add(YoPicturebox);
            Controls.Add(Continuebtn);
            Controls.Add(Dialoguelbl);
            Controls.Add(Inventorybtn);
            Controls.Add(Returnbtn);
            Controls.Add(Locationlbl);
            Controls.Add(Restbtn);
            Controls.Add(Nextbtn);
            Controls.Add(Explorebtn);
            Cursor = Cursors.Cross;
            Name = "Form4";
            Text = "Зореплаве поле";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)YoPicturebox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Explorebtn;
        private Button Nextbtn;
        private Button Restbtn;
        private Label Locationlbl;
        private Button Returnbtn;
        private Button Inventorybtn;
        private Label Dialoguelbl;
        private Button Continuebtn;
        private PictureBox YoPicturebox;
        private PictureBox pictureBox2;
        private Button Attackbtn;
        private Button Healbtn;
        private Button Defensebtn;
        private ListBox EnemyBox;
        private ListBox MCBox;
    }
}