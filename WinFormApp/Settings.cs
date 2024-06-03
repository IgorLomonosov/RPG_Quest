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
    public partial class Settings : Form
    {
        public MainCharacter YoCharacter;
        public Story YoStory;
        public string FilePath;

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            Deletelbl.Location = new Point(400, 200);
            DeleteProgressbtn.Location = new Point((ActiveForm.Width / 2) - 550, (ActiveForm.Height / 2) - 250);
        }

        private void Returnbtn_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.YoCharacter = YoCharacter;
            menu.YoStory = YoStory;
            menu.Show();
            this.Close();
        }

        private void DeleteProgressbtn_Click(object sender, EventArgs e)
        {
            YoCharacter = new MainCharacter();
            YoStory = new Story();
            using (StreamWriter writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine($"{YoCharacter.Name}," +
                    $"{YoCharacter.MaxHealthPoints}," +
                    $"{YoCharacter.HealthPoints}," +
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
        }
    }
}