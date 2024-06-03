namespace Sweet_Pudding
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            Returnbtn = new Button();
            Inventorybtn = new Button();
            Explorebtn = new Button();
            Nextbtn = new Button();
            Restbtn = new Button();
            Locationlbl = new Label();
            Shopbtn = new Button();
            Dialoguelbl = new Label();
            MCPicture = new PictureBox();
            EnemyPicture = new PictureBox();
            MCBox = new ListBox();
            EnemyBox = new ListBox();
            Continuebtn = new Button();
            Attackbtn = new Button();
            Defensebtn = new Button();
            Healbtn = new Button();
            ExitShopbtn = new Button();
            Buydaggerbtn = new Button();
            Buypotionbtn = new Button();
            Buyarmourbtn = new Button();
            DaggerPricelbl = new Label();
            PotionPricelbl = new Label();
            ArmourPricelbl = new Label();
            MCmoneylbl = new Label();
            ((System.ComponentModel.ISupportInitialize)MCPicture).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).BeginInit();
            SuspendLayout();
            // 
            // Returnbtn
            // 
            Returnbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Returnbtn.BackColor = Color.Transparent;
            Returnbtn.BackgroundImage = Properties.Resources.Return1;
            Returnbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Returnbtn.FlatAppearance.BorderSize = 0;
            Returnbtn.FlatStyle = FlatStyle.Flat;
            Returnbtn.Location = new Point(1159, 12);
            Returnbtn.Name = "Returnbtn";
            Returnbtn.Size = new Size(91, 93);
            Returnbtn.TabIndex = 0;
            Returnbtn.UseVisualStyleBackColor = false;
            Returnbtn.Visible = false;
            Returnbtn.Click += Returnbtn_Click;
            // 
            // Inventorybtn
            // 
            Inventorybtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            Inventorybtn.BackColor = Color.Transparent;
            Inventorybtn.BackgroundImage = Properties.Resources.inventory1;
            Inventorybtn.BackgroundImageLayout = ImageLayout.Stretch;
            Inventorybtn.FlatAppearance.BorderSize = 0;
            Inventorybtn.FlatStyle = FlatStyle.Flat;
            Inventorybtn.Location = new Point(12, 629);
            Inventorybtn.Name = "Inventorybtn";
            Inventorybtn.Size = new Size(110, 112);
            Inventorybtn.TabIndex = 1;
            Inventorybtn.UseVisualStyleBackColor = false;
            Inventorybtn.Visible = false;
            Inventorybtn.Click += Inventorybtn_Click;
            // 
            // Explorebtn
            // 
            Explorebtn.BackColor = Color.Beige;
            Explorebtn.FlatStyle = FlatStyle.Popup;
            Explorebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Explorebtn.Location = new Point(478, 295);
            Explorebtn.Name = "Explorebtn";
            Explorebtn.Size = new Size(156, 61);
            Explorebtn.TabIndex = 2;
            Explorebtn.Text = "Мандрувати";
            Explorebtn.UseVisualStyleBackColor = false;
            Explorebtn.Visible = false;
            Explorebtn.Click += Explorebtn_Click;
            // 
            // Nextbtn
            // 
            Nextbtn.BackColor = Color.Beige;
            Nextbtn.FlatStyle = FlatStyle.Popup;
            Nextbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nextbtn.Location = new Point(640, 295);
            Nextbtn.Name = "Nextbtn";
            Nextbtn.Size = new Size(156, 61);
            Nextbtn.TabIndex = 3;
            Nextbtn.Text = "Наступна локація";
            Nextbtn.UseVisualStyleBackColor = false;
            Nextbtn.Visible = false;
            Nextbtn.Click += Nextbtn_Click;
            // 
            // Restbtn
            // 
            Restbtn.BackColor = Color.Beige;
            Restbtn.FlatStyle = FlatStyle.Popup;
            Restbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Restbtn.Location = new Point(640, 362);
            Restbtn.Name = "Restbtn";
            Restbtn.Size = new Size(156, 61);
            Restbtn.TabIndex = 4;
            Restbtn.Text = "Відпочити";
            Restbtn.UseVisualStyleBackColor = false;
            Restbtn.Visible = false;
            Restbtn.Click += Restbtn_Click;
            // 
            // Locationlbl
            // 
            Locationlbl.AutoSize = true;
            Locationlbl.BackColor = Color.Beige;
            Locationlbl.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Locationlbl.Location = new Point(464, 160);
            Locationlbl.Name = "Locationlbl";
            Locationlbl.Size = new Size(90, 27);
            Locationlbl.TabIndex = 5;
            Locationlbl.Text = "Ліандель";
            Locationlbl.Visible = false;
            // 
            // Shopbtn
            // 
            Shopbtn.BackColor = Color.Beige;
            Shopbtn.FlatStyle = FlatStyle.Popup;
            Shopbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Shopbtn.Location = new Point(478, 362);
            Shopbtn.Name = "Shopbtn";
            Shopbtn.Size = new Size(156, 61);
            Shopbtn.TabIndex = 6;
            Shopbtn.Text = "Магазин";
            Shopbtn.UseVisualStyleBackColor = false;
            Shopbtn.Visible = false;
            Shopbtn.Click += Shopbtn_Click;
            // 
            // Dialoguelbl
            // 
            Dialoguelbl.AutoSize = true;
            Dialoguelbl.BackColor = Color.Beige;
            Dialoguelbl.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Dialoguelbl.Location = new Point(418, 243);
            Dialoguelbl.Name = "Dialoguelbl";
            Dialoguelbl.Size = new Size(60, 27);
            Dialoguelbl.TabIndex = 12;
            Dialoguelbl.Text = "label1";
            Dialoguelbl.Visible = false;
            // 
            // MCPicture
            // 
            MCPicture.BackColor = Color.Beige;
            MCPicture.BackgroundImageLayout = ImageLayout.Zoom;
            MCPicture.Location = new Point(12, 45);
            MCPicture.Name = "MCPicture";
            MCPicture.Size = new Size(371, 448);
            MCPicture.TabIndex = 13;
            MCPicture.TabStop = false;
            MCPicture.Visible = false;
            // 
            // EnemyPicture
            // 
            EnemyPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnemyPicture.BackColor = Color.Beige;
            EnemyPicture.BackgroundImageLayout = ImageLayout.Zoom;
            EnemyPicture.Location = new Point(879, 45);
            EnemyPicture.Name = "EnemyPicture";
            EnemyPicture.Size = new Size(371, 329);
            EnemyPicture.TabIndex = 14;
            EnemyPicture.TabStop = false;
            EnemyPicture.Visible = false;
            // 
            // MCBox
            // 
            MCBox.BackColor = Color.Beige;
            MCBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MCBox.FormattingEnabled = true;
            MCBox.ItemHeight = 24;
            MCBox.Location = new Point(12, 499);
            MCBox.Name = "MCBox";
            MCBox.Size = new Size(371, 124);
            MCBox.TabIndex = 15;
            MCBox.Visible = false;
            // 
            // EnemyBox
            // 
            EnemyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnemyBox.BackColor = Color.Beige;
            EnemyBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnemyBox.FormattingEnabled = true;
            EnemyBox.ItemHeight = 24;
            EnemyBox.Location = new Point(879, 499);
            EnemyBox.Name = "EnemyBox";
            EnemyBox.Size = new Size(371, 124);
            EnemyBox.TabIndex = 16;
            EnemyBox.Visible = false;
            // 
            // Continuebtn
            // 
            Continuebtn.BackColor = Color.Beige;
            Continuebtn.FlatStyle = FlatStyle.Popup;
            Continuebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Continuebtn.ForeColor = SystemColors.ControlText;
            Continuebtn.Location = new Point(478, 396);
            Continuebtn.Name = "Continuebtn";
            Continuebtn.Size = new Size(156, 61);
            Continuebtn.TabIndex = 17;
            Continuebtn.Text = "Продовжити";
            Continuebtn.UseVisualStyleBackColor = false;
            Continuebtn.Visible = false;
            Continuebtn.Click += Continuebtn_Click;
            // 
            // Attackbtn
            // 
            Attackbtn.BackColor = Color.Beige;
            Attackbtn.FlatStyle = FlatStyle.Popup;
            Attackbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Attackbtn.ForeColor = SystemColors.ControlText;
            Attackbtn.Location = new Point(478, 329);
            Attackbtn.Name = "Attackbtn";
            Attackbtn.Size = new Size(156, 61);
            Attackbtn.TabIndex = 18;
            Attackbtn.Text = "Атакувати";
            Attackbtn.UseVisualStyleBackColor = false;
            Attackbtn.Visible = false;
            Attackbtn.Click += Attackbtn_Click;
            // 
            // Defensebtn
            // 
            Defensebtn.BackColor = Color.Beige;
            Defensebtn.FlatStyle = FlatStyle.Popup;
            Defensebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Defensebtn.ForeColor = SystemColors.ControlText;
            Defensebtn.Location = new Point(640, 330);
            Defensebtn.Name = "Defensebtn";
            Defensebtn.Size = new Size(156, 61);
            Defensebtn.TabIndex = 19;
            Defensebtn.Text = "Захист";
            Defensebtn.UseVisualStyleBackColor = false;
            Defensebtn.Visible = false;
            Defensebtn.Click += Defensebtn_Click;
            // 
            // Healbtn
            // 
            Healbtn.BackColor = Color.Beige;
            Healbtn.FlatStyle = FlatStyle.Popup;
            Healbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Healbtn.ForeColor = SystemColors.ControlText;
            Healbtn.Location = new Point(555, 397);
            Healbtn.Name = "Healbtn";
            Healbtn.Size = new Size(156, 61);
            Healbtn.TabIndex = 20;
            Healbtn.Text = "Випити зілля";
            Healbtn.UseVisualStyleBackColor = false;
            Healbtn.Visible = false;
            Healbtn.Click += Healbtn_Click;
            // 
            // ExitShopbtn
            // 
            ExitShopbtn.BackColor = Color.Beige;
            ExitShopbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitShopbtn.Location = new Point(578, 479);
            ExitShopbtn.Name = "ExitShopbtn";
            ExitShopbtn.Size = new Size(156, 61);
            ExitShopbtn.TabIndex = 23;
            ExitShopbtn.Text = "Покинути магазин";
            ExitShopbtn.UseVisualStyleBackColor = false;
            ExitShopbtn.Visible = false;
            ExitShopbtn.Click += ExitShopbtn_Click;
            // 
            // Buydaggerbtn
            // 
            Buydaggerbtn.BackColor = Color.Beige;
            Buydaggerbtn.BackgroundImage = Properties.Resources.curvedagger;
            Buydaggerbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Buydaggerbtn.FlatStyle = FlatStyle.Popup;
            Buydaggerbtn.Location = new Point(389, 127);
            Buydaggerbtn.Name = "Buydaggerbtn";
            Buydaggerbtn.Size = new Size(174, 162);
            Buydaggerbtn.TabIndex = 24;
            Buydaggerbtn.UseVisualStyleBackColor = false;
            Buydaggerbtn.Visible = false;
            Buydaggerbtn.Click += Buydaggerbtn_Click;
            // 
            // Buypotionbtn
            // 
            Buypotionbtn.BackColor = Color.Beige;
            Buypotionbtn.BackgroundImage = Properties.Resources.Potion;
            Buypotionbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Buypotionbtn.FlatStyle = FlatStyle.Popup;
            Buypotionbtn.Location = new Point(569, 127);
            Buypotionbtn.Name = "Buypotionbtn";
            Buypotionbtn.Size = new Size(174, 162);
            Buypotionbtn.TabIndex = 25;
            Buypotionbtn.UseVisualStyleBackColor = false;
            Buypotionbtn.Visible = false;
            Buypotionbtn.Click += Buypotionbtn_Click;
            // 
            // Buyarmourbtn
            // 
            Buyarmourbtn.BackColor = Color.Beige;
            Buyarmourbtn.BackgroundImage = Properties.Resources.platearmour;
            Buyarmourbtn.BackgroundImageLayout = ImageLayout.Center;
            Buyarmourbtn.FlatStyle = FlatStyle.Popup;
            Buyarmourbtn.Location = new Point(749, 127);
            Buyarmourbtn.Name = "Buyarmourbtn";
            Buyarmourbtn.Size = new Size(174, 162);
            Buyarmourbtn.TabIndex = 26;
            Buyarmourbtn.UseVisualStyleBackColor = false;
            Buyarmourbtn.Visible = false;
            Buyarmourbtn.Click += Buyarmourbtn_Click;
            // 
            // DaggerPricelbl
            // 
            DaggerPricelbl.AutoSize = true;
            DaggerPricelbl.BackColor = Color.Beige;
            DaggerPricelbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DaggerPricelbl.Location = new Point(450, 292);
            DaggerPricelbl.Name = "DaggerPricelbl";
            DaggerPricelbl.Size = new Size(62, 24);
            DaggerPricelbl.TabIndex = 27;
            DaggerPricelbl.Text = "50 з.м.";
            DaggerPricelbl.Visible = false;
            // 
            // PotionPricelbl
            // 
            PotionPricelbl.AutoSize = true;
            PotionPricelbl.BackColor = Color.Beige;
            PotionPricelbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PotionPricelbl.Location = new Point(631, 292);
            PotionPricelbl.Name = "PotionPricelbl";
            PotionPricelbl.Size = new Size(53, 24);
            PotionPricelbl.TabIndex = 28;
            PotionPricelbl.Text = "5 з.м.";
            PotionPricelbl.Visible = false;
            // 
            // ArmourPricelbl
            // 
            ArmourPricelbl.AutoSize = true;
            ArmourPricelbl.BackColor = Color.Beige;
            ArmourPricelbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ArmourPricelbl.Location = new Point(811, 292);
            ArmourPricelbl.Name = "ArmourPricelbl";
            ArmourPricelbl.Size = new Size(62, 24);
            ArmourPricelbl.TabIndex = 29;
            ArmourPricelbl.Text = "50 з.м.";
            ArmourPricelbl.Visible = false;
            // 
            // MCmoneylbl
            // 
            MCmoneylbl.AutoSize = true;
            MCmoneylbl.BackColor = Color.Beige;
            MCmoneylbl.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MCmoneylbl.Location = new Point(740, 426);
            MCmoneylbl.Name = "MCmoneylbl";
            MCmoneylbl.Size = new Size(101, 24);
            MCmoneylbl.TabIndex = 30;
            MCmoneylbl.Text = "Ваші гроші: ";
            MCmoneylbl.Visible = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 753);
            Controls.Add(MCmoneylbl);
            Controls.Add(ArmourPricelbl);
            Controls.Add(PotionPricelbl);
            Controls.Add(DaggerPricelbl);
            Controls.Add(Buyarmourbtn);
            Controls.Add(Buypotionbtn);
            Controls.Add(Buydaggerbtn);
            Controls.Add(ExitShopbtn);
            Controls.Add(Healbtn);
            Controls.Add(Defensebtn);
            Controls.Add(Attackbtn);
            Controls.Add(Continuebtn);
            Controls.Add(EnemyBox);
            Controls.Add(MCBox);
            Controls.Add(EnemyPicture);
            Controls.Add(MCPicture);
            Controls.Add(Dialoguelbl);
            Controls.Add(Shopbtn);
            Controls.Add(Locationlbl);
            Controls.Add(Restbtn);
            Controls.Add(Nextbtn);
            Controls.Add(Explorebtn);
            Controls.Add(Inventorybtn);
            Controls.Add(Returnbtn);
            Cursor = Cursors.Cross;
            Name = "Form6";
            Text = "Ліандель";
            WindowState = FormWindowState.Maximized;
            Load += Form6_Load;
            ((System.ComponentModel.ISupportInitialize)MCPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Returnbtn;
        private Button Inventorybtn;
        private Button Explorebtn;
        private Button Nextbtn;
        private Button Restbtn;
        private Label Locationlbl;
        private Button Shopbtn;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label Dialoguelbl;
        private PictureBox MCPicture;
        private PictureBox EnemyPicture;
        private ListBox MCBox;
        private ListBox EnemyBox;
        private Button Continuebtn;
        private Button Attackbtn;
        private Button Defensebtn;
        private Button Healbtn;
        private Button ExitShopbtn;
        private Button Buydaggerbtn;
        private Button Buypotionbtn;
        private Button Buyarmourbtn;
        private Label DaggerPricelbl;
        private Label PotionPricelbl;
        private Label ArmourPricelbl;
        private Label MCmoneylbl;
    }
}