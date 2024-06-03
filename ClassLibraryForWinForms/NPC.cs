using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryForWinForms
{
    public class NPC : Entity
    {
        public double DamageDealt { set; get; }
        public double Defense { set; get; }
        public int Race { set; get; }
        public NPC() : base()
        {
            DamageDealt = 2;
            Defense = 1;
            Race = 0;
        }
        public NPC(string name, int healthpoints, bool ismale, double damageDealt, double defense, int race) : base(name, healthpoints, ismale)
        {
            DamageDealt = damageDealt;
            Defense = defense;
            if (race == 0) { HealthPoints += 5; MaxHealthPoints = HealthPoints; }
            else if (race == 1) { DamageDealt += 1; }
            else if (race == 2) { Defense += 1; }
            else if (race == 3) { HealthPoints += 5; MaxHealthPoints = HealthPoints; DamageDealt += 1; Defense += 1; }
        }
    }
}
