using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class MainCharacter : NPC
    {
        private string Appearance;
        public Weapon Weapon { get; set; }
        public Armour Armour { get; set; }
        public int PotionsHeld { get; set; }
        public int MoneyHeld { get; set; }
        public List<Quest> quests { get; set; }
        public MainCharacter() : base()
        {
            Armour = new Armour();
            Weapon = new Weapon();
            PotionsHeld = 5;
            MoneyHeld = 20;
            quests = new List<Quest>();
            quests.Add(new Quest());
        }
        public void Attack(ref NPC nPC)
        {
            nPC.HealthPoints -= (int)((DamageDealt + Weapon.DamageAdded) - nPC.Defense);
        }
        public void Attacked(NPC nPC)
        {
            Random random = new Random();
            if (random.Next(0, 10) <= 5)
            {
                if ((nPC.DamageDealt + 2) - (Defense + Armour.DefenseAdded) >= 0)
                {
                    HealthPoints -= (int)((nPC.DamageDealt + 2) - (Defense + Armour.DefenseAdded));
                }
            }
            else if ((nPC.DamageDealt) - (Defense + Armour.DefenseAdded) >= 0)
            {
                HealthPoints -= (int)((nPC.DamageDealt) - (Defense + Armour.DefenseAdded));
            }

        }
        public void Defended(NPC nPC)
        {
            if (nPC.DamageDealt - (Defense + 1 + Armour.DefenseAdded) >= 0)
            {
                HealthPoints -= (int)(nPC.DamageDealt - (Defense + 1 + Armour.DefenseAdded));
            }
        }
        public void Rest()
        {
            HealthPoints = MaxHealthPoints;
        }
        public void UsePotion()
        {
            if (MaxHealthPoints != HealthPoints)
            {
                PotionsHeld--;
                if (HealthPoints + 5 <= MaxHealthPoints)
                {
                    HealthPoints += 5;
                }
                else HealthPoints = MaxHealthPoints;
            }
        }
        public bool BuyPotion(int cost)
        {
            if (MoneyHeld >= cost)
            {
                return true;
            }
            else
                return false;
        }
        public void ChangeWeapon(Weapon weapon)
        {
            Weapon = weapon;
        }
        public void ChangeArmour(Armour armour)
        {
            Armour = armour;
        }
        public void FinishQuest(Quest quest)
        {
            MoneyHeld += quest.Money;
            PotionsHeld += quest.Potions;
            quests.Remove(quest);
        }
        public string GetAppearance()
        {
            return Appearance;
        }
        public void SetAppearance(string appearance)
        {
            Appearance = appearance;
        }
    }
}
