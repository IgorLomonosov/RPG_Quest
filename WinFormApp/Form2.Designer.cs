namespace WinFormApp
{
    partial class Prologue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prologue));
            Story1 = new Label();
            Continue = new Button();
            Story2 = new Label();
            Story3 = new Label();
            Story4 = new Label();
            Story5 = new Label();
            Returnbtn = new Button();
            SuspendLayout();
            // 
            // Story1
            // 
            Story1.Anchor = AnchorStyles.Top;
            Story1.AutoSize = true;
            Story1.BackColor = Color.DimGray;
            Story1.FlatStyle = FlatStyle.Popup;
            Story1.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Story1.ForeColor = Color.White;
            Story1.Location = new Point(302, 227);
            Story1.MaximumSize = new Size(960, 60);
            Story1.Name = "Story1";
            Story1.Size = new Size(647, 39);
            Story1.TabIndex = 0;
            Story1.Text = "У маленькій країні Лемурії сталося лихо.";
            Story1.TextAlign = ContentAlignment.MiddleCenter;
            Story1.Visible = false;
            // 
            // Continue
            // 
            Continue.Anchor = AnchorStyles.Top;
            Continue.BackColor = Color.DarkSlateGray;
            Continue.FlatStyle = FlatStyle.Popup;
            Continue.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Continue.ForeColor = Color.White;
            Continue.Location = new Point(470, 488);
            Continue.Name = "Continue";
            Continue.Size = new Size(321, 101);
            Continue.TabIndex = 1;
            Continue.Text = "Продовжити";
            Continue.UseVisualStyleBackColor = false;
            Continue.Click += Continue_Click;
            // 
            // Story2
            // 
            Story2.Anchor = AnchorStyles.Top;
            Story2.AutoSize = true;
            Story2.BackColor = Color.DimGray;
            Story2.FlatStyle = FlatStyle.Popup;
            Story2.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Story2.ForeColor = Color.White;
            Story2.Location = new Point(238, 265);
            Story2.Name = "Story2";
            Story2.Size = new Size(754, 39);
            Story2.TabIndex = 2;
            Story2.Text = "Темний лицар Лиходій вирішив захопити владу.";
            Story2.Visible = false;
            // 
            // Story3
            // 
            Story3.Anchor = AnchorStyles.Top;
            Story3.AutoSize = true;
            Story3.BackColor = Color.DimGray;
            Story3.FlatStyle = FlatStyle.Popup;
            Story3.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Story3.ForeColor = Color.White;
            Story3.Location = new Point(171, 304);
            Story3.Name = "Story3";
            Story3.Size = new Size(884, 39);
            Story3.TabIndex = 3;
            Story3.Text = "І тільки мужній та відважний воїн зможе повернути мир.";
            Story3.Visible = false;
            // 
            // Story4
            // 
            Story4.Anchor = AnchorStyles.Top;
            Story4.AutoSize = true;
            Story4.BackColor = Color.DimGray;
            Story4.FlatStyle = FlatStyle.Popup;
            Story4.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Story4.ForeColor = Color.White;
            Story4.Location = new Point(171, 343);
            Story4.Name = "Story4";
            Story4.Size = new Size(891, 39);
            Story4.TabIndex = 4;
            Story4.Text = "А чи вдасться це нашому герою? Ми зараз і дізнаємося.";
            Story4.Visible = false;
            // 
            // Story5
            // 
            Story5.Anchor = AnchorStyles.Top;
            Story5.AutoSize = true;
            Story5.BackColor = Color.DimGray;
            Story5.FlatStyle = FlatStyle.Popup;
            Story5.Font = new Font("Arial", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            Story5.ForeColor = Color.White;
            Story5.Location = new Point(457, 381);
            Story5.Name = "Story5";
            Story5.Size = new Size(342, 39);
            Story5.TabIndex = 5;
            Story5.Text = "Приємної гри, герою!";
            Story5.Visible = false;
            // 
            // Returnbtn
            // 
            Returnbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Returnbtn.BackColor = Color.Transparent;
            Returnbtn.BackgroundImage = Sweet_Pudding.Properties.Resources.Return1;
            Returnbtn.BackgroundImageLayout = ImageLayout.Stretch;
            Returnbtn.FlatAppearance.BorderSize = 0;
            Returnbtn.FlatStyle = FlatStyle.Flat;
            Returnbtn.Location = new Point(1163, 12);
            Returnbtn.Name = "Returnbtn";
            Returnbtn.Size = new Size(91, 93);
            Returnbtn.TabIndex = 6;
            Returnbtn.UseVisualStyleBackColor = false;
            Returnbtn.Click += button1_Click;
            // 
            // Prologue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1264, 753);
            Controls.Add(Returnbtn);
            Controls.Add(Story5);
            Controls.Add(Story4);
            Controls.Add(Story3);
            Controls.Add(Story2);
            Controls.Add(Continue);
            Controls.Add(Story1);
            Cursor = Cursors.Cross;
            MinimumSize = new Size(1280, 798);
            Name = "Prologue";
            Text = "Пролог";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Story1;
        private Button Continue;
        private Label Story2;
        private Label Story3;
        private Label Story4;
        private Label Story5;
        private Button Returnbtn;
    }
}