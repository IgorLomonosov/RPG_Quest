using System;

namespace ClassLibraryForWinForms
{
    public class Entity
    {
        public int MaxHealthPoints { get; set; }
        public int HealthPoints { get; set; }
        public string Name { get; set; }
        public bool IsMale { get; set; }
        public Entity()
        {
            MaxHealthPoints = 20;    
            HealthPoints = 20;
            Name = "Невідомий";
            IsMale = true;
        }
        public Entity(string name)
        {
            Name = name;
            MaxHealthPoints = 20;
            HealthPoints = 20;
            IsMale = true;
        }
        public Entity(string name, int healthPoints, bool ismale)
        {
            Name = name;
            MaxHealthPoints = healthPoints;
            HealthPoints = healthPoints;
            IsMale = ismale;
        }
        public Entity(Entity entity)
        {
            Name = entity.Name;
            MaxHealthPoints = entity.MaxHealthPoints;
            HealthPoints = entity.HealthPoints;
            IsMale= entity.IsMale;
        }
    }
}