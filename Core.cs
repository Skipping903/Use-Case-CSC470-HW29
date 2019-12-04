using UseCase.Weapons;

namespace UseCase
{
    class Core
    {
        static void Main(string[] args)
        {
            Spear spear = new Spear();
            Sword sword = new Sword();
            SwordOfGonzales swordOfGonzales = new SwordOfGonzales();

            spear.Display();
            sword.Display();
            swordOfGonzales.Display("\nThe legendary weapon Mr.Gonzales' uses to open champagne bottles, and occasionally, slay his enemies with. Does " + swordOfGonzales.Damage + " damage." );
        }
    }
}
