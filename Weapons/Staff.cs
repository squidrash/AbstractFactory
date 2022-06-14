using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory.Weapons
{
    public class Staff : IWeapon
    {
        private readonly int Damage;
        public Staff(AbstractHero hero)
        {
            Damage = hero.Damage;
        }
        public string Hit()
        {
            return $"маг делает взмах посохом и наносит {Damage} магического урона";
        }
    }
}
