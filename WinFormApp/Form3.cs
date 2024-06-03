using ClassLibraryForWinForms;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sweet_Pudding;


namespace WinFormApp
{
    public partial class Creation : Form
    {
        public MainCharacter MC;
        public Story story;
        string appearance;
        public Creation()
        {
            InitializeComponent();
        }

        private void Continuebtn_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                MC.Race = 0;
                MC.MaxHealthPoints = 25;
                MC.HealthPoints = MC.MaxHealthPoints;
                MC.Defense = 1;
                MC.DamageDealt = 2;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                MC.Race = 1;
                MC.MaxHealthPoints = 20;
                MC.HealthPoints = MC.MaxHealthPoints;
                MC.Defense = 1;
                MC.DamageDealt = 3;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                MC.Race = 2;
                MC.MaxHealthPoints = 20;
                MC.HealthPoints = MC.MaxHealthPoints;
                MC.Defense = 2;
                MC.DamageDealt = 2;
            }
            MC.Name = NameBox.Text;
            MC.IsMale = Male.Checked;
            MC.SetAppearance(appearance);
            Form4 form4 = new Form4();
            form4.MC = MC;
            form4.story = story;
            form4.Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                Damage_Lab.Text = $"Міць: {MC.DamageDealt}";
                Defense_lab.Text = $"Захист: {MC.Defense}";
                HP_lab.Text = $"Кількість здоров'я: {MC.HealthPoints + 5}";
                Image human_male = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human male.png");
                Image human_female = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human female.png");
                if (Male.Checked)
                {
                    pictureBox1.BackgroundImage = human_male;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human male.png";
                }
                else { pictureBox1.BackgroundImage = human_female; appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human female.png"; }
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                Damage_Lab.Text = $"Міць: {MC.DamageDealt + 1}";
                Defense_lab.Text = $"Захист: {MC.Defense}";
                HP_lab.Text = $"Кількість здоров'я: {MC.HealthPoints}";
                Image elf_male = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf male.png");
                Image elf_female = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf female.png");
                if (Male.Checked)
                {
                    pictureBox1.BackgroundImage = elf_male;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf male.png";
                }
                else { pictureBox1.BackgroundImage = elf_female; appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf female.png"; }
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                Damage_Lab.Text = $"Міць: {MC.DamageDealt}";
                Defense_lab.Text = $"Захист: {MC.Defense + 1}";
                HP_lab.Text = $"Кількість здоров'я: {MC.HealthPoints}";
                Image dwarf_male = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf male.png");
                Image dwarf_female = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf female.png");
                if (Male.Checked)
                {
                    pictureBox1.BackgroundImage = dwarf_male;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf male.png";
                }
                else { pictureBox1.BackgroundImage = dwarf_female; appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf female.png"; }
            }
        }

        private void Male_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Image human_male = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human male.png");
                    pictureBox1.BackgroundImage = human_male;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human male.png";
                    break;
                case 1:
                    Image elf_male = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf male.png");
                    pictureBox1.BackgroundImage = elf_male;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf male.png";
                    break;
                case 2:
                    Image dwarf_male = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf male.png");
                    pictureBox1.BackgroundImage = dwarf_male;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf male.png";
                    break;
            }
        }

        private void Female_CheckedChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Image human_female = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human female.png");
                    pictureBox1.BackgroundImage = human_female;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\human female.png";
                    break;
                case 1:
                    Image elf_female = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf female.png");
                    pictureBox1.BackgroundImage = elf_female;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\elf female.png";
                    break;
                case 2:
                    Image dwarf_female = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf female.png");
                    pictureBox1.BackgroundImage = dwarf_female;
                    appearance = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\dwarf female.png";
                    break;
            }
        }

        private void Creation_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            Continuebtn.Location = new Point((ActiveForm.Width / 2) - 150, (ActiveForm.Height) - 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}