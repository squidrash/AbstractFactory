using System;
using HeroAbstractFactory.Ability;
using HeroAbstractFactory.Ultimate;
using HeroAbstractFactory.Weapons;

namespace HeroAbstractFactory.HeroesFactory
{
    public class Mage :AbstractHero, IHeroСapabilities
    {
        public Mage()
        {
            HP = 300;
            Damage = 300;
        }


        public IAbility GetAbility()
        {
            return new Freeze();
        }

        public IUltimate GetUltimate()
        {
            return new Lighting(this);
        }

        public IWeapon GetWeapon()
        {
            return new Staff(this);
        }
    }
}
