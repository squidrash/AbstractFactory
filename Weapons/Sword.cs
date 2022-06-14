using System;
using HeroAbstractFactory.HeroesFactory;

namespace HeroAbstractFactory.Weapons
{
    public class Sword :IWeapon
    {
        private readonly int Damage;
        private readonly double BonusDamage;
        public Sword(AbstractHero hero)
        {
            Damage = hero.Damage;
            BonusDamage = hero.HP * 0.1;
        }
        public string Hit()
        {
            return $"делает удар мечом и наносит {Damage + BonusDamage} урона";
        }
    }
}
