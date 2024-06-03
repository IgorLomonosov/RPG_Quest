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
using WinFormApp;

namespace Sweet_Pudding
{
    public partial class Form7 : Form
    {
        public Story story;
        public MainCharacter MC;
        int i;
        NPC BadGuy;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            if (story.Location == 2)
            {
                story.Location = 3;
                story.GameState = 0;
            }
            if (story.GameState == 0)
            {
                i = 0;
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                MCBox.Visible = false;
                MCPicture.Visible = false;
                EnemyBox.Visible = false;
                EnemyPicture.Visible = false;
                Dialoguelbl.Visible = true;
                Continuebtn.Visible = true;
                Dialoguelbl.Text = "Ви проходите до замку. Перед вами велика вежа, і тільки й чути брязкіт обладунків.";
            }
            Dialoguelbl.Location = new Point(280, 260);
            Continuebtn.Location = new Point((ActiveForm.Width / 2) - 100, (ActiveForm.Height / 2));
            Attackbtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 50);
            Defensebtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2) - 50);
            Healbtn.Location = new Point((ActiveForm.Width / 2) - 100, (ActiveForm.Height / 2) + 25);
            MCPicture.BackgroundImage = Image.FromFile(MC.GetAppearance());
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.YoCharacter = MC;
            menu.YoStory = story;
            menu.Show();
            this.Close();
        }

        private void Continuebtn_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    Dialoguelbl.Text = "З кожною миттю, звук стає все гучніше та гучніше, гучніше та гучніше.";
                    i++; break;
                case 1:
                    Dialoguelbl.Text = "Звук меча, що тягнеться по сходах також стає гучніше, завдаючи шкоди вухам тих, хто готувався зіткнутися з хазяїном цього ж меча.";
                    i++; break;
                case 2:
                    Dialoguelbl.Text = "\"Це я, Осанна, і я прийшла повернути те, що моє по праву крові. Лиходіє, вийди на останній бій\"";
                    i++; break;
                case 3:
                    Dialoguelbl.Text = "Гуркіт чобіт, скрегіт обладунків, пронизливий скрип меча, усе це наганяло жаху на наших героїв.";
                    i++; break;
                case 4:
                    Dialoguelbl.Text = "\"Виходь Лиходіє, це останній бій.\"";
                    i++; break;
                case 5:
                    Dialoguelbl.Text = "Двері вежі з гуркотом вилетіли з петель. І нарешті з'явився тей, хто зумів власноруч підкорити собі усе королівство. Лиходій.";
                    i++; break;
                case 6:
                    Dialoguelbl.Text = "Він не мовив ні слова, а просто направив свій могутній меч на героя. Це означало початок бою.";
                    i++; break;
                case 7:
                    Dialoguelbl.Visible = false;
                    Continuebtn.Visible = false;
                    Attackbtn.Visible = true;
                    Defensebtn.Visible = true;
                    Healbtn.Visible = true;
                    MCBox.Visible = true;
                    MCPicture.Visible = true;
                    EnemyBox.Visible = true;
                    EnemyPicture.Visible = true;
                    BadGuy = new NPC("Лиходій", 25, true, 7, 3, 3);
                    MCRefresh();
                    EnemyRefresh();
                    i++; break;
                case 8:
                    Dialoguelbl.Text = "Хоча й Лиходій пав від вашої руки, проте рана, що він вам завдав не сумісна з життям. Ви лежите біля сходів башні та повільно помираєте.";
                    i++; break;
                case 9:
                    Dialoguelbl.Text = "Осанна плаче, та щось говорить, але ви вже нічого не чуєте. Ваше серце сповнюється гордістю та страхом. Ви не знаєте що чекає вас далі.";
                    i++; break;
                case 10:
                    Dialoguelbl.Text = "Проте ви знаєте що Леморія в надійних руках справжньої принцеси. На цьому ваш шлях завершено. Дякую що пройшли цю пригоду разом з нами.";
                    i++; break;
                case 11:
                    Continuebtn.Visible = false;
                    Returnbtn.Visible = true;
                    i++; break;
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
            EnemyBox.Items.Add(BadGuy.Name);
            EnemyBox.Items.Add($"{BadGuy.HealthPoints}/{BadGuy.MaxHealthPoints}");
            EnemyBox.Items.Add($"Міць:{BadGuy.DamageDealt}");
            EnemyBox.Items.Add($"Захист:{BadGuy.Defense}");
        }

        private void Attackbtn_Click(object sender, EventArgs e)
        {
            MC.Attack(ref BadGuy);
            if (BadGuy.HealthPoints <= 0)
            {
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                MCPicture.Visible = false;
                EnemyPicture.Visible = false;
                MCBox.Visible = false;
                EnemyBox.Visible = false;
                Dialoguelbl.Visible = true;
                Dialoguelbl.Text = "Ви перемогли Лиходія! Квест \"Перемогти Лиходія\" виконано.";
                Continuebtn.Visible = true;
            }
            Random random = new Random();
            if (random.Next(0, 10) <= 3)
            {
                MC.Attacked(BadGuy);
                if (MC.HealthPoints <= 0)
                {
                    Attackbtn.Visible = false;
                    Defensebtn.Visible = false;
                    Healbtn.Visible = false;
                    MCPicture.Visible = false;
                    EnemyPicture.Visible = false;
                    MCBox.Visible = false;
                    EnemyBox.Visible = false;
                    DialogResult result = MessageBox.Show("Програш!", "Ви програли Лиходію. Леморія вас запам'ятає.", MessageBoxButtons.OK);
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
            MC.Defended(BadGuy);
            if (MC.HealthPoints <= 0)
            {
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                MCPicture.Visible = false;
                EnemyPicture.Visible = false;
                MCBox.Visible = false;
                EnemyBox.Visible = false;
                DialogResult result = MessageBox.Show("Програш!", "Ви програли Лиходію. Леморія вас запам'ятає.", MessageBoxButtons.OK);
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
