namespace Sweet_Pudding
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            Deletelbl = new Label();
            DeleteProgressbtn = new Button();
            Returnbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Deletelbl
            // 
            Deletelbl.AutoSize = true;
            Deletelbl.Font = new Font("Arial Narrow", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Deletelbl.ForeColor = SystemColors.ActiveCaptionText;
            Deletelbl.Location = new Point(514, 107);
            Deletelbl.Name = "Deletelbl";
            Deletelbl.Size = new Size(223, 35);
            Deletelbl.TabIndex = 0;
            Deletelbl.Text = "Видалити прогрес";
            // 
            // DeleteProgressbtn
            // 
            DeleteProgressbtn.BackColor = Color.ForestGreen;
            DeleteProgressbtn.FlatStyle = FlatStyle.Flat;
            DeleteProgressbtn.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteProgressbtn.ForeColor = SystemColors.ControlLightLight;
            DeleteProgressbtn.Location = new Point(514, 208);
            DeleteProgressbtn.Name = "DeleteProgressbtn";
            DeleteProgressbtn.Size = new Size(208, 181);
            DeleteProgressbtn.TabIndex = 1;
            DeleteProgressbtn.Text = "Видалити";
            DeleteProgressbtn.UseVisualStyleBackColor = false;
            DeleteProgressbtn.Click += DeleteProgressbtn_Click;
            // 
            // Returnbtn
            // 
            Returnbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Returnbtn.BackgroundImage = Properties.Resources.Return1;
            Returnbtn.BackgroundImageLayout = ImageLayout.Zoom;
            Returnbtn.FlatAppearance.BorderSize = 0;
            Returnbtn.FlatStyle = FlatStyle.Flat;
            Returnbtn.Location = new Point(1159, 12);
            Returnbtn.Name = "Returnbtn";
            Returnbtn.Size = new Size(91, 93);
            Returnbtn.TabIndex = 2;
            Returnbtn.UseVisualStyleBackColor = true;
            Returnbtn.Click += Returnbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 477);
            label1.Name = "label1";
            label1.Size = new Size(703, 27);
            label1.TabIndex = 3;
            label1.Text = "Загалом управління в грі будується на тому, що ви натискаєте, те і відбудеться.";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 518);
            label2.Name = "label2";
            label2.Size = new Size(1123, 27);
            label2.TabIndex = 4;
            label2.Text = "Для продовження сюжету зазвичай потрібно натиснути на кнопку \"Продовжити\", та у окремих випадках на кнопку \"Мандрувати\".";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 562);
            label3.Name = "label3";
            label3.Size = new Size(959, 27);
            label3.TabIndex = 5;
            label3.Text = "Для зміни спорядження, ви можете скористатися Інвентарем, що доступний весь час, окрім сюжетних івентів.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(12, 603);
            label4.Name = "label4";
            label4.Size = new Size(1162, 27);
            label4.TabIndex = 6;
            label4.Text = "Щоб вилікуватися, або ж відновити своє HP, ви можете скористатися кнопкою \"Відпочити\", що підійме ваше здоров'я до максимуму.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(12, 644);
            label5.Name = "label5";
            label5.Size = new Size(1813, 27);
            label5.TabIndex = 7;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(12, 681);
            label6.Name = "label6";
            label6.Size = new Size(976, 27);
            label6.TabIndex = 8;
            label6.Text = "Грати рекомендується тільки в повноекранному режимі. Зміна розмірів вікна може зіпсувати ваш досвід від гри.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 717);
            label7.Name = "label7";
            label7.Size = new Size(1117, 27);
            label7.TabIndex = 9;
            label7.Text = "Для коректного збереження прогресу вимикайте гру через кнопку \"Вихід\" в головному меню. Для видалення кнопка \"Видалити\".";
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1262, 753);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Returnbtn);
            Controls.Add(DeleteProgressbtn);
            Controls.Add(Deletelbl);
            Cursor = Cursors.Cross;
            Name = "Settings";
            Text = "Налаштування";
            WindowState = FormWindowState.Maximized;
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Deletelbl;
        private Button DeleteProgressbtn;
        private Button Returnbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}