namespace WinFormApp
{
    partial class Creation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Creation));
            NameBox = new TextBox();
            Male = new RadioButton();
            Female = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            Continuebtn = new Button();
            comboBox1 = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label = new Label();
            Damage_Lab = new Label();
            Defense_lab = new Label();
            HP_lab = new Label();
            Returnbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // NameBox
            // 
            NameBox.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            NameBox.Location = new Point(571, 324);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(199, 34);
            NameBox.TabIndex = 0;
            // 
            // Male
            // 
            Male.AutoSize = true;
            Male.Checked = true;
            Male.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Male.Location = new Point(550, 402);
            Male.Name = "Male";
            Male.Size = new Size(111, 31);
            Male.TabIndex = 1;
            Male.TabStop = true;
            Male.Text = "Чоловіча";
            Male.UseVisualStyleBackColor = true;
            Male.CheckedChanged += Male_CheckedChanged;
            // 
            // Female
            // 
            Female.AutoSize = true;
            Female.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Female.Location = new Point(676, 402);
            Female.Name = "Female";
            Female.Size = new Size(94, 31);
            Female.TabIndex = 2;
            Female.TabStop = true;
            Female.Text = "Жіноча";
            Female.UseVisualStyleBackColor = true;
            Female.CheckedChanged += Female_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonShadow;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(509, 327);
            label1.Name = "label1";
            label1.Size = new Size(43, 27);
            label1.TabIndex = 3;
            label1.Text = "Ім'я";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(636, 372);
            label2.Name = "label2";
            label2.Size = new Size(64, 27);
            label2.TabIndex = 4;
            label2.Text = "Стать";
            // 
            // Continuebtn
            // 
            Continuebtn.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Continuebtn.Location = new Point(550, 642);
            Continuebtn.Name = "Continuebtn";
            Continuebtn.Size = new Size(193, 99);
            Continuebtn.TabIndex = 5;
            Continuebtn.Text = "Підтвердити";
            Continuebtn.UseVisualStyleBackColor = true;
            Continuebtn.Click += Continuebtn_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Людина", "Ельф", "Дварф" });
            comboBox1.Location = new Point(571, 439);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 35);
            comboBox1.TabIndex = 6;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonShadow;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(501, 442);
            label3.Name = "label3";
            label3.Size = new Size(54, 27);
            label3.TabIndex = 7;
            label3.Text = "Раса";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Silver;
            pictureBox1.BackgroundImage = Sweet_Pudding.Properties.Resources.human_male;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(372, 188);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 448);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = SystemColors.ButtonShadow;
            label.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(509, 496);
            label.Name = "label";
            label.Size = new Size(267, 27);
            label.TabIndex = 9;
            label.Text = "Характеристики вибору раси:";
            // 
            // Damage_Lab
            // 
            Damage_Lab.AutoSize = true;
            Damage_Lab.BackColor = SystemColors.ButtonShadow;
            Damage_Lab.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Damage_Lab.ForeColor = Color.White;
            Damage_Lab.Location = new Point(509, 531);
            Damage_Lab.Name = "Damage_Lab";
            Damage_Lab.Size = new Size(64, 27);
            Damage_Lab.TabIndex = 10;
            Damage_Lab.Text = "Міць: ";
            // 
            // Defense_lab
            // 
            Defense_lab.AutoSize = true;
            Defense_lab.BackColor = SystemColors.ButtonShadow;
            Defense_lab.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            Defense_lab.ForeColor = Color.White;
            Defense_lab.Location = new Point(509, 566);
            Defense_lab.Name = "Defense_lab";
            Defense_lab.Size = new Size(76, 27);
            Defense_lab.TabIndex = 11;
            Defense_lab.Text = "Захист:";
            // 
            // HP_lab
            // 
            HP_lab.AutoSize = true;
            HP_lab.BackColor = SystemColors.ButtonShadow;
            HP_lab.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            HP_lab.ForeColor = Color.White;
            HP_lab.Location = new Point(509, 596);
            HP_lab.Name = "HP_lab";
            HP_lab.Size = new Size(177, 27);
            HP_lab.TabIndex = 12;
            HP_lab.Text = "Кількість здоров'я: ";
            // 
            // Returnbtn
            // 
            Returnbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Returnbtn.BackColor = Color.Transparent;
            Returnbtn.BackgroundImage = Sweet_Pudding.Properties.Resources.Return1;
            Returnbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Returnbtn.FlatAppearance.BorderSize = 0;
            Returnbtn.FlatStyle = FlatStyle.Flat;
            Returnbtn.Location = new Point(1159, 12);
            Returnbtn.Name = "Returnbtn";
            Returnbtn.Size = new Size(91, 93);
            Returnbtn.TabIndex = 13;
            Returnbtn.UseVisualStyleBackColor = false;
            Returnbtn.Click += button1_Click;
            // 
            // Creation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1262, 753);
            Controls.Add(Returnbtn);
            Controls.Add(HP_lab);
            Controls.Add(Defense_lab);
            Controls.Add(Damage_Lab);
            Controls.Add(label);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(Continuebtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Female);
            Controls.Add(Male);
            Controls.Add(NameBox);
            Cursor = Cursors.Cross;
            Name = "Creation";
            Text = "Створення персонажу";
            WindowState = FormWindowState.Maximized;
            Load += Creation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NameBox;
        private RadioButton Male;
        private RadioButton Female;
        private Label label1;
        private Label label2;
        private Button Continuebtn;
        private ComboBox comboBox1;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label;
        private Label Damage_Lab;
        private Label Defense_lab;
        private Label HP_lab;
        private Button Returnbtn;
    }
}