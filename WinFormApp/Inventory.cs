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
    public partial class Inventory : Form
    {
        public MainCharacter MC;
        public Story story;
        public Inventory()
        {
            InitializeComponent();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            if (story.LeatherArmourAquired)
                LeatherArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\leatherarmour.png");
            else
                LeatherArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\leatherarmourlocked.png");

            if (story.HardenedLeatherArmourAquired)
                HardLeatherArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\hardenedleatherarmour.png");
            else
                HardLeatherArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\hardenedleatherarmourlocked.png");

            if (story.IronArmourAquired)
                IronArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\ironarmour.png");
            else
                IronArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\ironarmourlocked.png");

            if (story.PlateArmourAquired)
                PlateArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\platearmour.png");
            else
                PlateArmbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\platearmourlocked.png");

            if (story.WoodenSwordAquired)
                WoodSwordbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\woodensword.png");
            else
                WoodSwordbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\woodenswordlocked.png");

            if (story.StoneSwordAquired)
                StoneSwordbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\stonesword.png");
            else
                StoneSwordbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\stoneswordlocked.png");

            if (story.IronSwordAquired)
                IronSwordbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\ironsword.png");
            else
                IronSwordbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\ironswordlocked.png");

            if (story.CurvedDaggerAquired)
                CurveDaggerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\curvedagger.png");
            else
                CurveDaggerbtn.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\curvedaggerlocked.png");

            PotionCount.Text = MC.PotionsHeld.ToString();

            pictureBox1.BackgroundImage = Image.FromFile(MC.GetAppearance());

            RefreshList();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            if (story.Location == 1)
            {
                Form4 form4 = new Form4();
                form4.MC = MC;
                form4.story = story;
                form4.Show();
                this.Close();
            }
            else if (story.Location == 2)
            {
                Form6 form6 = new Form6();
                form6.MC = MC;
                form6.story = story;
                form6.Show();
                this.Close();
            }
            else if (story.Location == 3)
            {
                Form7 form7 = new Form7();
                form7.MC = MC;
                form7.story = story;
                form7.Show();
                this.Close();
            }
        }

        private void LeatherArmbtn_Click(object sender, EventArgs e)
        {
            Armour leather = new Armour("Шкіряна броня", 1);
            if (story.LeatherArmourAquired)
            {
                MC.ChangeArmour(leather);
            }
            else MessageBox.Show("У вас ще немає цих обладунків!");
            RefreshList();
        }

        private void HardLeatherArmbtn_Click(object sender, EventArgs e)
        {
            Armour hardenedleather = new Armour("Потовщена шкіряна броня", 2);
            if (story.HardenedLeatherArmourAquired)
            {
                MC.ChangeArmour(hardenedleather);
            }
            else MessageBox.Show("У вас ще немає цих обладунків!");
            RefreshList();
        }

        private void CurveDaggerbtn_Click(object sender, EventArgs e)
        {
            Weapon curvedagger = new Weapon("Вигнутий кинжал", 4);
            if (story.CurvedDaggerAquired)
            {
                MC.ChangeWeapon(curvedagger);
            }
            else MessageBox.Show("У вас ще немає цієї зброї!");
            RefreshList();
        }

        private void IronArmbtn_Click(object sender, EventArgs e)
        {
            Armour iron = new Armour("Залізна броня", 3);
            if (story.IronArmourAquired)
            {
                MC.ChangeArmour(iron);
            }
            else MessageBox.Show("У вас ще немає цих обладунків!");
            RefreshList();
        }

        private void PlateArmbtn_Click(object sender, EventArgs e)
        {
            Armour plate = new Armour("Суцільно-металева броня", 4);
            if (story.PlateArmourAquired)
            {
                MC.ChangeArmour(plate);
            }
            else MessageBox.Show("У вас ще немає цих обладунків!");
            RefreshList();
        }

        private void WoodSwordbtn_Click(object sender, EventArgs e)
        {
            Weapon wood = new Weapon("Меч із дерева", 1);
            if (story.WoodenSwordAquired)
            {
                MC.ChangeWeapon(wood);
            }
            else MessageBox.Show("У вас ще немає цієї зброї");
            RefreshList();
        }

        private void StoneSwordbtn_Click(object sender, EventArgs e)
        {
            Weapon stone = new Weapon("Меч із каменя", 2);
            if (story.StoneSwordAquired)
            {
                MC.ChangeWeapon(stone);
            }
            else MessageBox.Show("У вас ще немає цієї зброї!");
            RefreshList();
        }

        private void IronSwordbtn_Click(object sender, EventArgs e)
        {
            Weapon iron = new Weapon("Залізний меч", 3);
            if (story.IronSwordAquired)
            {
                MC.ChangeWeapon(iron);
            }
            else MessageBox.Show("У вас ще немає цієї зброї!");
            RefreshList();
        }
        public void RefreshList()
        {
            Infor.Items.Clear();
            Infor.Items.Add(MC.Name);
            Infor.Items.Add($"Кількість здоров'я:{MC.HealthPoints}/{MC.MaxHealthPoints}");
            Infor.Items.Add($"Сила атаки: {MC.DamageDealt} + {MC.Weapon.DamageAdded} шкоди від зброї({MC.Weapon.Name})");
            Infor.Items.Add($"Захист від атак: {MC.Defense} + {MC.Armour.DefenseAdded} захисту від обладунків({MC.Armour.Name})");
            Infor.Items.Add($"Кількість монет: {MC.MoneyHeld}");
            if (MC.quests.Count > 0)
            {
                Infor.Items.Add($"Завдання:");
                for (int i = 0; i < MC.quests.Count; i++)
                {
                    Infor.Items.Add($"#{i + 1}: {MC.quests[i].Name}");
                    Infor.Items.Add($"{MC.quests[i].Description}");
                }
            }
        }

        private void Potionbtn_Click(object sender, EventArgs e)
        {
            int potions = MC.PotionsHeld;
            MC.UsePotion();
            if (potions != MC.PotionsHeld)
            {
                PotionCount.Text = MC.PotionsHeld.ToString();
            }
            else MessageBox.Show("У вас максимальне здоров'я!");
        }
    }
}