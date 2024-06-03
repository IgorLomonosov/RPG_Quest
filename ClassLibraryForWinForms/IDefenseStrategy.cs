using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public interface IDefenseStrategy
    {
        void Defend(NPC npc, MainCharacter character);
    }

    public class DefaultDefenseStrategy : IDefenseStrategy
    {
        public void Defend(NPC npc, MainCharacter character)
        {
            if ((npc.DamageDealt + 2) - (character.Defense + character.Armour.DefenseAdded) >= 0)
            {
                character.HealthPoints -= (int)((npc.DamageDealt + 2) - (character.Defense + character.Armour.DefenseAdded));
            }
        }
    }
}
