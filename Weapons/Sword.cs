using System;
using System.Collections.Generic;
using System.Text;

namespace UseCase.Weapons
{
    public sealed class Sword : Weapon
    {
        public Sword() : base("sword", "Sword", "Common", 5, 0.8f)
        {
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
