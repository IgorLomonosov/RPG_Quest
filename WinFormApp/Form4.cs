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
    public partial class Form4 : Form
    {
        public MainCharacter MC;
        public Story story;
        NPC boar;
        int i;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            story.Location = 1;
            Locationlbl.Location = new Point((ActiveForm.Width / 2) - 137, 120);
            Dialoguelbl.Location = new Point(280, 260);
            Continuebtn.Location = new Point((ActiveForm.Width / 2) - 100, (ActiveForm.Height / 2));
            Explorebtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 100);
            Nextbtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2) - 100);
            Restbtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2));
            Attackbtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 50);
            Defensebtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2) - 50);
            Healbtn.Location = new Point((ActiveForm.Width / 2) - 100, (ActiveForm.Height / 2) + 25);
            if (story.GameState == 0)
            {
                Dialoguelbl.Text = "Ви проходите полем, та бачите як у вашу сторону біжить схвильований чоловік. Він страшно махає руками, намагаючись привернути вашу увагу.";
                i = 0;
            }
            else if (story.GameState == 1)
            {
                Locationlbl.Visible = false;
                Nextbtn.Visible = false;
                Restbtn.Visible = false;
                Explorebtn.Visible = true;
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Dialoguelbl.Visible = true;
                Continuebtn.Visible = false;
                i = 5;
            }
            else if (story.GameState == 2)
            {
                Nextbtn.Visible = false;
                Explorebtn.Visible = true;
                Locationlbl.Visible = true;
                Restbtn.Visible = true;
                Inventorybtn.Visible = true;
                Returnbtn.Visible = true;
                i = 21;
            }
        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MC = MC;
            form6.story = story;
            form6.Show();
            this.Close();
        }

        private void Restbtn_Click(object sender, EventArgs e)
        {
            MC.Rest();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.YoStory = story;
            menu.YoCharacter = MC;
            menu.Show();
            this.Close();
        }

        private void Inventorybtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventory inventory = new Inventory();
            inventory.MC = MC;
            inventory.story = story;
            inventory.Show();
        }

        private void Explorebtn_Click(object sender, EventArgs e)
        {
            if (story.GameState == 0)
            {
                Locationlbl.Visible = false;
                Nextbtn.Visible = false;
                Restbtn.Visible = false;
                Explorebtn.Visible = false;
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Dialoguelbl.Visible = true;
                Continuebtn.Visible = true;
            }
            else if (story.GameState == 1)
            {
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Locationlbl.Visible = false;
                Explorebtn.Visible = false;
                Continuebtn.Visible = true;
                Dialoguelbl.Text = "Ви проходите повз невеличку ферму глибше в хащі, та чуєте гучний шум, тріск гілок, та крик";
            }
            else if (story.GameState == 2)
            {
                Dialoguelbl.Visible = true;
                Continuebtn.Visible = true;
                Explorebtn.Visible = false;
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Locationlbl.Visible = false;
                Restbtn.Visible = false;
                Dialoguelbl.Text = "Ви прямуєте на вихід із ферми. Біля воріт вас вже чекає донька минулого короля Лемурії Осана.";

            }

        }
        public void MCRefresh()
        {
            MCBox.Items.Clear();
            MCBox.Items.Add(MC.Name);
            MCBox.Items.Add($"{MC.HealthPoints}/{MC.MaxHealthPoints}");
            MCBox.Items.Add($"Міць:{MC.DamageDealt + MC.Weapon.DamageAdded}");
            MCBox.Items.Add($"Захист:{MC.Defense + MC.Armour.DefenseAdded}");
            MCBox.Items.Add($"Кількість зілль:{MC.PotionsHeld}");
        }
        public void EnemyRefresh()
        {
            EnemyBox.Items.Clear();
            EnemyBox.Items.Add(boar.Name);
            EnemyBox.Items.Add($"{boar.HealthPoints}/{boar.MaxHealthPoints}");
            EnemyBox.Items.Add($"Міць:{boar.DamageDealt}");
            EnemyBox.Items.Add($"Захист:{boar.Defense}");
        }
        private void Continuebtn_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    Dialoguelbl.Text = "Коли він підбіг до вас, ви бачите кров на його одязі. Після декількох секунд, нарешті схопивши потрібне повітря Чоловік мовив:";
                    i++; break;
                case 1:
                    Dialoguelbl.Text = "\"Будь ласка допоможіть, там, у лісі, величезний кабан, він напав на нас коли ми збирали ягоди, хоч у мене й був меч, мені не вистачило сили його вбити.\"";
                    i++; break;
                case 2:
                    Dialoguelbl.Text = "\"Якщо ви мені допоможете, я вам заплачу. Мої жінка, діти, наші посіви - все в небезпеці.Ось тримайте мій меч, вам він принесе більше користі.\"";
                    story.WoodenSwordAquired = true;
                    Weapon wood = new Weapon("Меч із дерева", 1);
                    MC.ChangeWeapon(wood);
                    Quest quest = new Quest("Вбити дикого кабана", "Вбийте дикого кабана, що лякає робітників на полі.", 50, 0);
                    MC.quests.Add(quest);
                    i++; break;
                case 3:
                    Dialoguelbl.Text = "Отримано дерев'яний меч.";
                    i++; break;
                case 4:
                    Dialoguelbl.Text = "Отримано новий квест \"Вбити дикого кабана\"";
                    story.GameState = 1;
                    Inventorybtn.Visible = true;
                    Returnbtn.Visible = true;
                    Explorebtn.Visible = true;
                    Continuebtn.Visible = false;
                    Locationlbl.Visible = true;
                    i++; break;
                case 5:
                    Explorebtn.Visible = false;
                    Dialoguelbl.Text = "Ви біжите назустріч звуку, та через момент ви бачите жінку, одягнену в легке біле плаття, що втікає від кабана.";
                    i++; break;
                case 6:
                    Dialoguelbl.Text = "Кабан побачив у вас свою нову жертву, та несеться на вас в атаку. Захищайтеся!";
                    i++; break;
                case 7:
                    Dialoguelbl.Visible = false;
                    Continuebtn.Visible = false;
                    YoPicturebox.Visible = true;
                    pictureBox2.Visible = true;
                    Attackbtn.Visible = true;
                    Defensebtn.Visible = true;
                    Healbtn.Visible = true;
                    MCBox.Visible = true;
                    EnemyBox.Visible = true;
                    boar = new NPC("Дикий кабан", 20, true, 1, 1, 3);
                    YoPicturebox.BackgroundImage = Image.FromFile(MC.GetAppearance());
                    MCRefresh();
                    EnemyRefresh();
                    i++; break;
                case 8:
                    Dialoguelbl.Text = "Після перемоги ви йдете до тієї дівчини, що втікала від кабана. Вона виглядає наляканою, та аж ніяк не місцевою.";
                    i++; break;
                case 9:
                    Dialoguelbl.Text = "\"Дякую вам, що врятували мене, я донька минулого короля Лемурії, Осана. Після того як Лиходій захопив владу, все пішло нашкереберть.\"";
                    i++; break;
                case 10:
                    Dialoguelbl.Text = "\"Прийміть від мене подяку, нажаль зараз я більше нічого не зможу вам дати.\"";
                    i++; break;
                case 11:
                    Dialoguelbl.Text = "\"Проте, якщо б ви провели мене у місто Ліандель, то я змогла б вам якось допомогти перемогти злого Лиходія.\"";
                    i++; break;
                case 12:
                    Dialoguelbl.Text = "\"Я буду чекати вас на виході з міста, коли ви закінчите ваші справи на цій фермі.\"";
                    i++; break;
                case 13:
                    Dialoguelbl.Text = "Ви повертаєтеся до ферми, та знаходите того самого Чоловіка. Він зрадів, як тільки вас побачив, та не можу зупинити сліз радості.";
                    i++; break;
                case 14:
                    Dialoguelbl.Text = "\"Дякую вам, я вам так дякую, ми б нічого не змогли б без вас зробити, хоча тей кабан і нагадував звичайного, але мені здається це не так!\"";
                    i++; break;
                case 15:
                    Dialoguelbl.Text = "\"З часу, коли Лиходій захопив королівство, багато тварин збожеволіли, та почали себе вести набагато агресивніше.\"";
                    i++; break;
                case 16:
                    Dialoguelbl.Text = "\"Ще раз дякую що допомогли нам, я не забув, що я обіцяв вам заплатити. Ось візьміть.\"Чоловік тягне до вас мішечок";
                    i++; break;
                case 17:
                    Dialoguelbl.Text = "Ви виконали завдання \"Вбити дикого кабана.\" Ви отримали від Чоловіка мішечок із 50 золотими монетами.";
                    MC.FinishQuest(MC.quests[1]);
                    i++; break;
                case 18:
                    Dialoguelbl.Text = "\"А також візміть мої сімейні обладунки та меч, я фермер, мені зброя та обладунки ні до чого, а вам вони можуть знадобитися.\"";
                    i++; break;
                case 19:
                    Dialoguelbl.Text = "Ви отримали Меч із каменя, та Шкіряну броню.";
                    story.StoneSwordAquired = true;
                    story.LeatherArmourAquired = true;
                    i++; break;
                case 20:
                    Dialoguelbl.Text = "За допомогою шкіри кабана вам вдалося покращити Шкіряну броню в Потовщену шкіряну броню";
                    story.HardenedLeatherArmourAquired = true;
                    story.GameState = 2;
                    Inventorybtn.Visible = true;
                    Returnbtn.Visible = true;
                    Restbtn.Visible = true;
                    Continuebtn.Visible = false;
                    Explorebtn.Visible = true;
                    i++; break;
                case 21:
                    Dialoguelbl.Text = "\"Ну що ж, ходімо героє\"";
                    Nextbtn.Visible = true;
                    Continuebtn.Visible = false;
                    i++; break;
            }
        }

        private void Attackbtn_Click(object sender, EventArgs e)
        {
            MC.Attack(ref boar);
            if (boar.HealthPoints <= 0)
            {
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                YoPicturebox.Visible = false;
                pictureBox2.Visible = false;
                MCBox.Visible = false;
                EnemyBox.Visible = false;
                Dialoguelbl.Visible = true;
                Dialoguelbl.Text = "Ви перемогли кабана! Ви отримали шкіру кабана.";
                Continuebtn.Visible = true;
            }
            Random random = new Random();
            if (random.Next(0, 10) <= 3)
            {
                MC.Attacked(boar);
                if (MC.HealthPoints <= 0)
                {
                    Attackbtn.Visible = false;
                    Defensebtn.Visible = false;
                    Healbtn.Visible = false;
                    YoPicturebox.Visible = false;
                    pictureBox2.Visible = false;
                    MCBox.Visible = false;
                    EnemyBox.Visible = false;
                    DialogResult result = MessageBox.Show("Програш!", "Ви програли кабану", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                    else
                        this.Close();
                }
            }
            MCRefresh();
            EnemyRefresh();
        }

        private void Defensebtn_Click(object sender, EventArgs e)
        {
            MC.Defended(boar);
            if (MC.HealthPoints <= 0)
            {
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                YoPicturebox.Visible = false;
                pictureBox2.Visible = false;
                MCBox.Visible = false;
                EnemyBox.Visible = false;
                DialogResult result = MessageBox.Show("Програш!", "Ви програли кабану", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
                else
                    this.Close();
            }
            MCRefresh();
            EnemyRefresh();
        }

        private void Healbtn_Click(object sender, EventArgs e)
        {
            if (MC.PotionsHeld > 0)
            {
                int potions = MC.PotionsHeld;
                MC.UsePotion();
                if (potions == MC.PotionsHeld)
                {
                    MessageBox.Show("У вас максимальне здоров'я!");
                }
                MCRefresh();
                EnemyRefresh();
            }
            else MessageBox.Show("У вас закінчилися зілля здоров'я!");
        }
    }
}