using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class CustomQuestFactory : QuestFactory
    {
        private string name;
        private string description;
        private int money;
        private int potions;

        public CustomQuestFactory(string name, string description, int money, int potions)
        {
            this.name = name;
            this.description = description;
            this.money = money;
            this.potions = potions;
        }

        public override Quest CreateQuest()
        {
            return new Quest(name, description, money, potions);
        }
    }
}
