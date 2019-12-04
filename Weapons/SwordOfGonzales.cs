using System;
using System.Collections.Generic;
using System.Text;

namespace UseCase.Weapons
{
    public sealed class SwordOfGonzales : Weapon
    {
        public SwordOfGonzales() : base("swordOfGonzales", "Sword of Gonzales", "Legendary", 15, 1f)
        {
        }

        public override void Display(string contents)
        {
            base.Display(contents);
        }
    }
}
