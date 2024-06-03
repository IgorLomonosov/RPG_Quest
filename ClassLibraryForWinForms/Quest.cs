using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class Quest
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Money { get; set; }
        public int Potions { get; set; }
        public Quest()
        {
            Name = "Врятувати світ";
            Description = "Перемогти лиходія та повернути мир та спокій в Лемурію.";
            Money = 10;
            Potions = 1;
        }
        public Quest(string name, string description, int money, int potions)
        {
            Name = name;
            Description = description;
            Money = money;
            Potions = potions;
        }
    }
}
