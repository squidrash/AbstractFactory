using System;
using HeroAbstractFactory.Ability;
using HeroAbstractFactory.Ultimate;
using HeroAbstractFactory.Weapons;

namespace HeroAbstractFactory.HeroesFactory
{
    public interface IHeroСapabilities
    {
        IWeapon GetWeapon();
        IAbility GetAbility();
        IUltimate GetUltimate();
    }
}
