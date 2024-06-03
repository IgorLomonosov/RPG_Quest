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
        private int potionsHeld;
        private int moneyHeld;

        public int PotionsHeld
        {
            get { return potionsHeld; }
            set { potionsHeld = value; }
        }

        public int MoneyHeld
        {
            get { return moneyHeld; }
            set { moneyHeld = value; }
        }

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
        public void Attacked(NPC npc)
        {
            Random random = new Random();
            int damage = CalculateDamage(npc, random);
            if (damage >= 0)
            {
                HealthPoints -= damage;
            }
        }

        private int CalculateDamage(NPC npc, Random random)
        {
            int damage;
            if (random.Next(0, 10) <= 5)
            {
                damage = (int)((npc.DamageDealt + 2) - (Defense + Armour.DefenseAdded));
            }
            else
            {
                damage = (int)(npc.DamageDealt - (Defense + Armour.DefenseAdded));
            }
            return damage;
        }

        public void Rest()
        {
            HealthPoints = MaxHealthPoints;
        }
        public void UsePotion()
        {
            const int potionHealingAmount = 5;
            if (MaxHealthPoints != HealthPoints)
            {
                PotionsHeld--;
                if (HealthPoints + potionHealingAmount <= MaxHealthPoints)
                {
                    HealthPoints += potionHealingAmount;
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
