using ClassLibraryForWinForms;
using Sweet_Pudding;

namespace WinFormApp
{
    public partial class Menu : Form
    {
        MainCharacter MC = new MainCharacter();
        public MainCharacter YoCharacter = new MainCharacter();
        Story story = new Story();
        public Story YoStory = new Story();
        string FilePath = "C:\\Users\\Lomonosov\\source\\repos\\labs(2)\\OOP\\1_year_course\\Save.txt";
        public Menu()
        {
            InitializeComponent();
        }
        private void Play_button_Click(object sender, EventArgs e)
        {
            switch (story.Location)
            {
                case 0:
                    Prologue form = new Prologue();
                    form.MC = MC;
                    form.story = story;
                    form.Show();
                    this.Hide();
                    break;
                case 1:
                    Form4 form4 = new Form4();
                    form4.MC = MC;
                    form4.story = story;
                    form4.Show();
                    this.Hide();
                    break;
                case 2:
                    Form6 form6 = new Form6();
                    form6.MC = MC;
                    form6.story = story;
                    form6.Show();
                    this.Hide();
                    break;
                case 3:
                    Form7 form7 = new Form7();
                    form7.MC = MC;
                    form7.story = story;
                    form7.Show();
                    this.Hide();
                    break;
            }
        }
        private void Settingsbtn_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.FilePath = FilePath;
            settings.YoCharacter = YoCharacter;
            settings.YoStory = YoStory;
            settings.Show();
            this.Hide();
        }
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine($"{YoCharacter.Name}," +
                    $"{YoCharacter.HealthPoints}," +
                    $"{YoCharacter.MaxHealthPoints}," +
                    $"{YoCharacter.IsMale}," +
                    $"{YoCharacter.DamageDealt}," +
                    $"{YoCharacter.Defense}," +
                    $"{YoCharacter.Race}," +
                    $"{YoCharacter.GetAppearance()}," +
                    $"{YoCharacter.MoneyHeld}," +
                    $"{YoCharacter.PotionsHeld}," +
                    $"{YoCharacter.Weapon.Name}," +
                    $"{YoCharacter.Weapon.DamageAdded}," +
                    $"{YoCharacter.Armour.Name}," +
                    $"{YoCharacter.Armour.DefenseAdded}," +
                    $"{YoCharacter.quests.Count}");
                if(YoCharacter.quests.Count > 1)
                {
                    for (int i = 1; i < YoCharacter.quests.Count; i++)
                    {
                        writer.WriteLine($"{YoCharacter.quests[i].Name},{YoCharacter.quests[i].Description},{YoCharacter.quests[i].Money},{YoCharacter.quests[i].Potions}");
                    }
                }
                writer.WriteLine($"{YoStory.Location}," +
                    $"{YoStory.GameState}," +
                    $"{YoStory.LeatherArmourAquired}," +
                    $"{YoStory.HardenedLeatherArmourAquired}," +
                    $"{YoStory.IronArmourAquired}," +
                    $"{YoStory.PlateArmourAquired}," +
                    $"{YoStory.WoodenSwordAquired}," +
                    $"{YoStory.StoneSwordAquired}," +
                    $"{YoStory.IronSwordAquired}," +
                    $"{YoStory.CurvedDaggerAquired}," +
                    $"{YoStory.KeyFromTowerAquired}");
            }
            this.Close();
            Close();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Play_button.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 200);
            Settingsbtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 130);
            Exitbtn.Location = new Point((ActiveForm.Width / 2) - 200, (ActiveForm.Height / 2) - 60);
            FileInfo fileInfo = new FileInfo(FilePath);
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                if (fileInfo.Length != 0)
                {
                    string Character = reader.ReadLine();
                    string[] parts = Character.Split(',');
                    MC.Name = parts[0];
                    MC.HealthPoints = Convert.ToInt32(parts[1]);
                    MC.MaxHealthPoints = Convert.ToInt32(parts[2]);
                    MC.IsMale = parts[3] == "True";
                    MC.DamageDealt = int.Parse(parts[4]);
                    MC.Defense = int.Parse(parts[5]);
                    MC.Race = int.Parse(parts[6]);
                    MC.SetAppearance(parts[7]);
                    MC.MoneyHeld = int.Parse(parts[8]);
                    MC.PotionsHeld = int.Parse(parts[9]);
                    MC.Weapon.Name = parts[10];
                    MC.Weapon.DamageAdded = int.Parse(parts[11]);
                    MC.Armour.Name = parts[12];
                    MC.Armour.DefenseAdded = int.Parse(parts[13]);
                    int count = int.Parse(parts[14]);
                    if(count > 1) 
                    {
                        string quests;
                        string[] questparts;
                        for (int i = 0; i < count-1; i++)
                        {
                            quests = reader.ReadLine();
                            questparts = quests.Split(',');
                            MC.quests.Add(new Quest(questparts[0], questparts[1], int.Parse(questparts[2]), int.Parse(questparts[3])));
                        }
                    }
                    string Story = reader.ReadLine();
                    parts = Story.Split(',');
                    story.Location = int.Parse(parts[0]);
                    story.GameState = int.Parse(parts[1]);
                    story.LeatherArmourAquired = parts[2] == "True";
                    story.HardenedLeatherArmourAquired = parts[3] == "True";
                    story.IronArmourAquired = parts[4] == "True";
                    story.PlateArmourAquired = parts[5] == "True";
                    story.WoodenSwordAquired = parts[6] == "True";
                    story.StoneSwordAquired = parts[7] == "True";
                    story.IronSwordAquired = parts[8] == "True";
                    story.CurvedDaggerAquired = parts[9] == "True";
                    story.KeyFromTowerAquired = parts[10] == "True";
                }
            }
        }
    }
}