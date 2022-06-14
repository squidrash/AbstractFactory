using System;
using HeroAbstractFactory.Ability;
using HeroAbstractFactory.Ultimate;
using HeroAbstractFactory.Weapons;

namespace HeroAbstractFactory.HeroesFactory
{
    public class Archer : AbstractHero, IHeroСapabilities
    {
        public Archer()
        {
            HP = 500;
            Damage = 200;
            CritChance = 30;
        }

        public IAbility GetAbility()
        {
            return new StepBack();
        }

        public IUltimate GetUltimate()
        {
            return new DoubleShot(this);
        }

        public IWeapon GetWeapon()
        {
            return new Bow(this);
        }
    }
}
