namespace WinFormApp
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            pictureBox1 = new PictureBox();
            Play_button = new Button();
            Settingsbtn = new Button();
            Exitbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(470, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(393, 104);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Play_button
            // 
            Play_button.Anchor = AnchorStyles.Top;
            Play_button.BackColor = Color.DarkKhaki;
            Play_button.BackgroundImageLayout = ImageLayout.None;
            Play_button.Cursor = Cursors.Cross;
            Play_button.FlatStyle = FlatStyle.Popup;
            Play_button.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Play_button.ForeColor = Color.White;
            Play_button.Location = new Point(465, 250);
            Play_button.Margin = new Padding(3, 2, 3, 2);
            Play_button.MaximumSize = new Size(400, 72);
            Play_button.MinimumSize = new Size(254, 50);
            Play_button.Name = "Play_button";
            Play_button.Size = new Size(400, 50);
            Play_button.TabIndex = 1;
            Play_button.Text = "Грати";
            Play_button.UseVisualStyleBackColor = false;
            Play_button.Click += Play_button_Click;
            // 
            // Settingsbtn
            // 
            Settingsbtn.Anchor = AnchorStyles.Top;
            Settingsbtn.BackColor = Color.DarkKhaki;
            Settingsbtn.Cursor = Cursors.Cross;
            Settingsbtn.FlatStyle = FlatStyle.Popup;
            Settingsbtn.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Settingsbtn.ForeColor = Color.White;
            Settingsbtn.Location = new Point(465, 325);
            Settingsbtn.Margin = new Padding(3, 2, 3, 2);
            Settingsbtn.MaximumSize = new Size(400, 72);
            Settingsbtn.MinimumSize = new Size(254, 50);
            Settingsbtn.Name = "Settingsbtn";
            Settingsbtn.Size = new Size(400, 50);
            Settingsbtn.TabIndex = 2;
            Settingsbtn.Text = "Налаштування";
            Settingsbtn.UseVisualStyleBackColor = false;
            Settingsbtn.Click += Settingsbtn_Click;
            // 
            // Exitbtn
            // 
            Exitbtn.Anchor = AnchorStyles.Top;
            Exitbtn.BackColor = Color.DarkKhaki;
            Exitbtn.Cursor = Cursors.Cross;
            Exitbtn.FlatStyle = FlatStyle.Popup;
            Exitbtn.Font = new Font("Arial", 22.2F, FontStyle.Regular, GraphicsUnit.Point);
            Exitbtn.ForeColor = Color.White;
            Exitbtn.Location = new Point(465, 400);
            Exitbtn.Margin = new Padding(3, 2, 3, 2);
            Exitbtn.MaximumSize = new Size(400, 72);
            Exitbtn.MinimumSize = new Size(254, 50);
            Exitbtn.Name = "Exitbtn";
            Exitbtn.Size = new Size(400, 50);
            Exitbtn.TabIndex = 3;
            Exitbtn.Text = "Вихід";
            Exitbtn.UseVisualStyleBackColor = false;
            Exitbtn.Click += Exitbtn_Click;
            // 
            // Menu
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1348, 634);
            Controls.Add(Exitbtn);
            Controls.Add(Settingsbtn);
            Controls.Add(Play_button);
            Controls.Add(pictureBox1);
            Cursor = Cursors.Cross;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1122, 610);
            Name = "Menu";
            Text = "Меню";
            WindowState = FormWindowState.Maximized;
            Load += Menu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button Play_button;
        private Button Settingsbtn;
        private Button Exitbtn;
    }
}