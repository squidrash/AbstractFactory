using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory
{
    public class ClientCode
    {
        public void Main()
        {
            Actions(new Paladin());
            Actions(new Mage());
            Actions(new Archer());
        }
        public void Actions(IHeroСapabilities hero)
        {
            var hit = hero.GetWeapon();
            var ability = hero.GetAbility();
            var ult = hero.GetUltimate();

            Console.WriteLine(hit.Hit());
            Console.WriteLine(ability.UseAbility());
            Console.WriteLine(ult.UseUltimate());

            Console.Read();
        }
    }
}
