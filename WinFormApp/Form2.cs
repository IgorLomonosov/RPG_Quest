using ClassLibraryForWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sweet_Pudding;


namespace WinFormApp
{
    public partial class Prologue : Form
    {
        int i;
        public MainCharacter MC;
        public Story story;
        public Prologue()
        {
            InitializeComponent();
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (i == -1)
            {
                Continue.Text = "Продовжити";
            }
            switch (i)
            {
                case -1:
                    Story1.Visible = true; i++; break;
                case 0:
                    Story2.Visible = true; i++; break;
                case 1:
                    Story3.Visible = true; i++; break;
                case 2:
                    Story4.Visible = true; i++; break;
                case 3:
                    Story5.Visible = true; i++; break;
                case 4:
                    Creation creation = new Creation();
                    creation.story = story;
                    creation.MC = MC;
                    creation.Show();
                    this.Close();
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Continue.Location = new Point((ActiveForm.Width / 2) - 175, (ActiveForm.Height / 2) + 100);
            Story1.Location = new Point((ActiveForm.Width / 2) - 335, (ActiveForm.Height / 2) - 375);
            Story2.Location = new Point((ActiveForm.Width / 2) - 390, (ActiveForm.Height / 2) - 335);
            Story3.Location = new Point((ActiveForm.Width / 2) - 450, (ActiveForm.Height / 2) - 295);
            Story4.Location = new Point((ActiveForm.Width / 2) - 453, (ActiveForm.Height / 2) - 255);
            Story5.Location = new Point((ActiveForm.Width / 2) - 195, (ActiveForm.Height / 2) - 215);
            Continue.Text = "Розпочати історію";
            i = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Close();
        }
    }
}