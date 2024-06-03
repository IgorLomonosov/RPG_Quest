using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public interface IAttackStrategy
    {
        void Attack(ref NPC npc, MainCharacter character);
    }

    public class DefaultAttackStrategy : IAttackStrategy
    {
        public void Attack(ref NPC npc, MainCharacter character)
        {
            npc.HealthPoints -= (int)((character.DamageDealt + character.Weapon.DamageAdded) - npc.Defense);
        }
    }

}
