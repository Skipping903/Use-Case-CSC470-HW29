using System;
using UseCase.Interfaces;

namespace UseCase.Weapons
{
    public abstract class Weapon : IDisplay
    {
        protected Weapon(string unlocalizedName, string displayName, string rarity, int damage, float hitRatio)
        {
            UnlocalizedName = unlocalizedName;
            DisplayName = displayName;
            Rarity = rarity;
            Damage = damage;
            HitRatio = hitRatio;
        }

        public virtual void Display() => Console.WriteLine("\nA {0} weapon that does {1} damage.", DisplayName, Damage);
        public virtual void Display(string contents) => Console.WriteLine(contents);

        public string UnlocalizedName { get; set; }
        public string DisplayName { get; set; }
        public string Rarity { get; set; }
        public int Damage { get; set; }
        public float HitRatio { get; set; }
    }
}
