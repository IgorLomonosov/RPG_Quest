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

        private IAttackStrategy attackStrategy;
        private IDefenseStrategy defenseStrategy;

        public MainCharacter() : base()
        {
            Armour = new Armour();
            Weapon = new Weapon();
            PotionsHeld = 5;
            MoneyHeld = 20;
            quests = new List<Quest>();
            quests.Add(new Quest());
            attackStrategy = new DefaultAttackStrategy();
            defenseStrategy = new DefaultDefenseStrategy();
        }

        public void Attack(ref NPC npc)
        {
            attackStrategy.Attack(ref npc, this);
        }

        public void Defended(NPC npc)
        {
            defenseStrategy.Defend(npc, this);
        }

        public void SetAttackStrategy(IAttackStrategy strategy)
        {
            attackStrategy = strategy;
        }

        public void SetDefenseStrategy(IDefenseStrategy strategy)
        {
            defenseStrategy = strategy;
        }
        public void Rest()
        {
            HealthPoints = MaxHealthPoints;
        }
        public void UsePotion()
        {
            if (PotionsHeld <= 0)
            {
                throw new InvalidOperationException("No potions available");
            }

            if (MaxHealthPoints != HealthPoints)
            {
                PotionsHeld--;
                HealthPoints = Math.Min(HealthPoints + 5, MaxHealthPoints);
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
