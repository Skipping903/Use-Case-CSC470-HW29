using System;

namespace UseCase.Weapons
{
    public sealed class Spear : Weapon
    {
        public Spear() : base("spear", "Spear", "Common", 4, 0.9f) 
        {
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
