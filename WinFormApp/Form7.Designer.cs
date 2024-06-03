namespace Sweet_Pudding
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            Returnbtn = new Button();
            Inventorybtn = new Button();
            Attackbtn = new Button();
            Defensebtn = new Button();
            Healbtn = new Button();
            Continuebtn = new Button();
            Dialoguelbl = new Label();
            MCBox = new ListBox();
            EnemyBox = new ListBox();
            MCPicture = new PictureBox();
            EnemyPicture = new PictureBox();
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
            // 
            // Attackbtn
            // 
            Attackbtn.BackColor = Color.PaleGoldenrod;
            Attackbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Attackbtn.Location = new Point(513, 354);
            Attackbtn.Name = "Attackbtn";
            Attackbtn.Size = new Size(156, 61);
            Attackbtn.TabIndex = 2;
            Attackbtn.Text = "Атакувати";
            Attackbtn.UseVisualStyleBackColor = false;
            Attackbtn.Click += Attackbtn_Click;
            // 
            // Defensebtn
            // 
            Defensebtn.BackColor = Color.PaleGoldenrod;
            Defensebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Defensebtn.Location = new Point(687, 354);
            Defensebtn.Name = "Defensebtn";
            Defensebtn.Size = new Size(156, 61);
            Defensebtn.TabIndex = 3;
            Defensebtn.Text = "Захист";
            Defensebtn.UseVisualStyleBackColor = false;
            Defensebtn.Click += Defensebtn_Click;
            // 
            // Healbtn
            // 
            Healbtn.BackColor = Color.PaleGoldenrod;
            Healbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Healbtn.Location = new Point(598, 421);
            Healbtn.Name = "Healbtn";
            Healbtn.Size = new Size(156, 61);
            Healbtn.TabIndex = 4;
            Healbtn.Text = "Випити Зілля";
            Healbtn.UseVisualStyleBackColor = false;
            Healbtn.Click += Healbtn_Click;
            // 
            // Continuebtn
            // 
            Continuebtn.BackColor = Color.PaleGoldenrod;
            Continuebtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Continuebtn.Location = new Point(589, 501);
            Continuebtn.Name = "Continuebtn";
            Continuebtn.Size = new Size(156, 61);
            Continuebtn.TabIndex = 5;
            Continuebtn.Text = "Продовжити";
            Continuebtn.UseVisualStyleBackColor = false;
            Continuebtn.Click += Continuebtn_Click;
            // 
            // Dialoguelbl
            // 
            Dialoguelbl.AutoSize = true;
            Dialoguelbl.BackColor = Color.PaleGoldenrod;
            Dialoguelbl.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Dialoguelbl.Location = new Point(454, 235);
            Dialoguelbl.Name = "Dialoguelbl";
            Dialoguelbl.Size = new Size(60, 27);
            Dialoguelbl.TabIndex = 6;
            Dialoguelbl.Text = "label1";
            // 
            // MCBox
            // 
            MCBox.BackColor = Color.PaleGoldenrod;
            MCBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            MCBox.FormattingEnabled = true;
            MCBox.ItemHeight = 24;
            MCBox.Location = new Point(12, 508);
            MCBox.Name = "MCBox";
            MCBox.Size = new Size(371, 124);
            MCBox.TabIndex = 7;
            // 
            // EnemyBox
            // 
            EnemyBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnemyBox.BackColor = Color.PaleGoldenrod;
            EnemyBox.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            EnemyBox.FormattingEnabled = true;
            EnemyBox.ItemHeight = 24;
            EnemyBox.Location = new Point(879, 508);
            EnemyBox.Name = "EnemyBox";
            EnemyBox.Size = new Size(371, 124);
            EnemyBox.TabIndex = 8;
            // 
            // MCPicture
            // 
            MCPicture.BackColor = Color.PaleGoldenrod;
            MCPicture.BackgroundImageLayout = ImageLayout.Zoom;
            MCPicture.Location = new Point(12, 54);
            MCPicture.Name = "MCPicture";
            MCPicture.Size = new Size(371, 448);
            MCPicture.TabIndex = 9;
            MCPicture.TabStop = false;
            // 
            // EnemyPicture
            // 
            EnemyPicture.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            EnemyPicture.BackColor = Color.PaleGoldenrod;
            EnemyPicture.BackgroundImage = Properties.Resources.BadGuy;
            EnemyPicture.BackgroundImageLayout = ImageLayout.Zoom;
            EnemyPicture.Location = new Point(879, 54);
            EnemyPicture.Name = "EnemyPicture";
            EnemyPicture.Size = new Size(371, 448);
            EnemyPicture.TabIndex = 10;
            EnemyPicture.TabStop = false;
            // 
            // Form7
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 753);
            Controls.Add(EnemyPicture);
            Controls.Add(MCPicture);
            Controls.Add(EnemyBox);
            Controls.Add(MCBox);
            Controls.Add(Dialoguelbl);
            Controls.Add(Continuebtn);
            Controls.Add(Healbtn);
            Controls.Add(Defensebtn);
            Controls.Add(Attackbtn);
            Controls.Add(Inventorybtn);
            Controls.Add(Returnbtn);
            Cursor = Cursors.Cross;
            Name = "Form7";
            Text = "Вежа Лиходія";
            WindowState = FormWindowState.Maximized;
            Load += Form7_Load;
            ((System.ComponentModel.ISupportInitialize)MCPicture).EndInit();
            ((System.ComponentModel.ISupportInitialize)EnemyPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Returnbtn;
        private Button Inventorybtn;
        private Button Attackbtn;
        private Button Defensebtn;
        private Button Healbtn;
        private Button Continuebtn;
        private Label Dialoguelbl;
        private ListBox MCBox;
        private ListBox EnemyBox;
        private PictureBox MCPicture;
        private PictureBox EnemyPicture;
    }
}