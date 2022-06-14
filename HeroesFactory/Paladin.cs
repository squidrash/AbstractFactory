using System;
using HeroAbstractFactory.Ability;
using HeroAbstractFactory.Ultimate;
using HeroAbstractFactory.Weapons;

namespace HeroAbstractFactory.HeroesFactory
{
    public class Paladin : AbstractHero , IHeroСapabilities
    {
        public Paladin()
        {
            HP = 1000;
            Damage = 100;
        }


        public IAbility GetAbility()
        {
            return new Shield();
        }

        public IUltimate GetUltimate()
        {
            return new Healing(this);
        }

        public IWeapon GetWeapon()
        {
            return new Sword(this);
        }
    }
}
