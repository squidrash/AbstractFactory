using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory.Ultimate
{
    public class DoubleShot : IUltimate
    {
        private readonly double Damage;
        public DoubleShot(AbstractHero hero)
        {
            Damage = hero.Damage;
        }
        public string UseUltimate()
        {
            return $"персонаж совершает двойной выстрел с критическим уроном — {Damage * 2 * 1.5}";
        }
    }
}
