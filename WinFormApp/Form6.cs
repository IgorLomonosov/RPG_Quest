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
using System.Windows.Forms.VisualStyles;
using WinFormApp;

namespace Sweet_Pudding
{
    public partial class Form6 : Form
    {
        public Story story;
        public MainCharacter MC;
        int i;
        NPC guard;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            Explorebtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 100);
            Nextbtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2) - 100);
            Restbtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2));
            Locationlbl.Location = new Point((ActiveForm.Width / 2) - 137, 120);
            Shopbtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2));
            Dialoguelbl.Location = new Point(280, 260);
            Continuebtn.Location = new Point((ActiveForm.Width / 2) - 100, (ActiveForm.Height / 2));
            Attackbtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 50);
            Defensebtn.Location = new Point((ActiveForm.Width / 2), (ActiveForm.Height / 2) - 50);
            Healbtn.Location = new Point((ActiveForm.Width / 2) - 100, (ActiveForm.Height / 2) + 25);
            MCPicture.BackgroundImage = Image.FromFile(MC.GetAppearance());
            if (story.Location == 1)
            {
                story.Location = 2;
                story.GameState = 0;
            }
            if (story.GameState == 0)
            {
                Dialoguelbl.Visible = true;
                Continuebtn.Visible = true;
                Dialoguelbl.Text = "Ви підходите з Осанною до брами величного міста Ліанделя. Там стоять двоє стражників, що оберігають спокій.";
                i = 0;
            }
            else if (story.GameState == 1)
            {
                Dialoguelbl.Visible = false;
                Inventorybtn.Visible = true;
                Continuebtn.Visible = false;
                Returnbtn.Visible = true;
                Explorebtn.Visible = true;
                Restbtn.Visible = true;
                Locationlbl.Visible = false;
                i = 12;
            }
            else if (story.GameState == 2)
            {
                Dialoguelbl.Visible = false;
                Continuebtn.Visible = false;
                Locationlbl.Visible = true;
                Inventorybtn.Visible = true;
                Returnbtn.Visible = true;
                Explorebtn.Visible = true;
                Restbtn.Visible = true;
                Shopbtn.Visible = true;
                i = 24;
            }
        }

        private void Inventorybtn_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.MC = MC;
            inventory.story = story;
            inventory.Show();
            this.Close();
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.YoCharacter = MC;
            menu.YoStory = story;
            menu.Show();
            this.Close();
        }

        private void Restbtn_Click(object sender, EventArgs e)
        {
            MC.Rest();
        }

        private void Continuebtn_Click(object sender, EventArgs e)
        {
            switch (i)
            {
                case 0:
                    Dialoguelbl.Text = "Ви підходите ближче, коли між вами залишалось всього 5 метрів, один зі стражників викрикує:\"Стій, хто йде?Прохід у місто закритий.\"";
                    i++; break;
                case 1:
                    Dialoguelbl.Text = "Осанна намагається докричатися до стражників, коли вони починають діставати свою зброю, і здається один з них все ж прислухався до неї.";
                    i++; break;
                case 2:
                    Dialoguelbl.Text = "\"Стій Септиме, чи ти не бачиш хто перед тобою?. Це ж Осанна донька нашого короля.\" - мовив один стражник іншому.";
                    i++; break;
                case 3:
                    Dialoguelbl.Text = "\"Наш єдиний король це Лиходій, не сумнівайся в правдивості його права на владу, а то мені доведеться і тебе прикінчити.\"";
                    i++; break;
                case 4:
                    Dialoguelbl.Text = "Стражник дістає зброю та йде у ваш бік, готуйтеся до бою!";
                    i++; break;
                case 5:
                    Dialoguelbl.Visible = false;
                    Continuebtn.Visible = false;
                    Attackbtn.Visible = true;
                    Defensebtn.Visible = true;
                    Healbtn.Visible = true;
                    MCPicture.Visible = true;
                    MCBox.Visible = true;
                    EnemyPicture.Visible = true;
                    EnemyBox.Visible = true;
                    guard = new NPC("Стражник Ліанделя", 20, true, 3, 2, 3);
                    MCRefresh();
                    EnemyRefresh();
                    EnemyPicture.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\Guard.png");
                    i++; break;
                case 6:
                    Dialoguelbl.Text = "Стражник падає до ваших ніг замертво. Коли підбігає другий стражник і починає з вами діалог.";
                    i++; break;
                case 7:
                    Dialoguelbl.Text = "\"Місс Осанно, це ви? Я не можу повірити своїм очам. Це значить, що надія ще є, не зважайте на цього бовдура, йому промили мізки\"";
                    i++; break;
                case 8:
                    Dialoguelbl.Text = $"Осанна йому відповідає:\"Так, надія є, і вона у руках цього героя, {MC.Name} намагається перемогти Лиходія.\"";
                    i++; break;
                case 9:
                    Dialoguelbl.Text = "\"Зрозуміло, ми йому допоможемо, я проведу вас у місто, вам потрібно знайти Царибея, тільки у нього є ключ від башні Лиходія.\"";
                    i++; break;
                case 10:
                    Dialoguelbl.Text = "Стражник проводить вас у місто та розказує де знайти Царибея. Новий квест \"Знайти Царибея\".";
                    MC.quests.Add(new Quest("Знайти Царибея", "Царибей ховається десь у Ліанделі, знайдіть його.", 50, 5));
                    i++; break;
                case 11:
                    story.GameState = 1;
                    Dialoguelbl.Visible = false;
                    Inventorybtn.Visible = true;
                    Continuebtn.Visible = false;
                    Returnbtn.Visible = true;
                    Explorebtn.Visible = true;
                    Restbtn.Visible = true;
                    Locationlbl.Visible = true;
                    i++; break;
                case 12:
                    Dialoguelbl.Text = "Він зрозумів, що Лиходій просто захопив владу, вбивши минулого короля, та був одним з тих хто позбувся Осанни, прийнамі думав так.";
                    i++; break;
                case 13:
                    Dialoguelbl.Text = "Тим часом, ви вже підійшли до потрібного будинку. Біля вікна вісить вивіска \"Товари Ліанделя\"";
                    i++; break;
                case 14:
                    Dialoguelbl.Text = "Ви заходите у магазин, та не бачите жодної душі, ні клієнтів, ні продавця. Трохи згодом ви чуєте тихе хрипіння за прилавком.";
                    i++; break;
                case 15:
                    Dialoguelbl.Text = "За прилавком спить високий сивий чоловік. Мабуть люди не часто сюди заходять і тут досить таки нудно. Осанна стукає по прилавку.";
                    i++; break;
                case 16:
                    Dialoguelbl.Text = "\"Хто тут? А, вибачаюсь. Це лавка товарів Ліанделя. Прошу дивіться що вам подобається. У нас є... Зачекайте, місс Осанна це ви?\"";
                    i++; break;
                case 17:
                    Dialoguelbl.Text = "Чоловік починає плакати, падає на коліна та кланяється перед принцесою. Це відбувається недовго, проте ця картина засіла у вас в голові.";
                    i++; break;
                case 18:
                    Dialoguelbl.Text = "\"Вибачте за мою емоційність, просто я аж ніяк не очікував вас тут побачити. Я так винен перед вами та вашим батьком. Що привело вас сюди?\"";
                    i++; break;
                case 19:
                    Dialoguelbl.Text = "Осанна трохи відійшла та сказала: \"Я знаю про ваші дії, та те до чого вони привели. Проте я готова вас пробачити, якщо ви допоможете нам перемогти Лиходія\".";
                    i++; break;
                case 20:
                    Dialoguelbl.Text = "\"Звичайно, я вам допоможу, і я готовий допомгти вам провізією. Та якщо вам щось знадобиться то ви можете це придбати в моєму магазині\".";
                    i++; break;
                case 21:
                    Dialoguelbl.Text = "Квест \"Знайти Царибея\" виконано. Ви отримали 5 зілль здоров'я та мішечок з золотими монетами(50)";
                    MC.FinishQuest(MC.quests[1]);
                    i++; break;
                case 22:
                    Dialoguelbl.Text = "Коли ви будете готові ми підемо до вежі Лиходія. Я буду чекати вас біля брами до замку. А поки що, можете купити що захочете.";
                    i++; break;
                case 23:
                    story.GameState = 2;
                    Dialoguelbl.Visible = false;
                    Continuebtn.Visible = false;
                    Locationlbl.Visible = true;
                    Inventorybtn.Visible = true;
                    Returnbtn.Visible = true;
                    Explorebtn.Visible = true;
                    Restbtn.Visible = true;
                    Shopbtn.Visible = true;
                    i++; break;
                case 24:
                    EnemyPicture.BackgroundImage = Image.FromFile("C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\images\\SecondGuard.png");
                    guard = new NPC("Помічник Лиходія", 22, true, 6, 3, 3);
                    Continuebtn.Visible = false;
                    Dialoguelbl.Visible = false;
                    Attackbtn.Visible = true;
                    Defensebtn.Visible = true;
                    Healbtn.Visible = true;
                    MCPicture.Visible = true;
                    EnemyPicture.Visible = true;
                    MCBox.Visible = true;
                    EnemyBox.Visible = true;
                    MCRefresh();
                    EnemyRefresh();
                    i++; break;
                case 25:
                    Dialoguelbl.Text = "Після перемоги над Помічником Лиходія ви знаходите непритомного Царибея. Через деякий час він приходить у себе";
                    i++; break;
                case 26:
                    Dialoguelbl.Text = "\"Дякую вам що знову мені допомогли. Нам залишилося тільки одне, пройти до вежі та подолати Лиходія. Тож ходімте!\"";
                    i++; break;
                case 27:
                    Nextbtn.Visible = true;
                    Continuebtn.Visible = false;
                    break;
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
            EnemyBox.Items.Add(guard.Name);
            EnemyBox.Items.Add($"{guard.HealthPoints}/{guard.MaxHealthPoints}");
            EnemyBox.Items.Add($"Міць:{guard.DamageDealt}");
            EnemyBox.Items.Add($"Захист:{guard.Defense}");
        }

        private void Attackbtn_Click(object sender, EventArgs e)
        {
            MC.Attack(ref guard);
            if (guard.HealthPoints <= 0)
            {
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                MCPicture.Visible = false;
                EnemyPicture.Visible = false;
                MCBox.Visible = false;
                EnemyBox.Visible = false;
                if (story.GameState == 0)
                {
                    Dialoguelbl.Visible = true;
                    Dialoguelbl.Text = "Ви перемогли стражника! Ви отримали Залізний меч та Залізну броню.";
                    story.IronArmourAquired = true;
                    story.IronSwordAquired = true;
                }
                else if (story.GameState == 2)
                {
                    Dialoguelbl.Visible = true;
                    Dialoguelbl.Text = "Ви перемогли Помічника Лиходія! Ви отримали Ключ від брами замку";
                    story.KeyFromTowerAquired = true;
                }
                Continuebtn.Visible = true;
            }
            Random random = new Random();
            if (random.Next(0, 10) <= 3)
            {
                MC.Attacked(guard);
                if (MC.HealthPoints <= 0)
                {
                    Attackbtn.Visible = false;
                    Defensebtn.Visible = false;
                    Healbtn.Visible = false;
                    MCPicture.Visible = false;
                    EnemyPicture.Visible = false;
                    MCBox.Visible = false;
                    EnemyBox.Visible = false;
                    DialogResult result = MessageBox.Show("Програш!", "Ви програли стражнику", MessageBoxButtons.OK);
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
            MC.Defended(guard);
            if (MC.HealthPoints <= 0)
            {
                Attackbtn.Visible = false;
                Defensebtn.Visible = false;
                Healbtn.Visible = false;
                MCPicture.Visible = false;
                EnemyPicture.Visible = false;
                MCBox.Visible = false;
                EnemyBox.Visible = false;
                DialogResult result = MessageBox.Show("Програш!", "Ви програли стражнику", MessageBoxButtons.OK);
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

        private void Explorebtn_Click(object sender, EventArgs e)
        {
            if (story.GameState == 1)
            {
                Explorebtn.Visible = false;
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Restbtn.Visible = false;
                Continuebtn.Visible = true;
                Dialoguelbl.Visible = true;
                Dialoguelbl.Text = "Ви йдете по місту в пошуках Царибея. Стражник розповів що Царибей раніше був на службі у Лиходія, проте пішов від нього.";
            }
            else if (story.GameState == 2)
            {
                Explorebtn.Visible = false;
                Inventorybtn.Visible = false;
                Returnbtn.Visible = false;
                Restbtn.Visible = false;
                Shopbtn.Visible = false;
                Continuebtn.Visible = true;
                Dialoguelbl.Visible = true;
                Locationlbl.Visible = false;
                Dialoguelbl.Text = "Ви з принцесою підходите до брами замку, де вже чекає спеціальний сторож Лиходія. Приготуйтеся до бою!";
            }
        }

        private void Shopbtn_Click(object sender, EventArgs e)
        {
            Inventorybtn.Visible = false;
            Returnbtn.Visible = false;
            Restbtn.Visible = false;
            Explorebtn.Visible = false;
            Shopbtn.Visible = false;
            Locationlbl.Visible = false;
            ExitShopbtn.Visible = true;
            if (!story.PlateArmourAquired)
            {
                Buyarmourbtn.Visible = true;
                ArmourPricelbl.Visible = true;
            }
            if (!story.CurvedDaggerAquired)
            {
                Buydaggerbtn.Visible = true;
                DaggerPricelbl.Visible = true;
            }
            Buypotionbtn.Visible = true;
            PotionPricelbl.Visible = true;
            MCmoneylbl.Visible = true;
            MCmoneylbl.Text = $"Ваші гроші: {MC.MoneyHeld}";
        }

        private void Buydaggerbtn_Click(object sender, EventArgs e)
        {
            if (!story.CurvedDaggerAquired)
            {
                if (MC.MoneyHeld - 50 >= 0)
                {
                    story.CurvedDaggerAquired = true;
                    MC.MoneyHeld -= 50;
                    MCmoneylbl.Text = $"Ваші гроші: {MC.MoneyHeld}";
                    Buydaggerbtn.Visible = false;
                    DaggerPricelbl.Visible = false;
                }
                else MessageBox.Show("У вас недостатньо золота для покупки!");
            }
            else
            {
                MessageBox.Show("У вас вже є ця зброя!");
                Buydaggerbtn.Visible = false;
                DaggerPricelbl.Visible = false;
            }
        }

        private void Buyarmourbtn_Click(object sender, EventArgs e)
        {
            if (!story.PlateArmourAquired)
            {
                if (MC.MoneyHeld - 50 >= 0)
                {
                    story.PlateArmourAquired = true;
                    MC.MoneyHeld -= 50;
                    ArmourPricelbl.Visible = false;
                    Buyarmourbtn.Visible = false;
                    MCmoneylbl.Text = $"Ваші гроші: {MC.MoneyHeld}";
                }
                else MessageBox.Show("У вас недостатньо золота для покупки!");
            }
            else
            {
                MessageBox.Show("У вас вже є ця броня!");
                Buyarmourbtn.Visible = false;
                ArmourPricelbl.Visible = false;
            }
        }

        private void Buypotionbtn_Click(object sender, EventArgs e)
        {
            if (MC.BuyPotion(5))
            {
                MC.PotionsHeld++;
                MC.MoneyHeld -= 5;
                MCmoneylbl.Text = $"Ваші гроші: {MC.MoneyHeld}";
            }
            else MessageBox.Show("У вас недостатньо золота для покупки!");
        }

        private void ExitShopbtn_Click(object sender, EventArgs e)
        {
            Inventorybtn.Visible = true;
            Explorebtn.Visible = true;
            Returnbtn.Visible = true;
            Restbtn.Visible = true;
            Shopbtn.Visible = true;
            Locationlbl.Visible = true;
            Buyarmourbtn.Visible = false;
            Buydaggerbtn.Visible = false;
            Buypotionbtn.Visible = false;
            DaggerPricelbl.Visible = false;
            MCmoneylbl.Visible = false;
            ArmourPricelbl.Visible = false;
            PotionPricelbl.Visible = false;
            ExitShopbtn.Visible = false;

        }

        private void Nextbtn_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.story = story;
            form7.MC = MC;
            form7.Show();
            this.Close();
        }
    }
}